Stack<char> one = new Stack<char>();
one.Push('F');
one.Push('D');
one.Push('B');
one.Push('Z');
one.Push('T');
one.Push('J');
one.Push('R');
one.Push('N');

Stack<char> two = new Stack<char>();
two.Push('R');
two.Push('S');
two.Push('N');
two.Push('J');
two.Push('H');

Stack<char> three = new Stack<char>();
three.Push('C');
three.Push('R');
three.Push('N');
three.Push('J');
three.Push('G');
three.Push('Z');
three.Push('F');
three.Push('Q');

Stack<char> four = new Stack<char>();
four.Push('F');
four.Push('V');
four.Push('N');
four.Push('G');
four.Push('R');
four.Push('T');
four.Push('Q');

Stack<char> five = new Stack<char>();
five.Push('L');
five.Push('T');
five.Push('Q');
five.Push('F');

Stack<char> six = new Stack<char>();
six.Push('Q');
six.Push('C');
six.Push('W');
six.Push('Z');
six.Push('B');
six.Push('R');
six.Push('G');
six.Push('N');

Stack<char> seven = new Stack<char>();
seven.Push('F');
seven.Push('C');
seven.Push('L');
seven.Push('S');
seven.Push('N');
seven.Push('H');
seven.Push('M');

Stack<char> eight = new Stack<char>();
eight.Push('D');
eight.Push('N');
eight.Push('Q');
eight.Push('M');
eight.Push('T');
eight.Push('J');

Stack<char> nine = new Stack<char>();
nine.Push('P');
nine.Push('G');
nine.Push('S');

int i = 0;

foreach (string readline in System.IO.File.ReadLines(@"C:\Users\simsi\adventOfCode5.txt"))
{
    int lenght = readline.Length;

    char[] get = new char[1];
    char[] to = new char[1];
    char[] quantity = new char[5];

    string temp = "";

    int counter = 0;

    for (i = 0; i < lenght; i++)
    {
        if (temp == "move ")
        {
            if (readline[i] != ' ')
            {
                quantity[counter] = readline[i];
                counter++;
            }
            else
            {
                temp = "";
            }
        }
        else if (temp == "from ")
        {
            get[0] = readline[i];
            temp = "";
        }
        else if (temp == " to ")
        {
            to[0] = readline[i];
            temp = "";
        }
        else
        {
            temp = $"{temp}{readline[i]}";
        }
    }

    int quantityInt = Int32.Parse(quantity);
    int getInt = Int32.Parse(get);
    int toInt = Int32.Parse(to);

    Stack<char> tempStack = new Stack<char>();


    if (getInt == 1)
    {
        for (i = 0; i < quantityInt; i++)
        {
            if (one.Count > 0)
            {
                tempStack.Push(one.Pop());
            }
        }
    }
    else if (getInt == 2)
    {
        for (i = 0; i < quantityInt; i++)
        {
            if (two.Count > 0)
            {
                tempStack.Push(two.Pop());
            }
        }
    }
    else if (getInt == 3)
    {
        for (i = 0; i < quantityInt; i++)
        {
            if (three.Count > 0)
            {
                tempStack.Push(three.Pop());
            }
        }
    }
    else if (getInt == 4)
    {
        for (i = 0; i < quantityInt; i++)
        {
            if (four.Count > 0)
            {
                tempStack.Push(four.Pop());
            }
        }
    }
    else if (getInt == 5)
    {
        for (i = 0; i < quantityInt; i++)
        {
            if (five.Count > 0)
            {
                tempStack.Push(five.Pop());
            }
        }
    }
    else if (getInt == 6)
    {
        for (i = 0; i < quantityInt; i++)
        {
            if (six.Count > 0)
            {
                tempStack.Push(six.Pop());
            }
        }
    }
    else if (getInt == 7)
    {
        for (i = 0; i < quantityInt; i++)
        {
            if (seven.Count > 0)
            {
                tempStack.Push(seven.Pop());
            }
        }
    }
    else if (getInt == 8)
    {
        for (i = 0; i < quantityInt; i++)
        {
            if (eight.Count > 0)
            {
                tempStack.Push(eight.Pop());
            }
        }
    }
    else if (getInt == 9)
    {
        for (i = 0; i < quantityInt; i++)
        {
            if (nine.Count > 0)
            {
                tempStack.Push(nine.Pop());
            }
        }
    }

    while (tempStack.Count > 0)
    {
        if (toInt == 1)
        {
            one.Push(tempStack.Pop());
        }
        else if (toInt == 2)
        {
            two.Push(tempStack.Pop());
        }
        else if (toInt == 3)
        {
            three.Push(tempStack.Pop());
        }
        else if (toInt == 4)
        {
            four.Push(tempStack.Pop());
        }
        else if (toInt == 5)
        {
            five.Push(tempStack.Pop());
        }
        else if (toInt == 6)
        {
            six.Push(tempStack.Pop());
        }
        else if (toInt == 7)
        {
            seven.Push(tempStack.Pop());
        }
        else if (toInt == 8)
        {
            eight.Push(tempStack.Pop());
        }
        else if (toInt == 9)
        {
            nine.Push(tempStack.Pop());
        }
    }
    if (one.Count > 0)
        Console.Write(one.Peek());

    if (two.Count > 0)
        Console.Write(two.Peek());

    if (three.Count > 0)
        Console.Write(three.Peek());

    if (four.Count > 0)
        Console.Write(four.Peek());

    if (five.Count > 0)
        Console.Write(five.Peek());

    if (six.Count > 0)
        Console.Write(six.Peek());

    if (seven.Count > 0)
        Console.Write(seven.Peek());

    if (eight.Count > 0)
        Console.Write(eight.Peek());

    if (nine.Count > 0)
        Console.Write(nine.Peek());

    Console.WriteLine();
}
