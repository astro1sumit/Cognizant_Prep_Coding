// using System;
//
// namespace ConsoleApplication1.NewDirectory1
// {
//     public class count_factor
//     {
//         public static void Main(string[] args)
//         {
//             int[] arr={1,2,3,4,5,6,8};
//             int count = 0;
//             int sum = 0;
//             for (int i = 0; i < arr.Length; i++)
//             {
//                 for (int j = 1; j <= arr[i]; j++)
//                 {
//                     if (arr[i] % j == 0)
//                     {
//                         count++;
//                     }
//                 }
//                 if (count > 2)
//                 {
//                     sum++;
//                 }
//
//                 count = 0;
//             }
//             Console.WriteLine(sum);
//         }
//     }
// }