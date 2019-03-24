using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class PersonTests
    {
        #region EqualsTests
        [TestMethod]
        public void EqualsTestToTrue()
        {
            var p1 = new Person.Person("Anna", "Ivanova", 33);
            var p2 = new Person.Person("Anna", "Ivanova", 33);
            Assert.AreEqual(true, p1.Equals(p2));
        }

        [TestMethod]
        public void EqualsTestToFalse()
        {
            var p1 = new Person.Person("Anna", "Ivanova", 33);
            var p2 = new Person.Person("Polina", "Ivanova", 33);
            Assert.AreEqual(false, p1.Equals(p2));
        }
        #endregion
        #region ToStringTests
        [TestMethod]
        public void ToStringTest()
        {
            var p1 = new Person.Person("Anna", "Ivanova", 33);
            Assert.AreEqual("Name: Anna\n\rLastName: Ivanova\n\rAge: 33\n\r", p1.ToString());
        }
        #endregion
        #region HashCodeTests
        [TestMethod]
        public void HashCodesAreEqual()
        {
            var p1 = new Person.Person("Anna", "Ivanova", 33);
            var p2 = new Person.Person("Anna", "Ivanova", 33);
            Assert.AreEqual(true, p1.GetHashCode()==p2.GetHashCode());
        }
        [TestMethod]
        public void HashCodesAreNotEqual()
        {
            var p1 = new Person.Person("Anna", "Ivanova", 33);
            var p2 = new Person.Person("Anna", "Ivanova", 23);
            Assert.AreEqual(false, p1.GetHashCode() == p2.GetHashCode());
        }
        #endregion
        #region CloneTests
        [TestMethod]
        public void CorrectClone()
        {
            var p1 = new Person.Person("Anna", "Ivanova", 33);
            var p2 = p1.Clone();
            Assert.AreEqual(p1, p2);
        }
        [TestMethod]
        public void CorrectFullClone()
        {
            var p1 = new Person.Person("Anna", "Ivanova", 33);
            var p2 = p1.FullClone();
            Assert.AreEqual(p1, p2);
        }
        #endregion
    }
    [TestClass]
    public class StudentTests
    {
        #region EqualsTests
        [TestMethod]
        public void EqualsTestToFalse()
        {
            var s1 = new Student.Student("Mariya", "Petrova", 19, 2, 90);
            var s2 = new Student.Student("Sonya", "Zdorovceva", 27, 4, 98);
            Assert.AreEqual(false, s1.Equals(s2));
        }
        [TestMethod]
        public void EqualsTestToTrue()
        {
            var s1 = new Student.Student("Mariya", "Petrova", 19, 2, 90);
            var s2 = new Student.Student("Mariya", "Petrova", 19, 2, 90);
            Assert.AreEqual(true, s1.Equals(s2));
        }
        #endregion
        #region ToStringTest
        [TestMethod]
        public void ToStringTest()
        {
            var s1 = new Student.Student("Mariya", "Petrova", 19, 2, 90);
            Assert.AreEqual("IsGraduated: False\n\rAverageMark: 90\n\rCourse: 2\n\rName: Mariya\n\rLastName: Petrova\n\rAge: 19\n\r", s1.ToString());
        }
        #endregion
        #region HashCodeTests
        [TestMethod]
        public void HashCodesAreEqual()
        {
            var s1 = new Student.Student("Mariya", "Petrova", 19, 2, 90);
            var s2 = new Student.Student("Mariya", "Petrova", 19, 2, 90);
            Assert.AreEqual(true, s1.GetHashCode() == s2.GetHashCode());
        }
        [TestMethod]
        public void HashCodesAreNotEqual()
        {
            var s1 = new Student.Student("Mariya", "Petrova", 19, 2, 90);
            var s2 = new Student.Student("Sonya", "Zdorovceva", 27, 4, 98);
            Assert.AreEqual(false, s1.GetHashCode()==s2.GetHashCode());
        }
        #endregion
        #region CloneTests
        [TestMethod]
        public void StudentCloneTest()
        {
            var s1 = new Student.Student("Mariya", "Petrova", 19, 2, 90);
            Assert.AreEqual(s1, s1.Clone());
        }
        [TestMethod]
        public void StudentWithAdvisorCloneTest()
        {
            
            var s1 = new StudentWithAdvisor.StudentWithAdvisor("Mariya", "Petrova", 19, 2, 90, TeacherTests.t1);
            Assert.AreEqual(s1, s1.Clone());
        }
        [TestMethod]
        public void StudentFullCloneTest()
        {
            var s1 = new Student.Student("Mariya", "Petrova", 19, 2, 90);
            Assert.AreEqual(s1, s1.FullClone());
        }
        [TestMethod]
        public void StudentWithAdvisorFullCloneTest()
        {
            var s1 = new StudentWithAdvisor.StudentWithAdvisor("Mariya", "Petrova", 19, 2, 90, TeacherTests.t1);
            Assert.AreEqual(s1, s1.FullClone());
        }
        #endregion
    }
    [TestClass]
    public class TeacherTests
    {
        public static Teacher.Teacher t1 = new Teacher.Teacher("n1", "ln1", 25, "PE");
        static Teacher.Teacher t2 = new Teacher.Teacher("n2", "ln2", 33, "Physics");
        static Teacher.Teacher t3 = new Teacher.Teacher("n1", "ln1", 25, "PE");
        static Student.Student s1 = new Student.Student("Mariya", "Petrova", 19, 2, 90);
        static Student.Student s2 = new Student.Student("Petr", "Petrov", 18, 1, 88);
        
        #region EqualsTest
        [TestMethod]
        public void EqualsTestToFalse()
        {
            t1.AddStudent(s1);
            t1.AddStudent(s2);
            t2.AddStudent(s1);
            Assert.AreEqual(false, t1.Equals(t2));
        }
        [TestMethod]
        public void EqualsTestToTrue()
        {
            t1.AddStudent(s1);
            t2.AddStudent(s1);
            Assert.AreEqual(true, t1.Equals(t3));
        }
        #endregion
        #region ToStringTest
        [TestMethod]
        public void ToStringTest()
        {
            Assert.AreEqual(t1.ToString(), t1.ToString());
        }
        #endregion
        #region HashCodeTests
        [TestMethod]
        public void HashCodesAreEqual()
        {
            Assert.AreEqual(true, t1.GetHashCode() == t3.GetHashCode());
        }
        [TestMethod]
        public void HashCodesAreNotEqual()
        {
            Assert.AreEqual(false, t1.GetHashCode() == t2.GetHashCode());
        }
        #endregion
        #region CloneTests
        [TestMethod]
        public void CloneTest()
        {
            t1.AddStudent(s1);
            t1.AddStudent(s2);
            Assert.AreEqual(t1, t1.Clone());
        }
        [TestMethod]
        public void FullCloneTest()
        {
            t1.AddStudent(s1);
            t1.AddStudent(s2);
            Assert.AreEqual(t1, t1.FullClone());
        }
        #endregion
    }
}
