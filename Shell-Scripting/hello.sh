# Single line comment

: '
this is
multi=line
Comment
'

#Shebang/hash bang -> mentions which shell to be used and it's location in OS
#! /usr/bin/bash

# print Hello World when file is ran
echo "Hello World"

# System defined variables
# We can use " " after echo command but is's not required
echo "My shell name is $BASH"
echo "My shell version $BASH_VERSION"
echo "My current directory is $PWD"
echo "My home directory is $HOME"

# User defined variables, use A-Z, a-z, 0-9, or _. no special characters
name=Jermaine
echo "The name is $name"

_USD=20
echo "The new value is $_USD"

readonly pi=3.14

#unset is used to remove a value 
#readonly var it cannot be unset

pi=22.7
echo "The value of pi is $pi"

