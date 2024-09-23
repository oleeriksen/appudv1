namespace Modul6;

public class TestList
{
    public static void Run()
    {
        List<int> a = new List<int>();
        Console.WriteLine(AsString(a));
        a.Add(23);
        Console.WriteLine(AsString(a));
        a.RemoveAt(0);
        Console.WriteLine(AsString(a));
        a.Add(34);
        a.Add(23);
        a.Add(76);
        foreach (int aValue in a)
        {
            Console.WriteLine(aValue);
        }

        a.Sort();

        a.RemoveAll(t => t < 0);

        a.Count(g => g == 2);


    }

    private static string AsString(List<int> a)
    {
        return $"[{string.Join(", ", a)}]";
    }
}