// using System;
// using System.Collections.Generic;
//
// namespace ConsoleApplication1.NewDirectory1
// {
//     public class addCharacter4
//     {
//         public static void Main(string[] args)
//         {
//             string str1 = Console.ReadLine();
//             string str2 = Console.ReadLine();
//
//             Dictionary<char, int> map = new Dictionary<char, int>();
//
//             for (int i = 0; i < str1.Length; i++)
//             {
//                 map[str1[i]] = i;
//             }
//
//             int count = 0;
//             for (int i = 0; i < str2.Length; i++)
//             {
//                 if (map.ContainsKey(str2[i]))
//                 {
//                     map.Remove(str2[i]);
//                 }
//                 else
//                 {
//                     count++;
//                 }
//             }
//
//             Console.WriteLine(count);
//         }
//     }
// }