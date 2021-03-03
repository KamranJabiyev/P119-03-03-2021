using System;
using System.Text;

namespace StringBuilderRefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Value,reference - ref,out
            //int a = 5;
            //int b = a; //b=5
            //b = 10;
            //Console.WriteLine($"a={a},  b={b}");

            //int[] arr = { 1, 2, 3 };
            //int[] arr1 = arr; //arr1={ 1, 2, 3 }
            //arr1[0] = 100;
            //Console.WriteLine($"arr[0]={arr[0]},  arr1[0]={arr1[0]}");

            //int a = 1;
            //ChangeValue(a);
            //Console.WriteLine($"a={a}");
            //int[] arr = { 1, 2, 3 };
            //ChangeIndex(arr);
            //Console.WriteLine($"arr[0]={arr[0]}");

            //string word = "Ferid";
            //string word2 = word;
            //word2 = "Kamran";
            //Console.WriteLine($"word={word}  ,   word2={word2}");

            //int a=1;
            //ChangeValueRef(ref a);
            ////ChangeValueOut(out a);
            //Console.WriteLine($"a={a}");
            #endregion

            #region Array,string
            #region Array
            //int[] arr = { 1, 2, 3 };
            //int[] arr = new int[] { 1, 2, 3 };
            //int[] arr = new int[3];
            //foreach (int item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //int[,] arr = new int[3,2]{ {1,2 },
            //                           {3,4 },
            //                           {5,6} };
            //Console.WriteLine(arr[2,1]);
            //int[] arr = new int[4] { 10, 21,5, 3 };
            //Array.Resize(ref arr, arr.Length + 1);
            //arr[3] = 4;
            //Console.WriteLine(arr.Length);
            //string str = String.Join("Ferid", arr);
            //Console.WriteLine(str);
            //Array.Reverse(arr);
            //Array.Sort(arr);
            //Array.Reverse(arr);
            //foreach (int item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //string word = "Gulbahar Ziver Nermin"; //['O','r','x','a','n']
            //bool result=word.ToUpper().Contains("Rx".ToUpper());
            //Console.WriteLine(result);
            //Console.WriteLine(word.Trim().Length);
            //string[] arr=word.Split(' ');
            //foreach (string item in arr)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion
            #endregion

            #region StringBuilder
            //Console.WriteLine(Reverser("google it bro"));
            //StringBuilder strB = new StringBuilder();
            //strB.Append("Kamran");
            //strB.Append("Gulbahar");
            //strB.Remove(0, 6);
            //strB.Clear();
            //Console.WriteLine(strB);
            #endregion
        }

        #region StringBuilder
        static StringBuilder Reverser(string str)
        {
            StringBuilder result = new StringBuilder();
            string[] arr = str.Split(' ');

            foreach (string item in arr)
            {

                for (int i = item.Length - 1; i >= 0; i--)
                {
                    result.Append(item[i]);
                }

                if (item != arr[arr.Length - 1])
                {
                    result.Append(" ");
                }
            }
            return result;
        }
        //static string Reverser(string str)
        //{
        //    string result = "";
        //    string[] arr = str.Split(' ');

        //    foreach (string item in arr)
        //    {
                
        //        for (int i = item.Length - 1; i >= 0; i--)
        //        {
        //            result += item[i];
        //        }
                
        //        if (item != arr[arr.Length-1])
        //        {
        //            result += " ";
        //        }
        //    }
        //    return result;
        //}
        #endregion

        #region Value,reference - ref,out
        //static void ChangeValueRef(ref int a)
        //{
        //    Console.WriteLine($"ref method - a={a}");
        //}

        //static void ChangeValueOut(out int a)
        //{
        //    a = 10;
        //    Console.WriteLine($"ref method - a={a}");
        //}

        //static void ChangeIndex(int[] ferid)
        //{
        //    ferid[0] = 222;
        //    Console.WriteLine($"method - ferid[0]={ferid[0]}");
        //}

        //static void ChangeValue(int a)
        //{
        //    a = 10;
        //    Console.WriteLine($"method - a={a}");
        //}
        #endregion
    }
}
