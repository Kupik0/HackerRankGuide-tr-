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
     * Complete the 'birthdayCakeCandles' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY candles as parameter.
     */

    public static int birthdayCakeCandles(List<int> candles)
    {

        int max = Int16.MinValue;
        int candleCount = 0;
        for(int i = 0; i < candles.Count; i++)
        {
            if (candles[i] > max) //max değerden büyükse max değerin yerine geçiyor
                max = candles[i];

        }
        for (int a = 0; a < candles.Count; a++)
        {
            if (candles[a] == max) // aynı max değerden kaç tane var buluyoruz
               candleCount++;

        }
        return(candleCount);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
     

        int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

        int result = Result.birthdayCakeCandles(candles);

        Console.WriteLine(result);

    }
}
