using System;

class Display
{
    static void Main()
    {
        string sayHello = "Jay Ganesh";
        Console.WriteLine(sayHello);

        sayHello = sayHello.Replace("Jay", "Hello");
        Console.WriteLine(sayHello);
        
    }
}