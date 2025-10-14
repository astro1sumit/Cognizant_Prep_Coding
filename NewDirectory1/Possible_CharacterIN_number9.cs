// using System;
// using System.Diagnostics.CodeAnalysis;
//
// namespace ConsoleApplication1
// {
//     public class Possible_CharacterIN_number
//     {
//         public static void Main(string[] args)
//         {
//             string number = Console.ReadLine();
//             int count = number.Length;
//
//             
//             for (int i = 0; i < number.Length-1; i++)
//             {
//                 int sum = int.Parse(number[i].ToString())*10 + int.Parse(number[i+1].ToString());
//                 if (sum <= 26)
//                 {
//                     count++;
//                 }
//             }
//             Console.WriteLine(count);
//         }
//     }
// }