using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11
{
    public class AboutTeachers: Teachers
    {
        public string AboutTeachers1;
        public AboutTeachers(string aboutteachers) : base()
        {
            AboutTeachers1 = aboutteachers;
        }
        public void WriteTeachers()
        {
            AboutTeachers1 = Console.ReadLine();
            Console.WriteLine(AboutTeachers1);
        }
    }
}
