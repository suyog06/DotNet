using System;

class Student
{
    private string _Name;
    private int _ID;
    private int _passmarks = 35;

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
    public int Getpassmarks()
    {
        return this._passmarks;
    }

    public void SetName(string Name)
    {
        if(Name == _Name)
        {
            throw new Exception("No name specified");
        }
        this._Name = Name;
    }
    public string GetName()
    {
        return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;
        
    }
    

}

class Program
{
    static void Main()
    {
        Student id = new Student();
        // id.SetId(11);
        id.Id = 101;
        id.Email = "loremipsum@loremipsum.com";
        id.SetName("Suyog");
        Console.WriteLine("Student ID = {0}", id.Id);
        Console.WriteLine("Student Name = {0}", id.GetName());
        Console.WriteLine("Passing Marks = {0}", id.Getpassmarks());
        Console.WriteLine("Student Mail= {0}", id.Email);
    }
}

