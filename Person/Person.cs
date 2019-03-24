using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person :ICloneable, IDisposable
    {
        private static Random random = new Random();
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public Person(string Name, string LastName, int age)
        {
            this.LastName = LastName;
            this.Age = age;
            this.Name = Name;
        }

        public Person()
        {

        }

        public virtual void Print()
        {
            Console.Write(this.ToString());
        }
        public static Person RandomPerson(List<Person> list)
        {
            int rndNum = random.Next(0, list.Count - 1);
            return list[rndNum];
        }

        public virtual Person FullClone()
        {   
            return (Person)this.MemberwiseClone();
        }

        #region basefuncs
        public override string ToString()
        {
            var sb = new StringBuilder();
            var type = GetType();
            foreach (var prop in type.GetProperties())
            {
                var s = string.Format("{0}: {1}", prop.Name, prop.GetValue(this));
                sb.Append(s);
                sb.Append("\n\r");
            }
            return sb.ToString();   
        }
        public System.Reflection.PropertyInfo[] ClassProperties()
        {
            return GetType().GetProperties();
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Person)) return false;
            var p2 = obj as Person;
            var p1Props = ClassProperties();
            var p2Props = p2.ClassProperties();
            for (int i = 0; i < p2Props.Length; i++)
            {
                var tmp1 = p1Props[i].GetValue(this);
                var tmp2 = p2Props[i].GetValue(p2);
                if (tmp1.Equals(tmp2)) continue;
                else return false;
            }
            return true;
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public object Clone()
        {
            return (Person)this.FullClone();
        }

        public void Dispose()
        {
            Console.WriteLine("Меня вызвали ©Dispose");
        }

        public static bool operator ==(Person p1, Person p2)
        {
            return p1.Equals(p2);
        }

        public static bool operator !=(Person p1, Person p2)
        {
            return !p1.Equals(p2);
        }
        #endregion
    }
}
