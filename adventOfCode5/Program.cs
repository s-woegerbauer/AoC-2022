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

    char temporary = ' ';

    for (int f = 0; f < quantityInt; f++)
    {
        if (getInt == 1)
        {
            if(one.Count > 0)
                temporary = one.Pop();
            else{temporary = ' ';}
        }
        else if (getInt == 2)
        {
            if(two.Count > 0)
                temporary = two.Pop();
            else{temporary = ' ';}
        }
        else if (getInt == 3)
        {
            if(three.Count > 0)
                temporary = three.Pop();
            else{temporary = ' ';}
        }
        else if (getInt == 4)
        {
            if(four.Count > 0)
                temporary = four.Pop();
            else{temporary = ' ';}
        }
        else if (getInt == 5)
        {
            if(five.Count > 0)
                temporary = five.Pop();
            else{temporary = ' ';}
        }
        else if (getInt == 6)
        {
            if(six.Count > 0)
                temporary = six.Pop();
            else{temporary = ' ';}
        }
        else if (getInt == 7)
        {
            if(seven.Count > 0)
                temporary = seven.Pop();
            else{temporary = ' ';}
        }
        else if (getInt == 8)
        {
            if(eight.Count > 0)
                temporary = eight.Pop();
            else{temporary = ' ';}
        }
        else if (getInt == 9)
        {
            if(nine.Count > 0)
                temporary = nine.Pop();
            else{temporary = ' ';}
        }

        if (temporary != ' ')
        {
            if (toInt == 1)
            {
                one.Push(temporary);
            }
            else if (toInt == 2)
            {
                two.Push(temporary);
            }
            else if (toInt == 3)
            {
                three.Push(temporary);
            }
            else if (toInt == 4)
            {
                four.Push(temporary);
            }
            else if (toInt == 5)
            {
                five.Push(temporary);
            }
            else if (toInt == 6)
            {
                six.Push(temporary);
            }
            else if (toInt == 7)
            {
                seven.Push(temporary);
            }
            else if (toInt == 8)
            {
                eight.Push(temporary);
            }
            else if (toInt == 9)
            {
                nine.Push(temporary);
            }
        }
    }
    if(one.Count > 0)
        Console.Write(one.Peek());

    if(two.Count > 0)
        Console.Write(two.Peek());

    if(three.Count > 0)
        Console.Write(three.Peek());

    if(four.Count > 0)
        Console.Write(four.Peek());

    if(five.Count > 0)
        Console.Write(five.Peek());

    if(six.Count > 0)
        Console.Write(six.Peek());

    if(seven.Count > 0)
        Console.Write(seven.Peek());

    if(eight.Count > 0)
        Console.Write(eight.Peek());

    if(nine.Count > 0)
        Console.Write(nine.Peek());
    
    Console.WriteLine();

}
