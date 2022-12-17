using System.IO;

int intReadLine = 0;
int highestSum = 0;
int secondHighestSum = 0;
int thirdHighestSum = 0;
int sum = 0;
int highestSumPrevious = 0;
int secondHighestSumPrevious = 0;

foreach (string readline in System.IO.File.ReadLines(@"C:\Users\simsi\Coding\adventOfCode1\Zahlen.txt"))
{
    if (readline != "")
    {
        intReadLine = int.Parse(readline);
        sum += intReadLine;
    }
    else
    {
        highestSumPrevious = highestSum;
        highestSum = Math.Max(highestSum, sum);
        if(highestSum == sum)
        {
            thirdHighestSum = secondHighestSum;
            secondHighestSum = highestSumPrevious;
        }
        if(highestSum != sum)
        {
            secondHighestSumPrevious = secondHighestSum;
            secondHighestSum = Math.Max(secondHighestSum, sum);
            if(secondHighestSum != sum)
            {
                thirdHighestSum = Math.Max(thirdHighestSum, sum);
            }
            if(secondHighestSum == sum)
            {
                thirdHighestSum = secondHighestSumPrevious;
            }
        }
        sum = 0;
        Console.WriteLine(highestSum);
        Console.WriteLine(secondHighestSum);
        Console.WriteLine(thirdHighestSum);
        Console.WriteLine(highestSum + secondHighestSum + thirdHighestSum);
        Console.WriteLine();
    }

}