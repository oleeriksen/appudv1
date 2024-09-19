// See https://aka.ms/new-console-template for more information

using Modul5;

Person p = new Person { Name = "Peter",
                        Address = "byvej 12",
                        BirthDay = new DateOnly(1998, 10, 5)
};
Person q = new Person { Name = "Egon"};
Console.WriteLine("Modul5");
Console.WriteLine($"{p.Name.ToUpper()}, {p.Address}, {p.BirthDay}");
Console.WriteLine(Person.PersonCount);