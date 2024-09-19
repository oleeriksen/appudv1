namespace Modul5;

public class Person
{
    public static int PersonCount;

    public Person() {
        PersonCount++;
    }

    public string? Name { get; set; }
    public string Address { get; set; }
    public DateOnly BirthDay { get; set; }

}