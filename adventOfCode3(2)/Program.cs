int lenght1 = 0;
int counter = 0;
int counter2 = 0;
int sum = 0;
int counterAlphabet = 0;
int i = 0;
int counter3 = 0;
int counter4 = 0;
string[] readlines = new string[3];
int lenght2 = 0;
int lenght3 = 0;
int counter5 = 0;
char[] charFound = new char[15];

foreach (string readline in System.IO.File.ReadLines(@"C:\Users\simsi\adventOfCode3.txt"))
{
    readlines[counter4] = readline;
    counter4++;
    if (counter4 == 3)
    {
        char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        string readline1 = readlines[0];
        string readline2 = readlines[1];
        string readline3 = readlines[2];

        lenght1 = readlines[0].Length;
        lenght2 = readlines[1].Length;
        lenght3 = readlines[2].Length;

        char[] firstHalf = new char[lenght1];

        for (i = 0; i < lenght1; i++)
        {
            firstHalf[i] = readline1[i];
        }

        char[] secondHalf = new char[lenght2];

        for (i = 0; i < lenght2; i++)
        {
            secondHalf[i] = readline2[i];
        }

        char[] thirdHalf = new char[lenght3];

        for (i = 0; i < lenght3; i++)
        {
            thirdHalf[i] = readline3[i];
        }

        counter = 0;
        counter2 = 0;
        counter3 = 0;
        counter4 = 0;
        readlines = new string[3];
        charFound = new char[15];

        while (counter2 < lenght2)
        {
            while (counter < lenght1)
            {
                if (firstHalf[counter] == secondHalf[counter2])
                {
                    while (counterAlphabet < 52)
                    {
                        if (firstHalf[counter] == letters[counterAlphabet])
                        {
                            while (counter5 < lenght3)
                            {
                                if (firstHalf[counter] == thirdHalf[counter5])
                                {
                                    if (Array.Exists(charFound, element => element == firstHalf[counter])) { }
                                    else
                                    {
                                        charFound[counter3] = firstHalf[counter];
                                        sum = sum + counterAlphabet + 1;
                                        counter3++;
                                    }

                                }
                                counter5++;
                            }
                        }
                        counterAlphabet++;
                    }
                    counter5 = 0;
                    counterAlphabet = 0;
                }
                counter++;
                counterAlphabet = 0;
                counter5 = 0;
            }
            counter2++;
            counter = 0;
            counterAlphabet = 0;
            counter5 = 0;
        }
        Console.WriteLine(sum);
    }
    counter = 0;
    counter2 = 0;
}
