using System;

class  Employee
{
    public string Fname = "lorem";
    public string Lname = "Ipsum";
    public virtual void FullName()
    {
        Console.WriteLine(Fname + " " + Lname);
    }
}

class FullTimeEmp : Employee
{
    public override void FullName()
    {
        Console.WriteLine(Fname + " " + Lname + "-Full Time");
    }
}

class PartTimeEmp : Employee
{
    public override void FullName()
    {
        Console.WriteLine(Fname + " " + Lname + "-Part Time");
    }
}

class Temp : Employee
{
    public override void FullName()
    {
        Console.WriteLine(Fname + " " + Lname + "-Temporary");
    }
}
class Program
{
    static void Main()
    {
        Employee[] employees = new Employee[3];
        employees[0] = new PartTimeEmp();
        employees[1] = new FullTimeEmp();
        employees[2] = new Temp();
        foreach (Employee i in employees)
        {
            i.FullName();
            //Console.WriteLine(i);
        }
    }
}

