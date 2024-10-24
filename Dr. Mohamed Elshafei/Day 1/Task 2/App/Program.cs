namespace App;
using Dura;
class Program
{
    static void Main(string[] args)
    {
        Duration D1 = new Duration(1, 10, 15);
        Console.WriteLine(D1.getstring());
        Duration D2 = new Duration(3600);
        Console.WriteLine(D2.getstring());
        Duration D3 = new Duration(7800);
        Console.WriteLine(D3.getstring());
        Duration D4 = new Duration(666);
        Console.WriteLine(D4.getstring());
    }
}
