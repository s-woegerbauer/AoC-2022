
Queue<int> monkeyZero = new Queue<int>();
monkeyZero.Enqueue(65);
monkeyZero.Enqueue(58);
monkeyZero.Enqueue(93);
monkeyZero.Enqueue(57);
monkeyZero.Enqueue(66);

Queue<int> monkeyOne = new Queue<int>();
monkeyOne.Enqueue(76);
monkeyOne.Enqueue(97);
monkeyOne.Enqueue(58);
monkeyOne.Enqueue(72);
monkeyOne.Enqueue(57);
monkeyOne.Enqueue(92);
monkeyOne.Enqueue(82);

Queue<int> monkeyTwo = new Queue<int>();
monkeyTwo.Enqueue(90);
monkeyTwo.Enqueue(89);
monkeyTwo.Enqueue(96);

Queue<int> monkeyThree = new Queue<int>();
monkeyThree.Enqueue(72);
monkeyThree.Enqueue(63);
monkeyThree.Enqueue(72);
monkeyThree.Enqueue(99);

Queue<int> monkeyFour = new Queue<int>();
monkeyFour.Enqueue(65);

Queue<int> monkeyFive = new Queue<int>();
monkeyFive.Enqueue(97);
monkeyFive.Enqueue(71);

Queue<int> monkeySix = new Queue<int>();
monkeySix.Enqueue(83);
monkeySix.Enqueue(68);
monkeySix.Enqueue(88);
monkeySix.Enqueue(55);
monkeySix.Enqueue(87);
monkeySix.Enqueue(67);

Queue<int> monkeySeven = new Queue<int>();
monkeySeven.Enqueue(64);
monkeySeven.Enqueue(81);
monkeySeven.Enqueue(50);
monkeySeven.Enqueue(96);
monkeySeven.Enqueue(82);
monkeySeven.Enqueue(53);
monkeySeven.Enqueue(62);
monkeySeven.Enqueue(92);

int temp = 0;
int CounterZero = 0;
int CounterOne = 0;
int CounterTwo = 0;
int CounterThree = 0;
int CounterFour = 0;
int CounterFive = 0;
int CounterSix = 0;
int CounterSeven = 0;

for(int i = 0; i < 20; i++)
{
    while(monkeyZero.Count > 0)
    {
        temp = monkeyZero.Dequeue();
        temp = temp * 7;
        temp = (int)Math.Floor(temp / 3.0);
        if(temp % 19 == 0)
        {
            monkeySix.Enqueue(temp);
        }
        else
        {
            monkeyFour.Enqueue(temp);
        }
        CounterZero++;
    }

    while(monkeyOne.Count > 0)
    {
        temp = monkeyOne.Dequeue();
        temp = temp + 4;
        temp = (int)Math.Floor(temp / 3.0);
        if(temp % 3 == 0)
        {
            monkeySeven.Enqueue(temp);
        }
        else
        {
            monkeyFive.Enqueue(temp);
        }
        CounterOne++;
    }

    while(monkeyTwo.Count > 0)
    {
        temp = monkeyTwo.Dequeue();
        temp = temp * 5;
        temp = (int)Math.Floor(temp / 3.0);
        if(temp % 13 == 0)
        {
            monkeyFive.Enqueue(temp);
        }
        else
        {
            monkeyOne.Enqueue(temp);
        }
        CounterTwo++;
    }

    while(monkeyThree.Count > 0)
    {
        temp = monkeyThree.Dequeue();
        temp = temp * temp;
        temp = (int)Math.Floor(temp / 3.0);
        if(temp % 17 == 0)
        {
            monkeyZero.Enqueue(temp);
        }
        else
        {
            monkeyFour.Enqueue(temp);
        }
        CounterThree++;
    }

    while(monkeyFour.Count > 0)
    {
        temp = monkeyFour.Dequeue();
        temp = temp + 1;
        temp = (int)Math.Floor(temp / 3.0);
        if(temp % 2 == 0)
        {
            monkeySix.Enqueue(temp);
        }
        else
        {
            monkeyTwo.Enqueue(temp);
        }
        CounterFour++;
    }

    while(monkeyFive.Count > 0)
    {
        temp = monkeyFive.Dequeue();
        temp = temp + 8;
        temp = (int)Math.Floor(temp / 3.0);
        if(temp % 11 == 0)
        {
            monkeySeven.Enqueue(temp);
        }
        else
        {
            monkeyThree.Enqueue(temp);
        }
        CounterFive++;
    }

    while(monkeySix.Count > 0)
    {
        temp = monkeySix.Dequeue();
        temp = temp + 2;
        temp = (int)Math.Floor(temp / 3.0);
        if(temp % 5 == 0)
        {
            monkeyTwo.Enqueue(temp);
        }
        else
        {
            monkeyOne.Enqueue(temp);
        }
        CounterSix++;
    }

    while(monkeySeven.Count > 0)
    {
        temp = monkeySeven.Dequeue();
        temp = temp + 5;
        temp = (int)Math.Floor(temp / 3.0);
        if(temp % 7 == 0)
        {
            monkeyThree.Enqueue(temp);
        }
        else
        {
            monkeyZero.Enqueue(temp);
        }
        CounterSeven++;
    }
}

int[] counters = { CounterZero, CounterOne, CounterTwo, CounterFour, CounterFive, CounterSix, CounterSeven};

int largest = int.MinValue;
int second = int.MinValue;

foreach (int i in counters)
{
 if (i > largest)
 {
  second = largest;
  largest = i;
 }
else if (i > second)
    second = i;
}

Console.WriteLine(second * largest);