// using System;
//
// namespace ConsoleApplication1.NewDirectory1
// {
//     public class CompleteSequence11
//     {
//         public static void Main(string[] args)
//         {
//             int terms = int.Parse(Console.ReadLine());
//             int[] seq = new int[6];
//
//             for (int i = 0; i < 6; i++)
//             {
//                 seq[i] = int.Parse(Console.ReadLine());
//             }
//             int[] result = new int[terms];
//             for (int i = 0; i < 6; i++)
//             {
//                 result[i] = seq[i];
//             }
//
//             for (int i = 6; i < terms; i++)
//             {
//                 result[i]=result[i-1]+result[i-2];
//             }
//
//             for (int i = 0; i < terms; i++)
//             {
//                 Console.Write(result[i]+" ");
//             }
//         }
//     }
// }