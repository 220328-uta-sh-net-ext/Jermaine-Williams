// Random coin = new Random(); //making a Random object
// int flip = coin.Next(0, 2); // making the flip variable by calling the object and using the Next method with limits put on it 
// Console.Write((flip == 0) ? "heads" : "tails"); // printing out the result: if the flip equation is true, make the result be heads
// if false, the result will be false

// "?" syntax -> <evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>
//($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

// using System;

// namespace MyNewApp
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string value = "Microsoft Learn";
//             string reversedValue = Utility.Reverse(value);
//             Console.WriteLine($"Secret message: {reversedValue}");
//         }
//     }

//     class Utility
//     {
//         public static string Reverse(string message)
//         {
//             char[] letters = message.ToCharArray();
//             Array.Reverse(letters);
//             return new string(letters);
//         }
//     }
// }

// RPG template
// int hero = 10;
// int monster = 10;

// Random dice = new Random();

// do
// {
//     int roll = dice.Next(1, 11);
//     monster -= roll;
//     Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

//     if (monster <= 0) continue;

//     roll = dice.Next(1, 11);
//     hero -= roll;
//     Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

// } while (hero > 0 && monster > 0);

// Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");

// int x = 6;
// string hash = "#";

// for(int i = 0; i <= x; i++)
// {
//     if (i <= x)
//     {
//         System.Console.WriteLine(hash);;
//     }
// }

// var x = new List <int> {140537896, 243908675, 670291834, 923018467, 520718469};

// x.Sort();

// List <long> c = new List <long>();
// List <long> d = new List <long>();

//  for(int i = 0; i < x.Count; i++)
//     {
//         d.Add(Convert.ToInt64(x[i]));
//     }
        

// long y = (x.Sum() - x[4]);
// long z = (x.Sum() - x[0]);

// c.Add(y);
// c.Add(z);

//     Console.WriteLine(String.Join(" ", c));

List <int> candles = new List <int>();

candles.Add(3);
candles.Add(3);
candles.Add(3);
candles.Add(3);

int x  = 0;
candles.Sort();

for(int i = 0; i < candles.Count; i++){
    if(candles[i] == candles.Max()){
        x++;
    }

}   Console.WriteLine(x);



