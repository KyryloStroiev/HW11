using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11
{
    internal class ScheduleLesson
    {
        public int Numb;
        public string Lesson;
        //public string Days;
        public string Time;
        public ScheduleLesson(int numb, string lesson, string time)
        {
            Numb = numb;
            Lesson = lesson;
            Time = time;
        }
    }
}
