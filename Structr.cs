using System;
struct student
{
    public String Firstname, Lastname, Address;
}
struct Marks
{
    public student s;
    public int math, sci, eng, physics, hindi;
}
class nest
{
    public static void Main()
    {
        Marks m;
        m.s.Firstname = "Yogita";
        m.s.Lastname = "Thorat";
        m.s.Address = "Latur" +
            "";
        m.math = 85;
        m.sci = 70;
        m.eng = 80;
        m.physics = 84;
        m.hindi = 75;
        Console.WriteLine("First Name = " + m.s.Firstname);
        Console.WriteLine("Last Name = " + m.s.Lastname);
        Console.WriteLine("Address=" + m.s.Address);
        Console.WriteLine("Math Marks = " + m.math);
        Console.WriteLine("Science = " + m.sci);
    }
}
