using Modul4;
namespace Modul5;

public class DiceCup
{
    private Dice d1 = new Dice();
    private Dice d2 = new Dice();
    
    public void Shake()
    {
        d1.Roll();
        d2.Roll();
    }

    public int[] GetEyes()
    {
        int[] result =
        {
            d1.GetEyes(), d2.GetEyes()
        };
        Array.Sort(result);
        return result;
    }
}