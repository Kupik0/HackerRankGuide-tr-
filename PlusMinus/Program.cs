

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        decimal zerocount = 0;
        decimal positivecount = 0;
        decimal negativecount = 0;
        decimal zeroratio = 0;
        decimal positiveratio = 0;
        decimal negativeratio = 0;

        foreach (var item in arr)
        {
            if (item == 0)
            {
                zerocount = zerocount + 1; // dizideki 0 sayısını buluyoruz
                zeroratio = zerocount / arr.Count; // dizideki 0 sayısını tüm sayılara oranlıyoruz

            }
            else if (item > 0)
            {
                positivecount = positivecount + 1;
                positiveratio = positivecount / arr.Count;

            }
            else
            {
                negativecount = negativecount + 1;
                negativeratio = negativecount / arr.Count;

            }


        }
        Console.WriteLine(positiveratio.ToString("0." + new string('0', arr.Count)));//dizinin eleman sayısı kadar 0 ekliyoruz # değil çünkü 0 değeri de alabilir
        Console.WriteLine(negativeratio.ToString("0." + new string('0', arr.Count)));
        Console.WriteLine(zeroratio.ToString("0." + new string('0', arr.Count)));
        Console.ReadLine();


    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}