using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        
        long sum = 0;//long alıyoruz çünkü int64 değerler alabilir
        for(int i  = 0; i < arr.Count; i++)
        {
           sum = sum + arr[i];//dizinin toplamını buluyoruz

        }
        Console.WriteLine($"{sum - arr.Max()} {sum - arr.Min()}");//dizideki en küçük değeri bularak en büyük dörtlü alt dizi toplamını, en büyük değeri bularak ise en küçük dörtlü alt dizi toplamını buluyoruz


    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
