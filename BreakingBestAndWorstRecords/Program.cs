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
     * Complete the 'breakingRecords' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY scores as parameter.
     */

    public static List<int> breakingRecords(List<int> scores)
    {
        List<int> result = new List<int>();
        result.Add(0);
        result.Add(0); // 2 elemanlı rekorları saydığımız liste


        int minval = 0; // en çok sayı rekoru sayısı
        int maxval = 0; // en az sayı rekoru sayısı

        for (int i = 0; i < scores.Count; i++)
        {
            if (i == 0) // ilk maçtaki skorları referans noktası olarak belirliyoruz
            {
                minval = scores[i];
                maxval = scores[i];


            }


            else if (scores[i] < minval) { // eğer en çok sayı rekorundan fazlaysa yeni en fazla sayı rekorunu score[i] yapıyoruz
                minval = scores[i];
                result[1] += 1;
            }
            else if (scores[i] > maxval) // aynısını en az sayı için yapıyoruz
            {
                maxval = scores[i];
                result[0] += 1;
            }


        }


        return result; // listeyi dönüyoruz
    }

}

class Solution
{
    public static void Main(string[] args)
    {
      

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

        List<int> result = Result.breakingRecords(scores);

        Console.WriteLine(String.Join(" ", result));

        
    }
}
