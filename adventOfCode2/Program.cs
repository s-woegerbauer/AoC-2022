int score = 0;

foreach (string readline in System.IO.File.ReadLines(@"C:\Users\simsi\Coding\adventOfCode2\RockPaperScissors.txt"))
{
    if (readline == "A X")
    {
        score += 3;
    }
    else if (readline == "A Y")
    {
        score += 4;
    }
    else if (readline == "A Z")
    {
        score += 8;
    }
    else if (readline == "B X")
    {
        score += 1;
    }
    else if (readline == "B Y")
    {
        score += 5;
    }
    else if (readline == "B Z")
    {
        score += 9;
    }
    else if (readline == "C X")
    {
        score += 2;
    }
    else if (readline == "C Y")
    {
        score += 6;
    }
    else if (readline == "C Z")
    {
        score += 7;
    }

    Console.WriteLine(score);
    Console.WriteLine();
}