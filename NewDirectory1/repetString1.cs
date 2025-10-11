// using System;
// using System.Collections.Generic;
//
// namespace ConsoleApplication1.NewDirectory1
// {
//     public class repetString
//     {
//         public static void Main(string[] args)
//         {
//             string str=Console.ReadLine();
//
//             Dictionary<char, int> map = new Dictionary<char, int>();
//             for (int i=0; i<str.Length; i++)
//             {
//                 char ch = str[i];
//                 if (!map.ContainsKey(ch))
//                 {
//                     map.Add(ch,i+1);
//                 }
//             }
//
//             string ans="";
//             for (int i = 0; i < str.Length; i++)
//             {
//                 char ch = str[i];
//                 for (int j = 0; j < map[ch]; j++)
//                 {
//                     ans = ans+"" +""+ ch;
//                     if (j == map[ch] - 1 && i<str.Length-1)
//                     {
//                         ans = ans+""+"-";
//                     }
//                 }
//             }
//             Console.WriteLine(ans);
//         }
//     }
// }