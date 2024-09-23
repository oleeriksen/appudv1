namespace Modul6;

public class Opgave6_2
{
    public static void Run()
    {
        int STOP = -1;
        int[] validGrades = { -3, 0, 2, 4, 7, 10, 12 };
        Console.WriteLine("Indtast karaktere - afslut med -1:");
        List<int> grades = new();
        while (true)
        {
            int grade = ReadInt($"Indtast karakter: ");
            
            if (grade == STOP)
                break;
            
            if ( ! validGrades.Contains(grade) )
                Console.WriteLine("Indtast kun lovlige karaktere...");
            else
                grades.Add(grade);
        }

        double avg = grades.Average();
        Console.WriteLine($"Gennemsnit = {avg}");

        foreach (int aGrade in validGrades)
        {
            int counter = grades.Count(g => g == aGrade);
            if (counter > 0)
                Console.WriteLine($"Der er {counter} af {aGrade}");
        }
    }

    private static int ReadInt(string question)
    {
        Console.Write(question);
        return Convert.ToInt32(Console.ReadLine());
    }
}