using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class ContainerPersons : IEnumerable<Person>
    {
        List<Person> list = new List<Person>();
        public void Add(Person p) => list.Add(p);
        public IEnumerator<Person> GetEnumerator()
        {
            for (int i = 0; i < list.Count; i++)
                yield return list[i];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public Person this[int index]
        {
            get { return list[index]; }
            set { list[index] = value; }
        }
    }
}
