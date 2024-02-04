using migration_database;

internal class Program
{
    private static void Main(string[] args)
    {
        var _context = new BillContext();
        Console.Write("Skriv ditt namn" + ":");
        string name = Console.ReadLine();
        Console.Write("Skriv ditt andra namn" + ":");
        string lastName= Console.ReadLine();
        Console.Write("Skriv din mail" + ":");
        string email = Console.ReadLine();
        Console.Write("Skriv ditt telefon nummer" + ":");
        string phones = Console.ReadLine();
        Console.Write("vilken stad bor du " + ":");
        string city= Console.ReadLine();
        Console.Write("Skriv region" + ":");
        string stad= Console.ReadLine();
        Console.Write("Skriv zipcode" + ":");
        string zipcode = Console.ReadLine();
        Console.Write("Skriv land" + ":");
        string land= Console.ReadLine();
        var customer = new Customer {
            firstName = name,
            lastName= lastName,
            email= email,
            phone= phones,
            city= city,
            state= stad,
            zipcode= zipcode,
            country= land
        };
        _context.Customers.Add(customer);
        _context.SaveChanges();// för att spara alla info i tabellen. 
    }
}