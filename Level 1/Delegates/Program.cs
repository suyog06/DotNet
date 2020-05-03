using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Employee> employeeList = new List<Employee>();
        employeeList.Add(new Employee() { ID = 101, Name = "Suyog", salary = 50000, Experience = 5 });
        Employee.PromoteEmployee(employeeList);
    }
}

class Employee
{

    public int ID { get; set; }
    public string Name { get; set; }
    public float salary  { get; set; }
    public int Experience  { get; set; }

    public static void PromoteEmployee(List<Employee> employeeList )
    {
        foreach (Employee employee in employeeList)
        {
            if(employee.Experience >= 5)
            {
                Console.WriteLine(employee.Name + " " + "promoted");
                    
            }
        }
    }
    
}

