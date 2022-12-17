
int cycleCounter = 0;
int x = 1;
bool found = false;
int sum = 0;
bool been = false;

foreach (string readline in System.IO.File.ReadLines("C:/users/simsi/adventOfCode10.txt"))
{
    while (!found)
    {
        if (readline.Substring(0, 4) == "noop")
        {
            found = true;
            cycleCounter++;
        }
        if (readline.Substring(0, 3) == "add")
        {
            int secondHalf = int.Parse(readline.Split(' ')[1]);
            if(been)
            {
                found = true;
                been = false;
                x = x + secondHalf;
            }
            else
            {
                been = true;
            }
            cycleCounter++;
        }


        if (cycleCounter == 20 || cycleCounter == 60 || cycleCounter == 100 || cycleCounter == 140 || cycleCounter == 180 || cycleCounter == 220)
        {
            sum = sum + x * cycleCounter;
        }
    }
    found = false;
}

Console.WriteLine(sum);