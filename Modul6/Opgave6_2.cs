namespace Modul6;

public class Opgave6_2
{
    public static void Run()
    {
        int STOP = -1;
        Console.WriteLine("Indtast karaktere - afslut med -1:");
        List<int> grades = new();
        while (true)
        {
            int grade = ReadInt($"Indtast karakter: ");
            if (grade == STOP)
                break;
            grades.Add(grade);
        }

        double avg = Average(grades.ToArray());
        Console.WriteLine($"Gennemsnit = {avg}");

        int[] validGrades = { -3, 0, 2, 4, 7, 10, 12 };

        foreach (int aGrade in validGrades)
        {
            int counter = Count(grades.ToArray(), aGrade);
            if (counter > 0)
            {
                Console.WriteLine($"Der er {counter} af {aGrade}");
            }
        }

    }

    private static int ReadInt(string question)
    {
        Console.Write(question);
        return Convert.ToInt32(Console.ReadLine());
    }

    private static int Count(int[] a, int key)
    {
        int c = 0;
        foreach (var tal in a)
            if (tal == key)
                c++;
        return c;
    }
    
    private static double Average(int[] a)
    {
        double sum = 0;
        foreach (int tal in a)
            sum += tal;
        return sum / a.Length;
    }
}