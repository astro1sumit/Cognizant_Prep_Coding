// using System;
// namespace ConsoleApplication1.NewDirectory1
// {
//     public class Permutaion_count
//     {
//         public static void Main(string[] args)
//         {
//             int size = int.Parse(Console.ReadLine());
//             string[] arr = new string[size];
//
//             for (int i = 0; i < size; i++)
//             {
//                 arr[i] = Console.ReadLine();
//             }
//
//             int count = 0;
//             for (int i = 0; i < size; i++)
//             {
//                 for (int j = 0; j < arr[i].Length; j++)
//                 {
//                     string str = arr[i];
//                     if (str[j] != 'a' && str[j] != 'e' && str[j] != 'i' && str[j] != 'o' &&
//                         str[j] != 'u')
//                     {
//                         count++;
//                     }
//                 }
//             }
//
//             if (count == 0)
//             {
//                 Console.WriteLine(0);
//             }
//             else
//             {
//                 int result = 1;
//                 while (count > 0)
//                 {
//                     result = result * count;
//                     count--;
//                 }
//                 Console.WriteLine(result);
//             }
//         }
//     }
// }