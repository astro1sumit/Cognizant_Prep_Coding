// using System;
// using System.Collections.Generic;
// using System.Data;
// using System.Linq;
//
// namespace ConsoleApplication1.NewDirectory1
// {
//     public class Unique_positive14
//     {
//         public static void Main(string[] args)
//         {
//             int N = int.Parse(Console.ReadLine());
//             int[][] array=new int[N][];
//             
//             Dictionary<int, int> map= new Dictionary<int, int>();
//
//             for (int i = 0; i < N; i++)
//             {
//                 array[i] = new int[N];
//                 for (int j = 0; j < N; j++)
//                 {
//                     array[i][j] = int.Parse(Console.ReadLine());
//                     if (map.ContainsKey(array[i][j]))
//                     {
//                         map[array[i][j]]=0;
//                     }
//                     else
//                     {
//                         map.Add(array[i][j], 1);
//                     }
//                 }
//             }
//
//             int min = int.MaxValue;
//             foreach (var item in map)
//             {
//                 if (item.Value != 0 && item.Key>-1)
//                 {
//                     min = Math.Min(min, item.Key);
//                 }
//             }
//             Console.WriteLine(min);
//         }
//     }
// }