#! /usr/bin/bash

echo "Welcome to the Mighty Moprhin' Terminal Game!"  

#use the sleep command with echo and the && symbol along with the integer next to it to time the quote, it can't be a negitive integer Ex. && sleep 10 

echo "Please enter your name!"

read name

echo "Hello $name and Welcome to Angel Grove! Please, choose a ranger to play as!" && sleep 1
echo "Use the capital initials of the rangers to select them! Ex. type RR to select the Red Ranger, then press Enter."

#if you have multiple var, read them all on the same line so user doesn't have to keep hitting enter to get to the next function
read RR BR
# read BKR 
# read YR 
# read PR 
# read GR 
# read WL

 

if [ "$RR" == "RR" ]
    then echo "You've chosen the Red Ranger!" 

    elif [ $RR != "RR" ]
        then echo "You need to choose the right ranger."

elif [ "$BR" == "BR" ]
    then echo "You've chosen the Blue Ranger!"

    elif [ "$BR" != "BR" ]
        then echo "You need to choose the right ranger."

elif [ "$BKR" == "BKR" ]
    then echo "You've chosen the Black Ranger!"

    elif [ "$BKR" != "BKR" ] 
        then echo "You must choose the right ranger"

elif [ "$YR" == "YR" ]
    then echo "You've chosen the Yellow Ranger!"

    elif [ "$YR" != "YR" ]
        then echo "You must choose the right ranger"

elif [ "$PR" == "PR" ]
    then echo "You've chosen the Pink Ranger!"

    elif [ "$PR" != "PR" ]
        then echo "You must choose the right ranger"

elif [ "$GR" == "GR" ]
    then echo "You've chosen the Green Ranger!"

    elif [ "$GR" != "GR" ]
        then echo "You must choose the right ranger"

elif [ "$WL" == "WL" ]
    then echo "You've chosen the secret character, the White Ranger!"

    elif [ "$WL" != "WL" ]
        then echo "You must choose the right ranger"
    
fi