// using System;
//
// namespace ConsoleApplication1.NewDirectory1
// {
//     public class Check_devisivalby10
//     {
//         public static void Main(string[] args)
//         {
//             int size=int.Parse(Console.ReadLine());
//             int[] arr= new int[size];
//
//             for (int i = 0; i < size; i++)
//             {
//                 arr[i] = int.Parse(Console.ReadLine());
//             }
//
//             int count = 0;
//             for (int i = 0; i < size; i++)
//             {
//                 if (arr[i] % 10 == 0)
//                 {
//                     count++;
//                 }
//             }
//             Console.WriteLine(count);
//         }
//     }
// }