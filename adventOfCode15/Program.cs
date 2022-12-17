
bool number = false;
var coordinates = new List<string>();
string temporary = "";
const int CONSTANT = 2000000;

foreach (string readLine in System.IO.File.ReadLines("C:/users/simsi/adventOfCode15.txt"))
{
    for (int i = 0; i < readLine.Length; i++)
    {
        if (readLine[i] == '=')
        {
            number = true;
        }
        else if (readLine[i] == ',' || readLine[i] == ':')
        {
            number = false;
            temporary += ",";
        }
        else if (number == true)
        {
            temporary += readLine[i];
        }
    }
    coordinates.Add(temporary);
    temporary = "";
    number = false;
}

int tempX = 0;
int tempY = 0;
int secondTempX = 0;
int secondTempY = 0;
int distance = 0;
int[] noBeacons = new int[11000000];
int counterDimension = 0;

for (int i = 0; i < coordinates.Count; i++)
{
    tempX = int.Parse(coordinates.ElementAt(i).Split(',')[0]);
    tempY = int.Parse(coordinates.ElementAt(i).Split(',')[1]);
    secondTempX = int.Parse(coordinates.ElementAt(i).Split(',')[2]);
    secondTempY = int.Parse(coordinates.ElementAt(i).Split(',')[3]);

    distance = Math.Abs(secondTempX - tempX) + Math.Abs(secondTempY - tempY);

    if ((tempY < CONSTANT && tempY + distance > CONSTANT) || (tempY > CONSTANT && tempY - distance < CONSTANT) || (tempY == CONSTANT))
    {
        for (int j = 0; j <= distance; j++)
        {
            if (tempY + j == CONSTANT || tempY - j == CONSTANT)
            {
                for (int h = 0; h <= distance - j; h++)
                {
                    if (tempY + j == CONSTANT || tempY - j == CONSTANT)
                    {
                        noBeacons[counterDimension] = (tempX - h);
                        counterDimension++;

                        noBeacons[counterDimension] = (tempX + h);
                        counterDimension++;
                    }
                }
            }
        }
    }
}

int[] counter = noBeacons.Distinct().ToArray();

Console.WriteLine(counter.Length - 1);