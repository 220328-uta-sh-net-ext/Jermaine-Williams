using System;


// Console.WriteLine("Enter two words you might think is are anagrams of one another."); 
// string s1 = Console.ReadLine();
// string s2 = Console.ReadLine();

// static bool Anagram (string s1, string s2){
//     if(s1.Length == s2.Length){
//         return true;
//     }
//     else{
//         return false;
//     }
// }

static bool Palindrome (string s){

    return true;
}        
        

// find a way to read the char from the first index and compare it to the last char at the last index.
// if true, continue the loop, if not, exit the loop

//palindrome program

Console.WriteLine("Enter a word you might think could be a palindrome:");

string pali = Console.ReadLine();
pali = pali.ToLower(); // <- turning input to all lowercase if there's any capitals anywhere
string reverse = ""; // <- empty string

for (int i = pali.Length - 1; i >= 0; i--) // <- for loop to get all the letters from right to left
{
    reverse += pali[i]; // <- storing the reversed word into a string var: reverse
}

if (pali == reverse)
{
    Console.WriteLine("This is a palindrome"); // <- if it matches
}
else
{
    Console.WriteLine("That's not a palindrome"); // <- if it doesn't match
}
