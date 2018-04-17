using System;
using System.Collections.Generic;

namespace Basic_13
{
    class Program
    {
        static void function1()
        {
            for (int i = 0; i < 256; i++){
                Console.WriteLine(i);
            }
        }
        static void function2()
        {
            for (int i = 0; i < 256; i++){
                if (i % 2 != 0){
                    Console.WriteLine(i);
                }
            }
        }
        static void function3(){
            int sum = 0;
            for (int i = 0; i < 256; i++){
                sum += i;
                Console.WriteLine("New number: {0} Sum: {1}", i, sum);
            }
        }
        static void function4(int[] num){
            for (int i = 0; i < num.Length; i++){
                Console.WriteLine(num[i]);
            }
        }
        static void function5(int[] num){
            int max = Int32.MinValue;
            for (int i = 0; i < num.Length; i++){
                if (num[i] > max){
                    max = num[i];
                }
            }
            Console.WriteLine(max);
        }
        static void function6(int[] num){
            float sum = 0;
            for (int i = 0; i < num.Length; i++){
                sum += num[i];
            }
            float newLength = num.Length;
            float ave = sum/newLength;
            Console.WriteLine(ave);
        }
        static void function7(){
            List<int> num = new List<int>();
            for (int i = 0; i < 256; i++){
                if (i % 2 != 0){
                    num.Add(i);
                }
            }
            int[] y = new int[num.Count];
            for (int i = 0; i < num.Count; i++){
                y[i] = num[i];
                Console.WriteLine(y[i]);
            }
        }
        static void function8(int[] num, int y){
            List<int> newList = new List<int>();
            for (int i = 0; i < num.Length; i++){
                if (num[i] > y){
                    newList.Add(num[i]);
                }
            }
            int[] newArray = new int[newList.Count];
            for (int i = 0; i < newList.Count; i++){
                newArray[i] = newList[i];
                Console.WriteLine(newArray[i]);
            }
        }
         static void function9(int[] num){
            List<int> newList = new List<int>();
            for (int i = 0; i < num.Length; i++){
                newList.Add(num[i]*num[i]);
            }
            int[] newArray = new int[newList.Count];
            for (int i = 0; i < newList.Count; i++){
                newArray[i] = newList[i];
                Console.WriteLine(newArray[i]);
            }
        }
        static void function10(int[] num){
            List<int> newList = new List<int>();
            for (int i = 0; i < num.Length; i++){
                if (num[i] < 0){
                    newList.Add(0);
                } else {
                    newList.Add(num[i]);
                }
            }
            int[] newArray = new int[newList.Count];
            for (int i = 0; i < newList.Count; i++){
                newArray[i] = newList[i];
                Console.WriteLine(newArray[i]);
            }
        }
        static void function11(int[] num){
            int max = Int32.MinValue;
            int min = Int32.MaxValue;
            float sum = 0;
            for (int i = 0; i < num.Length; i++){
                if (num[i] > max){
                    max = num[i];
                }
                if (num[i] < min){
                    min = num[i];
                }
                sum += num[i];
            }
            Console.WriteLine("Max: {0}", max);
            Console.WriteLine("Min: {0}", min);
            float newLength = num.Length;
            float ave = sum/newLength;
            Console.WriteLine("Ave: {0}", ave);
        }
        static void function12(int[] num){
            List<int> newList = new List<int>();
            for (int i = 1; i < num.Length; i++){
                newList.Add(num[i]);
            }
            newList.Add(0);
            int[] newArray = new int[newList.Count];
            for (int i = 0; i < newList.Count; i++){
                newArray[i] = newList[i];
            }
            for (int i = 0; i < newArray.Length; i++){
                Console.WriteLine(newArray[i]);
            }
        }
        static void function13(int[] num){
            List<object> newList = new List<object>();
            for (int i = 0; i < num.Length; i++){
                if (num[i] < 0){
                    newList.Add("Dojo");
                } else {
                    newList.Add(num[i]);
                }
            }
            object[] newArray = new object[newList.Count];
            for (int i = 0; i < newList.Count; i++){
                newArray[i] = newList[i];
            }
            for (int i = 0; i < newArray.Length; i++){
                Console.WriteLine(newArray[i]);
            }
        }
        static void Main(string[] args)
        {
            // function1();
            // Console.WriteLine("-----");
            // function2();
            // Console.WriteLine("-----");
            // function3();
            // Console.WriteLine("-----");
            // int[] newArr = {1,2,3,4,5,4,3,2,1};
            // function4(newArr);
            // Console.WriteLine("-----");
            // function5(newArr);
            // Console.WriteLine("-----");
            // function6(newArr);
            // Console.WriteLine("-----");
            // function7();
            // Console.WriteLine("-----");
            // function8(newArr, 3);
            // Console.WriteLine("-----");
            // function9(newArr);
            // Console.WriteLine("-----");
            int[] newArr1 = {1,2,-3,4,5,-4,3,2,1};
            // function10(newArr1);
            // Console.WriteLine("-----");
            // function11(newArr1);
            // Console.WriteLine("-----");
            // function12(newArr1);
            // Console.WriteLine("-----");
            function13(newArr1);
            Console.WriteLine("-----");
        }
    }
}
