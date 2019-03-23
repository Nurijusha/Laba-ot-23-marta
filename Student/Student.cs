using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Student : Person.Person, IComparable<Student>
    {
        private static Random random = new Random();
        public Student(string Name, string LastName, int age, int course, double mark) : base(Name, LastName, age)
        {
            Course = course;
            AverageMark = mark;
        }
        public bool IsGraduated { get; private set; }
        public double AverageMark { get; private set; }
        public int Course { get; private set; }
        public Student UpCourse()
        {
            Course++;
            if (Course > 4)
                IsGraduated = true;
            return this;
        }
        
        public Person.Person ToPerson()
        {
            var p = new Person.Person("a", "", 0);
            foreach (var e in p.ClassProperties())
                if (this.ClassProperties().Contains(e))
                    e.SetValue(p, this.ClassProperties()[this.ClassProperties().ToList().BinarySearch(e)]);
            return p;
                    
        }

        public static Student RandomStudent(List<Person.Person> list)
        {
            var studList = list.Where(x => x is Student).ToList();
            int rndNum = random.Next(0, studList.Count - 1);
            return (Student)studList[rndNum];
        }
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

        public int CompareTo(Student other)
        {
            return this.Age - other.Age;
        }
        #endregion
    }
}
