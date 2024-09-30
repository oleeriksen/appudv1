namespace Modul7;

public class LogList : List<int>
{
    public void Add(int v)
    {
        base.Add(v);
        var s = File.AppendText("addlog.txt");
        s.WriteLine($"kl.{DateTime.Now} er der tilføjet {v}");
        s.Flush();
    }

}