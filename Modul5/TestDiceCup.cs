namespace Modul5;

public class TestDiceCup
{
    public static void Run()
    {
        DiceCup dc = new DiceCup();
        for (int i = 0; i < 20; i++)
        {
            dc.Shake();
            int[] eyes = dc.GetEyes();
            Console.WriteLine($"{eyes[0]},{eyes[1]}");
        }
    }
}