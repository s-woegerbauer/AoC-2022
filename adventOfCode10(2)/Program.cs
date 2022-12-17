

int cycleCounter = 0;
int x = 1;
bool found = false;
int sum = 0;
bool been = false;
int minus = 0;
Console.Write("#");

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

        if(cycleCounter % 40 == 0)
        {
            Console.WriteLine();
            minus += 40;
        }

        if(cycleCounter - minus == x || cycleCounter - minus == x - 1 || cycleCounter - minus == x + 1)
        {
            Console.Write("#");
        }
        else
        {
            Console.Write(" ");
        }
    }
    found = false;
}