using System;

class Program
{
    static void Main()
    {
        Auto auto = new Auto();

        auto.KiirSebesseg();
        auto.Gyorsit(30);
        auto.Gyorsit(20);
        auto.Lassit(15);
        auto.Lassit(50);
        auto.KiirSebesseg();
    }
}

