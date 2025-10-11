// using System;
// namespace ConsoleApplication1.NewDirectory1
// {
//     public class target_middle {
//         public static void Main(string[] args)
//         {
//             int size = int.Parse(Console.ReadLine());
//             int[] arr = new int[size];
//
//             for (int i = 0; i < size; i++)
//             {
//                 arr[i] = int.Parse(Console.ReadLine());
//             }
//
//             int count = 0;
//             for (int i = 0; i < size-2; i++)
//             {
//                 if (arr[i] + arr[i + 2] == arr[i + 1])
//                 {
//                     count++;
//                 }
//             }
//             Console.WriteLine(count);
//         }
//     }
// }