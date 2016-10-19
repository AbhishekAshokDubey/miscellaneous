#firefox "http://www.google.com/" &
firefox &
sleep 5
WID=$(xdotool search "Mozilla Firefox" | head -1)
#echo $WID
#xdotool windowfocus $WID
#xdotool search "Mozilla Firefox" key F12
#xdotool windowfocus $WID
xdotool windowactivate $WID
#xdotool key F12
#xdotool key --clearmodifiers --window $WID ctrl+l
xdotool key --clearmodifiers ctrl+l
xdotool type --delay=250 www.slb.com
xdotool key --clearmodifiers Tab Return
xdotool key F12
