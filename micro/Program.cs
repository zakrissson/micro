using System;

int coins = 100;
string answer;
string answer1;

if (coins >= 99)
{
    System.Console.WriteLine("wot buy?");
    System.Console.WriteLine("________");
    System.Console.WriteLine("1: its about drive");
    System.Console.WriteLine("2: its about power");
    System.Console.WriteLine("3: we stay hungry");
    System.Console.WriteLine("4: we devour");
    answer=Console.ReadLine();

    if (answer == "1")
    {
        System.Console.WriteLine("item worth: 50 coins");
        System.Console.WriteLine("you still want it?");
        answer1=Console.ReadLine();
        

        if (answer1 == "yes")
        {
            coins -= 50;
            System.Console.WriteLine($"remaining coins: {coins}");
            Console.ReadLine();
            
        }
    }

}


