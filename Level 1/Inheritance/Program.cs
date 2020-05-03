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

class FullTimeEmp : Employee
{
    public float YearlySalary;
}

class PartTimeEmp : Employee
{
    public float HourlyRate;
}

 class Program
{
    public static void Main()
    {
        FullTimeEmp FTE = new FullTimeEmp();
        FTE.Fname = "Suyog";
        FTE.Lname = "Shelar";
        FTE.YearlySalary = 40000;
        FTE.FullName();


        PartTimeEmp PTE = new PartTimeEmp();
        PTE.Fname = "Suyog";
        PTE.Lname = "Shelar";
        PTE.FullName();
    }
}

