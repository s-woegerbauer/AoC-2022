int lenght = 0;
int counter = 0;
int counter2 = 0;
int sum = 0;
int counterAlphabet = 0;
int i = 0;
int counter3 = 0;

foreach (string readline in System.IO.File.ReadLines(@"C:\Users\simsi\adventOfCode3.txt"))
{
    char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

    lenght = readline.Length;

    char[] firstHalf = new char[lenght / 2];

    for (i = 0; i < lenght / 2; i++)
    {
        firstHalf[i] = readline[i];
        counter = i;
    }

    char[] secondHalf = new char[lenght / 2];

    for (counter2 = 0; counter2 < lenght / 2; counter2++, counter++)
    {
        secondHalf[counter2] = readline[counter + 1];
    }

    counter = 0;
    counter2 = 0;
    counter3 = 0;

    char[] charFound = new char[15];

    while (counter2 < lenght / 2)
    {
        while (counter < lenght / 2)
        {
            if (firstHalf[counter] == secondHalf[counter2])
            {
                while (counterAlphabet < 52)
                {
                    if (firstHalf[counter] == letters[counterAlphabet])
                    {
                        if(Array.Exists(charFound, element => element == firstHalf[counter])){}
                        else
                        {
                            charFound[counter3] = firstHalf[counter];
                            sum = sum + counterAlphabet + 1;
                            counter3++;
                        }
                    }
                    counterAlphabet++;
                }
            }
            counter++;
            counterAlphabet = 0;
            
        }
        counter2++;
        counter = 0;
        counterAlphabet = 0;
        
    }
    counter = 0;
    counter2 = 0;
    counterAlphabet = 0;
    i = 0;

    Console.WriteLine(sum);
}
