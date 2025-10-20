// using System;
// using System.Collections.Generic;
//
// namespace ConsoleApplication1.NewDirectory1
// {
//     public class Check_First_Non_Duplicate
//     {
//         public static void Main(string[] args)
//         {
//             string str = Console.ReadLine();
//             Dictionary<char, int> map=new Dictionary<char, int>();
//
//             for (int i = 0; i < str.Length; i++)
//             {
//                 if (map.ContainsKey(str[i]))
//                 {
//                     map[str[i]]++;
//                 }
//                 else
//                 {
//                     map[str[i]] = 1;
//                 }
//             }
//
//             foreach (var items in map)
//             {
//                 if (items.Value == 1)
//                 {
//                     Console.WriteLine(items.Key);
//                     break;
//                 }
//             }
//         }
//     }
// }