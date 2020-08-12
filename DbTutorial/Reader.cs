using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbTutorial
{
    public class Reader
    {
        public void ReadStudents()
        {
            var context = new SchoolContext();
            var students = (from s in context.Students
                            where s.StudentName == "Bill"
                            select s).Take(1);//TODO
        }
    }
}
