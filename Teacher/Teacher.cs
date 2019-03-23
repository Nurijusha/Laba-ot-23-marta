using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teacher
{
    public class Teacher : Person.Person
    {
        private static Random random = new Random();
        public Teacher(string Name, string LastName, int age, string subject) : base(Name, LastName, age)
        {
            studentsList = new List<Student.Student>();
            Subject = subject;
        }
        private List<Student.Student> studentsList;
        public void AddStudent(Student.Student student)
        {
            studentsList.Add(student);
        }

        public string Subject { get; private set; }

        public static Teacher RandomTeacher(List<Person.Person> list)
        {
            var teacherList = list.Where(x => x is Teacher).ToList();
            int rndNum = random.Next(0, teacherList.Count - 1);
            return (Teacher)teacherList[rndNum];
        }
        #region basefuncs
        public override bool Equals(object obj)
        {
            if (!(obj is Teacher)) return false;
            var t2 = obj as Teacher;
            for(int i=0; i<t2.studentsList.Count; i++)
            {
                if (t2.studentsList[i] == studentsList[i]) continue;
                else return false;
            }
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
