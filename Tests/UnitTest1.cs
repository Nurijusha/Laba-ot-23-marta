using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class PersonTests
    {
        #region Equals
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
        #region ToString
        [TestMethod]
        public void ToStringTest()
        {
            var p1 = new Person.Person("Anna", "Ivanova", 33);
            Assert.AreEqual("Name: Anna\n\rLastName: Ivanova\n\rAge: 33\n\r", p1.ToString());
        }
        #endregion
    }
    [TestClass]
    public class StudentTests
    {
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
    }
}
