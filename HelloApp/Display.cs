using System;

class Display
{
    private int x;
    public Display(int a)
    {
        x = a;
        Console.WriteLine("Konstruktor");
        Console.WriteLine(a);
    }

    public void ShowX()
    {
        System.Console.WriteLine(x);
    }

    public Display()
    {
    }

}