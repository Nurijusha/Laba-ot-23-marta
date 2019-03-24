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
    }
    [TestClass]
    public class TeacherTests
    {
        static Teacher.Teacher t1 = new Teacher.Teacher("n1", "ln1", 25, "PE");
        static Teacher.Teacher t2 = new Teacher.Teacher("n2", "ln2", 33, "Physics");
        static Teacher.Teacher t3 = new Teacher.Teacher("n1", "ln1", 25, "PE");
        #region EqualsTest
        [TestMethod]
        public void EqualsTestToFalse()
        {
            Assert.AreEqual(false, t1.Equals(t2));
        }
        [TestMethod]
        public void EqualsTestToTrue()
        {
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
    }
}
