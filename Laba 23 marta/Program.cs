using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_23_marta
{
    class Program
    {
        static List<Person.Person> people = new List<Person.Person>();
        static void Main(string[] args)
        {
            #region работа с листом персон
            using (var p1 = new Person.Person("Grisha", "Ivanov", 13))
            using (var p2 = new Person.Person("Liya", "Makarova", 33))
            {
                var t1 = new Teacher.Teacher("Zulfat", "Makarov", 33, "math");
                var t2 = new Teacher.Teacher("Misha", "Zaycev", 47, "english");
                var s1 = new StudentWithAdvisor.StudentWithAdvisor("Mariya", "Petrova", 19, 2, 90, t1);
                var s2 = new StudentWithAdvisor.StudentWithAdvisor("Sonya", "Zdorovceva", 27, 4, 98, t2);
                var s3 = new StudentWithAdvisor.StudentWithAdvisor("Polina", "Petrova", 18, 1, 98, t2);
                var s4 = new StudentWithAdvisor.StudentWithAdvisor("Artur", "Cheremisin", 19, 1, 60, t2);
                t1.AddStudent(s1 as Student.Student);
                t2.AddStudent(s2 as Student.Student);
                people = new List<Person.Person>() { p1, p2, s1, s2, t1, t2, s3, s4 };
                var personAndStudents = new Person.ContainerPersons
                {
                    p1,
                    p2,
                    s1,
                    s2,
                    s3,
                    s4
                };
                var count = 0;
                foreach (var t in personAndStudents)
                {
                    count++;
                    Console.WriteLine($"Персона или студент в контейнере: {count} {t}");
                }
                foreach (var e in people)
                    e.Print();
                Console.WriteLine("Персон в списке: " + people.Where(x => x is Person.Person).Count());
                Console.WriteLine("Студентов в списке: " + people.Where(x => (x is Student.Student || x is StudentWithAdvisor.StudentWithAdvisor)).Count());
                Console.WriteLine("Учителей в списке: " + people.Where(x => x is Teacher.Teacher).Count());

                for (int i = 0; i < people.Count(); i++)
                {
                    if (people[i] is Student.Student)
                    {
                        people[i] = (people[i] as Student.Student).UpCourse();
                        if ((people[i] as Student.Student).IsGraduated)
                        {
                            people[i] = (people[i] as Student.Student).ToPerson();
                        }
                    }
                }
                Console.WriteLine("Студентов в списке(после перевода на след.курс): " + people.Where(x => (x is Student.Student || x is StudentWithAdvisor.StudentWithAdvisor)).Count());
                var students = new Student.Student[] { s1, s2, s3, s4 };
                Console.WriteLine("\n\rStudents before sort:");
                foreach (var student in students)
                {
                    student.Print();
                    Console.WriteLine("__");
                }
                Console.WriteLine("Students after sort:");
                Array.Sort(students);
                foreach (var student in students)
                    student.Print();

            }
            #endregion

            Console.Write("Нажмите Enter для завершения приложения ...");
            Console.ReadLine();
        }
    }
}
