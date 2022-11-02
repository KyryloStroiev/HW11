using Nest;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HW11;

public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Student()
    {

    }
    public Student( int id, string firstname, string lastname)
    {
        Id = id;
        FirstName = firstname;
        LastName = lastname;
    }

    public void PrintStudent(string path)
    {
        Console.WriteLine("Ведiть Id, прiзвище та iм'я студента:");
        var idi = Console.ReadLine();
        Id = Convert.ToInt32(idi);
        FirstName = Console.ReadLine();
        LastName = Console.ReadLine();
        Console.WriteLine($"Данi студента: {Id}, {FirstName}, {LastName}");
        File.AppendAllLines(path, new[] { $"{Id}, {FirstName}, {LastName}" });
    }
   public void StudentAdd()
    {
        var AddStudent = @"C:\Users\User\Desktop\HM\HW11\HW11\Student.txt";
        PrintStudent(AddStudent);
    }
}
   
   

 





