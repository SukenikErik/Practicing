using System;

public class Auto
{
    private int sebesseg;

    public Auto()
    {
        sebesseg = 0;
    }

    public void Gyorsit(int ertek)
    {
        sebesseg += ertek;
        Console.WriteLine($"Gyorsítás: +{ertek} km/h -> Sebesség: {sebesseg} km/h");
    }

    public void Lassit(int ertek)
    {
        sebesseg -= ertek;
        if (sebesseg < 0)
        {
            sebesseg = 0;
        }
        Console.WriteLine($"Lassítás: -{ertek} km/h -> Sebesség: {sebesseg} km/h");
    }

    public void KiirSebesseg()
    {
        Console.WriteLine($"Aktuális sebesség: {sebesseg} km/h");
    }
}
