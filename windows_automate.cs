using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace openNotePad
{
    class Program
    {
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        static void Main(string[] args)
        {
            Process notepad = new Process();
            notepad.StartInfo.FileName = @"C:\Windows\Notepad.exe";
            //notepad.StartInfo.FileName = @"C:\Program Files (x86)\Notepad++\Notepad++.exe";
            notepad.Start();

            // Need to wait for notepad to start
            notepad.WaitForInputIdle();

            IntPtr p = notepad.MainWindowHandle;
            ShowWindow(p, 1);
            //SendKeys.SendWait("%f");
            //SendKeys.SendWait("^O");
            //SendKeys.SendWait("(^n)");
            SendKeys.SendWait("ABC");
            SendKeys.SendWait("{ENTER}");
            SendKeys.SendWait("Hello Pradeep");
            SendKeys.SendWait("(^s)");
        }
    }
}
