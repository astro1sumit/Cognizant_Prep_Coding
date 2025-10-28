// using System;
//
// namespace ConsoleApplication1.NewDirectory1
// {
//     public class Check_Reverse
//     {
//         public static void Main(string[] args)
//         {
//             string str=Console.ReadLine();
//             string result="";
//             for (int i = str.Length-1;i>=0; i--)
//             {
//                 result+=str[i];
//             }
//             Console.WriteLine(result);
//         }
//     }
// }

// Using Stringbuilder

// using System;
// using System.Text;
//
// namespace ConsoleApplication1.NewDirectory1 {
//     public class Check_Reverse {
//         public static void Main(string[] args) {
//             string str=Console.ReadLine();
//             StringBuilder result = new StringBuilder();
//             for (int i = str.Length - 1; i >= 0; i--)
//             {
//                 result.Append(str[i]);
//             }
//             Console.WriteLine(result);
//         }
//     }
// }