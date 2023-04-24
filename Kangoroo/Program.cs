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
     * Complete the 'kangaroo' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. INTEGER x1
     *  2. INTEGER v1
     *  3. INTEGER x2
     *  4. INTEGER v2
     */

    public static string kangaroo(int x1, int v1, int x2, int v2)
    {

        string answer = string.Empty;
      if (v1<=v2) {
            return answer = "NO"; //x2 her türlü x1den büyük olduğu için v2 v1 den eşitse veya büyükse fark asla kapanmaz
        }
      else if (v1>v2 && (x2-x1) % (v1-v2) != 0) 
        {

            return answer = "NO"; // x1in x2den hızlı ilerlediği durumlarda  başlangıç konumları arasındaki fark zıplama mesafeleri arasındaki farka tam bölünmeli ki bir noktada 0a insin
        }
      else { return answer = "YES"; }

    }

}

class Solution
{
    public static void Main(string[] args)
    {

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int x1 = Convert.ToInt32(firstMultipleInput[0]);

        int v1 = Convert.ToInt32(firstMultipleInput[1]);

        int x2 = Convert.ToInt32(firstMultipleInput[2]);

        int v2 = Convert.ToInt32(firstMultipleInput[3]);

        string result = Result.kangaroo(x1, v1, x2, v2);

        Console.WriteLine(result);

    }
}
