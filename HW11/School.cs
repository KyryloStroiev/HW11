using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11;

internal class School
{
    private const int Id = 234;
    private const string Name = "Середня школа";
    public void Print()
    {
        Console.WriteLine($"{Name} номер: {Id}");
    }
}
