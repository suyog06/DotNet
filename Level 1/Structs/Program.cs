using System;

public struct Student
{
    private string _Name;
    private int _ID;
    //private int _passmarks = 35;

    public string Email
    {
        set;
        get;
    }

    public int Id
    {
        set
        {
            if (value <= 0)
            {
                throw new Exception("ID cannot be a negative number");
            }
            this._ID = value;
        }
        get
        {
            return this._ID;
        }
    }
}
class Program
{
    static void Main()
    {
        Student S1 = new Student();
        S1.Id = 101;
        S1.Email = "loremipsum@loremipsum.com";
        Console.WriteLine("Student Id = {0} and Student Email = {1}", S1.Id, S1.Email);
    }
}

