// using System;
//
// namespace ConsoleApplication1.NewDirectory1
// {
//     public class nth_prime
//     {
//         public static void Main(string[] args)
//         {
//             int count = 0;
//             int num = 1;
//             while (count != 6)
//             {
//                 num++;
//                 if (isPrime(num))
//                 {
//                     count++;
//                 }
//             }
//
//             Console.WriteLine(num);
//         }
//
//         public static Boolean isPrime(int num)
//         {
//             if (num == 2)
//             {
//                 return true;
//             }
//
//             for (int i = 2; i <= num / 2; i++)
//             {
//                 if (num % i == 0)
//                 {
//                     return false;
//                 }
//             }
//             return true;
//         }
//         
//     }
// }