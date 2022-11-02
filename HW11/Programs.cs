using HW11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


var school = new School();
school.Print();
var student = new Student();
student.StudentAdd();
var schedulelesson = new List<ScheduleLesson>()
{
    new ScheduleLesson(1, "Математика", "09:30" ),
    new ScheduleLesson(2, "Мова", "11:25"),
    new ScheduleLesson (3, "Фiзкультура", "13:40")
};







