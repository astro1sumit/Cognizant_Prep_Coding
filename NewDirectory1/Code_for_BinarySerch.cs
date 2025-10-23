// using System;
//
// namespace ConsoleApplication1.NewDirectory1
// {
//     public class Code_for_BinarySerch {
//         public static void Main(String[] args) {
//             int[] arr = { 1,13,14,16,18,20,22,45,48,50,55,60,66 };
//             int target = 18;
//             int low = 0;
//             int high = arr.Length - 1;
//             while (low < high) {
//                 int mid = (low + (high - low) / 2);
//                 if (arr[mid] == target) {
//                     low = mid;
//                     break;
//                 }else if (arr[mid] > target){
//                     high = mid - 1;
//                 }else {
//                     low = mid + 1;
//                 }
//             }
//             if (arr[low] == target) {
//                 Console.WriteLine("Binary Serch");
//             }else {
//                 Console.WriteLine("Not Serch");
//             }
//         }
//     }
// }