#! /usr/bin/bash

read -r -p 'Please enter a number between 1 and 20: ' num

if [ "$num" -le 0 ] || [ "$num" -ge 21 ] 
    then echo "Wrong number. Please enter a number between 1 and 20. "
fi

if (( num % 3 == 0 )) && (( num % 5 == 0 ))
    then echo "FizzBuzz"

    elif (( num % 3 == 0 ))
    then echo "Fizz"

    elif (( num % 5 == 0 ))
    then echo "Buzz"
fi