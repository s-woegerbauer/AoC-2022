int sum = 0;

foreach (string readline in System.IO.File.ReadLines(@"C:\Users\simsi\adventOfCode4.txt"))
{
    string first = "";
    string second = "";
    string third = "";
    string fourth = "";

    int counter = 0;
    int smallestNumber = 0;
    
    int lenght = readline.Length;

    for(int i = 0; i < lenght; i++)
    {
        if(readline[i] != '-' && readline[i] != ',')
        {
            if(counter == 0)
            {
                first = first + readline[i];
            }
            else if(counter == 1)
            {
                second = second + readline[i];
            }
            else if(counter == 2)
            {
                third = third + readline[i];
            }
            else
            {
                fourth = fourth + readline[i];
            }
        }
        else
        {
            counter++;
        }
    }

    int firstInt = Int32.Parse(first);
    int secondInt = Int32.Parse(second);
    int thirdInt = Int32.Parse(third);
    int fourthInt = Int32.Parse(fourth);

    smallestNumber = Math.Min(secondInt,fourthInt);

    if(firstInt >= thirdInt && firstInt <= fourthInt)
    {
        sum++;
    }
    else
    {
        if(secondInt >= thirdInt && firstInt <= fourthInt)
        {
            sum++;
        }
    }
    Console.WriteLine(sum);
}