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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
    var zaman = DateTime.ParseExact(s, "hh:mm:sstt", CultureInfo.InvariantCulture); //stringi verilen spesifik formattan datetime'a çevirelim

        return $"{zaman:HH:mm:ss}"; //datetimeı stringe geri çevirirken istediğimiz military formatı ayarlayalım

    }

}

class Solution
{
    public static void Main(string[] args)
    {
      

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        Console.WriteLine(result);

        
    }
}

