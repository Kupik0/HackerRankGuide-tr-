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
     * Complete the 'birthday' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY s
     *  2. INTEGER d
     *  3. INTEGER m
     */

    public static int birthday(List<int> s, int d, int m)
    {
        int result = 0;

        for(int i  = 0; i < s.Count; i++) // listeyi geziyoruz
        {
            int isum = s[i]; // isum çikolatalardaki değerlerin toplamı
            for(int j = 1; j < m; j++ ) // i'nci çikolatanın doğum ayı değerine gidene kadarki bitişiklerini geziyoruz
            {
               if( i < s.Count-j) // eğer en sağdaki çikolataya gelirsek duruyoruz
                    isum += s[i + j]; // toplam değerimize i'nci çikolatanın j yanındaki çikolatayı ekliyoruz
            }
            if (isum == d)
                result += 1; // eğer toplam doğum gününe eşitse result'ı arttırıyoruz
        }
        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
     

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int d = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        int result = Result.birthday(s, d, m);

        Console.WriteLine(result);

    }
}
