// using System;
// using System.Collections.Generic;
// using System.Linq;
//
// namespace ConsoleApplication1.NewDirectory1
// {
//     public class StartingEndingPair8
//     {
//         public static void Main(string[] args)
//         {
//             string str = Console.ReadLine();
//             Dictionary<string, int> map = new Dictionary<string, int>();
//
//             foreach (string s in str.Split(' '))
//             {
//                 string hp = s[0] + "" + "" + s[s.Length - 1];
//                 if (map.ContainsKey(hp))
//                 {
//                     map[hp]++;
//                 }
//                 else
//                 {
//                     map.Add(hp, 1);
//                 }
//             }
//
//             int max = map.Values.Max();
//             foreach (var m in map.Keys)
//             {
//                 if (map[m]== max)
//                 {
//                     Console.WriteLine(m);
//                 }
//             }
//         }
//     }
// }