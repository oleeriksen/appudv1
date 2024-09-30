namespace Modul4;

public class MafiaDice : Dice
{
    public MafiaDice()
    {
    }

    public override void Roll()
    {
        base.Roll();
        if (GetEyes() != 6)
            base.Roll();
    }

}