// using System;
// using System.Collections.Generic;
//
// namespace ConsoleApplication1.NewDirectory1
// {
//     public class Pairs_to__
//     {
//         public static void Main(string[] args)
//         {
//             string str=Console.ReadLine();
//
//             string result = "";
//             int count = 1;
//             
//             for (int i = 1; i < str.Length; i++)
//             {
//                 if (str[i] == str[i-1] )
//                 {
//                     count++;
//                 }
//                 else
//                 {
//                     result = result + str[i-1] + count;
//                     count = 1;
//                 }
//             }
//             result += str[str.Length - 1] + count.ToString();
//
//             string ans = "";
//             for (int i = 0; i < result.Length; i += 2)
//             {
//                 if (int.Parse(result[i+1].ToString())==1)
//                 {
//                     ans = ans + "#" +  result[i];
//                 }
//             }
//             Console.WriteLine(ans);
//         }
//     }
// }