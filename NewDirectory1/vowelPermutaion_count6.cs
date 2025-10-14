// using System;
//
// namespace ConsoleApplication1
// {
//     public class vowelPermutaion_count6
//     {
//         public static void Main(string[] args)
//         {
//             string str = Console.ReadLine().ToLower();
//
//
//             int size = str.Length;
//             for (int i = 0; i < str.Length; i++) {
//                 if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u'){
//                     size--;
//                 }
//             }
//
//             int result = 1;
//             if (size <= 0) {
//                 Console.WriteLine("no");
//                 
//             }else {
//                 while (size>0)
//                 {
//                     result = result * size;
//                     size--;
//                 }
//             }
//             Console.WriteLine(result);
//         }
//     }
// }