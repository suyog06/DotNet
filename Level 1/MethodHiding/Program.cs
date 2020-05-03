using System;
class Employee
{
    public string Fname;
    public string Lname;

    public void FullName()
    {
        Console.WriteLine(Fname + " " + Lname);
    }
}

class FullTimeEmployee : Employee
{
    public void FullName()
    {
        Console.WriteLine(Fname + " " + Lname + "-Contractor");
    }
}
class PartTimeEmployee : Employee
{

}
public class Program
{
    static void Main()
    {
        FullTimeEmployee FTE = new FullTimeEmployee();
        FTE.Fname = "Suyog";
        FTE.Lname = "Shelar";
        FTE.FullName();

        PartTimeEmployee PTE = new PartTimeEmployee();
        PTE.Fname = "Suyog";
        PTE.Lname = "Shelar";
        PTE.FullName();
    }
}

