// using System;
// using System.Collections.Generic;
// using System.Linq;
//
// namespace ConsoleApplication1
// {
//     public class even_odd_difference13
//     {
//         public static void Main(string[] args)
//         {
//             string str = Console.ReadLine();
//
//             Dictionary<char, int> map = new Dictionary<char, int>();
//
//             for (int i = 0; i < str.Length; i++)
//             {
//                 if (map.ContainsKey(str[i]))
//                 {
//                     map[str[i]]++;
//                 }
//                 else
//                 {
//                     map.Add(str[i],1);
//                 }
//             }
//
//             int max = map.Values.Max();
//             int min = map.Values.Min();
//             int diff = max - min;
//             Console.WriteLine(diff);
//         }
//     }
// }