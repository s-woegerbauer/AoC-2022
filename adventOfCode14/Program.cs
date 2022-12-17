
List<string> readCoordinates = new List<string>();
List<string> coordinatesAlreadyThere = new List<string>();

foreach(string readLine in System.IO.File.ReadLines("C:/users/simsi/adventOfCode14.txt"))
{
    for(int i = 0; i < readLine.Count(f => (f == '-')); i++)
    {
        readCoordinates.Add(readLine.Split(" -> ")[i]);
        readCoordinates.Add(readLine.Split(" -> ")[i + 1]);
    }
}

for(int i = 0; i < readCoordinates.Count; i += 2)
{
    int tempX = int.Parse(readCoordinates[i].Split(',')[0]);
    int tempY = int.Parse(readCoordinates[i].Split(',')[1]);

    int secondTempX = int.Parse(readCoordinates[i + 1].Split(',')[0]);
    int secondTempY = int.Parse(readCoordinates[i + 1].Split(',')[1]);

    if(tempX == secondTempX)
    {
        for(int j = Math.Min(secondTempY, tempY); j <= Math.Max(secondTempY, tempY); j++)
        {
            if(!coordinatesAlreadyThere.Contains($"{tempX},{j}"))
            {
                coordinatesAlreadyThere.Add($"{tempX},{j}");
            }
        }
    }
    else if(tempY == secondTempY)
    {
        for(int j = Math.Min(secondTempX, tempX); j <= Math.Max(secondTempX, tempX); j++)
        {
            if(!coordinatesAlreadyThere.Contains($"{j},{tempY}"))
            {
                coordinatesAlreadyThere.Add($"{j},{tempY}");
            }
        }
    }
}

int sandX = 500;
int sandY = 0;
int sandCounter = 0;

while(sandY < 1000)
{
    if(!coordinatesAlreadyThere.Contains($"{sandX},{sandY + 1}"))
    {
        sandY += 1;
    }
    else if(!coordinatesAlreadyThere.Contains($"{sandX - 1},{sandY + 1}"))
    {
        sandX -= 1;
        sandY += 1;
    }
    else if(!coordinatesAlreadyThere.Contains($"{sandX + 1},{sandY + 1}"))
    {
        sandX += 1;
        sandY += 1;
    }
    else
    {
        coordinatesAlreadyThere.Add($"{sandX},{sandY}");
        sandX = 500;
        sandY = 0;
        sandCounter++;
    }
}

Console.WriteLine(sandCounter);