using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentWithAdvisor
{
    public class StudentWithAdvisor : Student.Student
    {
        public StudentWithAdvisor(string Name, string LastName, int age, int course, double mark, Teacher.Teacher teacher) : base(Name, LastName, age, course, mark)
        {
            Teacher = teacher;
        }
        public Teacher.Teacher Teacher { get; private set; }
        #region basefuncs
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override void Print()
        {
            base.Print();
        }

        public override string ToString()
        {
            return base.ToString();
        }
        #endregion
    }
}
