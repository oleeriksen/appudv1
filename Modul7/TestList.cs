namespace Modul7;

public class TestList
{
    public static void Run()
    {
        LogList numbers = new();
        while (true)
        {
            int aNumber = ReadInt("Indtast tal: ");
            if (aNumber == -1)
                break;
            numbers.Add(aNumber);
         
            Console.WriteLine($"Listen nu: {AsString(numbers)}");
        }

    }

    private static int ReadInt(string question)
    {
        Console.Write(question);
        return Convert.ToInt32(Console.ReadLine());
    }
    
    private static string AsString(List<int> a)
    {
        return $"[{string.Join(", ", a)}]";
    }
}