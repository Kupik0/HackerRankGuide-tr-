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
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel.Design;

class Result
{

    /*
     * Complete the 'getTotalX' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static int getTotalX(List<int> a, List<int> b)
   
    {
        int result = 0;
        foreach (int i in Enumerable.Range(a.Max(), b.Min()  )) { // İlk dizinin en büyük değeri ve ikinci dizinin en küçük değeri arasını inceliyoruz
            bool isMultipleandFactor = true; //  i değeri için dizilerdeki değerlerin hem katı hem böleni olup olmadığına bakıyoruz
            foreach (int i2 in a)  
            {
                if (i % i2 != 0)
                {
                    isMultipleandFactor = false;
                    break;
       
                }
                
                else
                {
                    isMultipleandFactor = true;

                }
 
                
               

            }
            if (isMultipleandFactor)
            {
                foreach (int i3 in b)
                {
                    if (i3 % i != 0)
                    {
                        isMultipleandFactor = false; break;
                    }
                    else
                    {
                        isMultipleandFactor = true;

                    }

                }
                if (isMultipleandFactor) // günün sonunda eğer true kaldıysa result 1 artıyor bu sayede sayabiliyoruz
                    result += 1;

            }
        
        }
        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {


        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();


        int total = Result.getTotalX(arr, brr);

        Console.WriteLine(total);


    }

}
