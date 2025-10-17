// using System;
//
// namespace ConsoleApplication1.NewDirectory1
// {
//     public class Count_Greater_Number12
//     {
//         public static void Main(string[] args)
//         {
//             int terms = int.Parse(Console.ReadLine());
//             int[] array = new int[terms];
//
//             for (int i = 0; i < terms; i++)
//             {
//                 array[i]= int.Parse(Console.ReadLine());
//             }
//             int[] array2 = new int[terms];
//             int k = 0;
//             for (int i = 0; i < array.Length; i++)
//             {
//                 int count = 0;
//                 if (i == 0){
//                     if (array[i] < array[terms - 1])
//                     {
//                         count++;
//                     }
//                     if (array[i] < array[i + 1])
//                     {
//                         count++;
//                     }
//                 }
//                 else if (i == terms - 1){
//                         if (array[i] < array[i - 1])
//                         {
//                             count++;
//                         }
//                         if (array[i] < array[0])
//                         {
//                             count++;
//                         }
//                 }
//                 else{
//                         if (array[i] < array[i - 1])
//                         {
//                             count++;
//                         }
//                         if (array[i] < array[i + 1])
//                         {
//                             count++;
//                         }
//                 }
//                 array2[k++] = count;
//             }
//
//             foreach (int elem in array2)
//             {
//                 Console.WriteLine(elem);
//             }
//         }
//     }
// }