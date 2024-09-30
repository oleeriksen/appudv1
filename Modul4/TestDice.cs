namespace Modul4;

public class TestDice
{
    public void Run()
    {
        var e = new int[6];

        Dice d = new MafiaDice();

        for (var i = 0; i < 100000; i++)
        {
            d.Roll();
            var eyes = d.GetEyes();
            e[eyes - 1]++;
            //Console.WriteLine(eyes);
        }

        foreach (var v in e)
            Console.WriteLine(v);
    }
}