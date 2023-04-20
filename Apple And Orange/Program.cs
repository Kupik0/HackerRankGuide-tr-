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
     * Complete the 'countApplesAndOranges' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER s
     *  2. INTEGER t
     *  3. INTEGER a
     *  4. INTEGER b
     *  5. INTEGER_ARRAY apples
     *  6. INTEGER_ARRAY oranges
     */

    public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        List<int> d_apple = new List<int>(); //düşen elmaların kordinatları
        List<int> d_orange = new List<int>(); //düşen portakaların kordinatları
        int evdekielma = 0; //eve denk gelen elma sayısı
        int evdekiportakal = 0; //eve denk gelen portakal sayısı

        foreach (var o in apples) 
        {
            int x = 0;
            x = o + a; 
            d_apple.Add(x); //düşen elmaların ağaçlarına olan uzaklıklarından kordinatlarını bulup kordinat listesine atıyoruz
        }
        foreach (var i in oranges)
        {
            int y = 0;
            y = i + b;
            d_orange.Add(y); //düşen portakalların ağaçlarına olan uzaklıklarından kordinatlarını bulup kordinat listesine atıyoruz
        }

        foreach (var i in d_apple)
        {
            if(i<=t && i >= s)
            {
                evdekielma++; //kordinatları evin sınırlarına denk gelen portakalları sayıyoruz
            }
        }
        foreach (var i in d_orange)
        {
            if (i <= t && i >= s)
            {
                evdekiportakal++; //kordinatları evin sınırlarına denk gelen portakalları sayıyoruz
            }
        }
     Console.WriteLine(evdekielma); Console.WriteLine(evdekiportakal);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int s = Convert.ToInt32(firstMultipleInput[0]);

        int t = Convert.ToInt32(firstMultipleInput[1]);

        string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int a = Convert.ToInt32(secondMultipleInput[0]);

        int b = Convert.ToInt32(secondMultipleInput[1]);

        string[] thirdMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int m = Convert.ToInt32(thirdMultipleInput[0]);

        int n = Convert.ToInt32(thirdMultipleInput[1]);

        List<int> apples = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();

        List<int> oranges = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

        Result.countApplesAndOranges(s, t, a, b, apples, oranges);
    }
}

