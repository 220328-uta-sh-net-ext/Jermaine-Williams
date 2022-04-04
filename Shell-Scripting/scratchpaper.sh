#! /usr/bin/bash

# read x
# read y

# sum=$((x+y))
# sub=$((x-y))
# mul=$((x*y))
# div=$((x/y))

# echo $sum
# echo $sub
# echo $mul
# echo $div

# read x 
# read y

# if [ $x -lt $y ]
# then echo "X is less than Y"
    
# elif [ $x -gt $y ]
#     then echo "X is greater than Y"

# else echo "X is equal to Y"
# fi

# for i in $(seq 1 2 99)
#  do 
#     echo $i
# done

read st 

if [ "$st" == "n" ] || [ "$st" == "N" ]
    then echo "NO"
 
elif [ "$st" == "y" ] || [ "$st" == "Y" ]
    then echo "YES"

fi

# read x 
# read y 
# read z 

# if [ "$x" == "$y" ] && [ "$x" == "$z" ] && [ "$y" == "$z" ]
# then echo "EQUILATERAL"

# elif [ "$x" == "$y" ] || [ "$x" == "$z" ] || [ "$y" == "$z" ]
# then echo "ISOSCELES"

# else 
#     echo "SCALENE"
# fi