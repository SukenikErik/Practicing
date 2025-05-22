using System;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length > 0)
        {
            Console.WriteLine($"Helló, {args[0]}!");
        }
        else
        {
            Console.WriteLine("Helló világ!");
        }
        Program p = new Program();
        p.ShowText("Kecske");
        Display d = new Display();
        d.ShowX();
    }

    private void ShowText(string massege)
    { 
        Console.WriteLine(massege);
    }
}

