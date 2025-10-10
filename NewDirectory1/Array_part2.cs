// using System;
//
// namespace ConsoleApplication1.NewDirectory1
// {
//     public class Array_part
//     {
//         public static void Main(string[] args)
//         {
//             int input1 = int.Parse(Console.ReadLine());
//             int[] arr=new int[input1];
//             for (int i = 0; i < arr.Length; i++) {
//                 arr[i] = int.Parse(Console.ReadLine());
//             }
//
//             int Totalsum=0;
//             for (int i = 0; i < arr.Length; i++) {
//                 Totalsum+=arr[i];
//             }
//
//             int count = 0;
//             int preSum = 0;
//             for (int i = 0; i < arr.Length-1; i++) {
//                 preSum=preSum+arr[i];
//                 
//                 int secondSum=Totalsum-preSum;
//                 if (Math.Abs(secondSum-preSum)%2==0) {
//                     count++;
//                 }
//             }
//             Console.WriteLine(count);
//         }
//     }
// }