using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        
        // Circle myCircle = new Circle(10); // the new keyword denotes a new instance
        // Console.WriteLine($"{myCircle.GetArea()}");

        // Circle unitCircle = new Circle(1);
        // Console.WriteLine($"Circumference: {unitCircle.GetCircumference()}");
        // Console.WriteLine($"Diameter: {unitCircle.GetDiameter()}");

    //     Person person1 = new Person("bob", "smith", 34, 210);
    //     Console.WriteLine(person1.PersonInformation());

    //     Fireman fireman = new Fireman("EMT and paramedic", "Billy", "Tarnish", 24, 190);

    //     Console.WriteLine(fireman.PersonInformation());
    //     Console.WriteLine(fireman.FiremanInformation());

        Employee employee = new Employee("Bob", 40, 23.77);
        Console.WriteLine($"Employee: {employee.GetName()}, Is due: {employee.GetPay()}"); 

        ConstructionWorker constructionWorker = new ConstructionWorker("betty", 40, 35.88);
        Console.WriteLine($"Employee: {constructionWorker.GetName()}, Is due: {constructionWorker.GetPay()}");

        Doctor doctor = new Doctor("Belinda", 240000.99);
        Console.WriteLine($"Employee: {doctor.GetName()}, Is due: {doctor.GetPay()}");

        List<Employee> employees = new List<Employee>();
        employees.Add(employee);
        employees.Add(constructionWorker);
        employees.Add(doctor);

        Console.WriteLine("The For-Loop outputs the following:");
        foreach (Employee e in employees)
        {
            Console.WriteLine($"{e.GetName()}, is due: {e.GetPay()}");
        }
    }
}