

Dictionary<int, string> coordinatesBeen = new Dictionary<int, string>();

coordinatesBeen.Add(1, "1 1");

string state = "samePlace";
int[] currentCoordinatesTail = { 1, 1 };
int[] currentCoordinatesHead = { 1, 1 };
int dictCounter = 2;
int readNumber = 0;
bool isIn = false;
string xy = "";
const string LEFT = "left";
const string RIGHT = "right";
const string TOP = "top";
const string BOTTOM = "bottom";
const string RIGHTTOP = "rightTop";
const string LEFTTOP = "leftTop";
const string RIGHTBOTTOM = "rightBottom";
const string LEFTBOTTOM = "leftBottom";
const string SAMEPLACE = "samePlace";

foreach (string readline in System.IO.File.ReadAllLines("C:/users/simsi/adventOfCode9.txt"))
{
    readNumber = int.Parse(readline.Substring(2, readline.Length - 2));

    if (readline[0] == 'R')
    {
        for (int i = 0; i < readNumber; i++)
        {
            currentCoordinatesHead[0] = currentCoordinatesHead[0] + 1;

            if(state == LEFT)
            {
                currentCoordinatesTail[0] = currentCoordinatesTail[0] + 1;
            }
            else if(state == LEFTBOTTOM)
            {
                currentCoordinatesTail[0] = currentCoordinatesTail[0] + 1;
                currentCoordinatesTail[1] = currentCoordinatesTail[1] + 1;
                state = LEFT;
            }
            else if(state == LEFTTOP)
            {
                currentCoordinatesTail[0] = currentCoordinatesTail[0] + 1;
                currentCoordinatesTail[1] = currentCoordinatesTail[1] - 1;
                state = LEFT;
            }
            else if(state == BOTTOM)
            {
                state = LEFTBOTTOM;
            }
            else if(state == RIGHTBOTTOM)
            {
                state = BOTTOM;
            }
            else if(state == RIGHT)
            {
                state = SAMEPLACE;
            }
            else if(state == RIGHTTOP)
            {
                state = TOP;
            }
            else if(state == TOP)
            {
                state = LEFTTOP;
            }
            else if(state == SAMEPLACE)
            {
                state = LEFT;
            }
            
            xy = currentCoordinatesTail[0] + " " + currentCoordinatesTail[1];
            if(coordinatesBeen.ContainsValue(xy))
            {
                isIn = true;
            }

            if(!isIn)
            {
                coordinatesBeen.Add(dictCounter, currentCoordinatesTail[0] + " " + currentCoordinatesTail[1]);
                dictCounter++;
            }

            isIn = false;
        }
    }
    else if (readline[0] == 'U')
    {
        for (int i = 0; i < readNumber; i++)
        {
            currentCoordinatesHead[1] = currentCoordinatesHead[1] + 1;

            if(state == LEFT)
            {
                state = LEFTBOTTOM;
            }
            else if(state == LEFTBOTTOM)
            {
                currentCoordinatesTail[0] = currentCoordinatesTail[0] + 1;
                currentCoordinatesTail[1] = currentCoordinatesTail[1] + 1;
                state = BOTTOM;
            }
            else if(state == RIGHTBOTTOM)
            {
                currentCoordinatesTail[0] = currentCoordinatesTail[0] - 1;
                currentCoordinatesTail[1] = currentCoordinatesTail[1] + 1;
                state = BOTTOM;
            }
            else if(state == BOTTOM)
            {
                currentCoordinatesTail[1] = currentCoordinatesTail[1] + 1;
            }
            else if(state == LEFTTOP)
            {
                state = LEFT;
            }
            else if(state == RIGHT)
            {
                state = RIGHTBOTTOM;
            }
            else if(state == RIGHTTOP)
            {
                state = RIGHT;
            }
            else if(state == TOP)
            {
                state = SAMEPLACE;
            }
            else if(state == SAMEPLACE)
            {
                state = BOTTOM;
            }

            xy = currentCoordinatesTail[0] + " " + currentCoordinatesTail[1];
            if(coordinatesBeen.ContainsValue(xy))
            {
                isIn = true;
            }

            if(!isIn)
            {
                coordinatesBeen.Add(dictCounter, currentCoordinatesTail[0] + " " + currentCoordinatesTail[1]);
                dictCounter++;
            }

            isIn = false;
        }
    }
    else if (readline[0] == 'D')
    {
        for (int i = 0; i < readNumber; i++)
        {
            currentCoordinatesHead[1] = currentCoordinatesHead[1] - 1;

            if(state == LEFT)
            {
                state = LEFTTOP;
            }
            else if(state == LEFTTOP)
            {
                currentCoordinatesTail[0] = currentCoordinatesTail[0] + 1;
                currentCoordinatesTail[1] = currentCoordinatesTail[1] - 1;
                state = TOP;
            }
            else if(state == RIGHTTOP)
            {
                currentCoordinatesTail[0] = currentCoordinatesTail[0] - 1;
                currentCoordinatesTail[1] = currentCoordinatesTail[1] - 1;
                state = TOP;
            }
            else if(state == BOTTOM)
            {
                state = SAMEPLACE;
            }
            else if(state == LEFTBOTTOM)
            {
                state = LEFT;
            }
            else if(state == RIGHT)
            {
                state = RIGHTTOP;
            }
            else if(state == RIGHTBOTTOM)
            {
                state = RIGHT;
            }
            else if(state == TOP)
            {
                currentCoordinatesTail[1] = currentCoordinatesTail[1] - 1;
            }
            else if(state == SAMEPLACE)
            {
                state = TOP;
            }

            xy = currentCoordinatesTail[0] + " " + currentCoordinatesTail[1];
            if(coordinatesBeen.ContainsValue(xy))
            {
                isIn = true;
            }

            if(!isIn)
            {
                coordinatesBeen.Add(dictCounter, currentCoordinatesTail[0] + " " + currentCoordinatesTail[1]);
                dictCounter++;
            }

            isIn = false;
        }
    }
    else if (readline[0] == 'L')
    {
        for (int i = 0; i < readNumber; i++)
        {
            currentCoordinatesHead[0] = currentCoordinatesHead[0] - 1;

            if(state == LEFT)
            {
                state = SAMEPLACE;
            }
            else if(state == LEFTBOTTOM)
            {
                state = BOTTOM;
            }
            else if(state == RIGHTBOTTOM)
            {
                currentCoordinatesTail[0] = currentCoordinatesTail[0] - 1;
                currentCoordinatesTail[1] = currentCoordinatesTail[1] + 1;
                state = RIGHT;
            }
            else if(state == BOTTOM)
            {
                state = RIGHTBOTTOM;
            }
            else if(state == LEFTTOP)
            {
                state = TOP;
            }
            else if(state == RIGHT)
            {
                currentCoordinatesTail[0] = currentCoordinatesTail[0] - 1;
            }
            else if(state == RIGHTTOP)
            {
                currentCoordinatesTail[0] = currentCoordinatesTail[0] - 1;
                currentCoordinatesTail[1] = currentCoordinatesTail[1] - 1;
                state = RIGHT;
            }
            else if(state == TOP)
            {
                state = RIGHTTOP;
            }
            else if(state == SAMEPLACE)
            {
                state = RIGHT;
            }

            xy = currentCoordinatesTail[0] + " " + currentCoordinatesTail[1];
            if(coordinatesBeen.ContainsValue(xy))
            {
                isIn = true;
            }

            if(!isIn)
            {
                coordinatesBeen.Add(dictCounter, currentCoordinatesTail[0] + " " + currentCoordinatesTail[1]);
                dictCounter++;
            }

            isIn = false;
        }
    }
}

Console.WriteLine(coordinatesBeen.Count);