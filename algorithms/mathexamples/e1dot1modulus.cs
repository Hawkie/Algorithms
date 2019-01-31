using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms.mathexamples
{
    class e1dot1modulus
    {
        bool DivisibleBy(int x, int by)
        {
            if (x % by == 0)
            {
                return true;
            }
            return false;
        }

        IEnumerable<int> DivBy3And15(int x)
        {
            var divisible = new List<int>();
            if (DivisibleBy(x, 3))
            {
                divisible.Add(3);
            }
            if (DivisibleBy(x, 5))
            {
                divisible.Add(5);
            }
            if (DivisibleBy(x, 15))
            {
                divisible.Add(15);
            }
            return divisible;
        }

        void Display(int x, IEnumerable<int> list)
        {
            if (list.Any())
            {
                Console.Write("{0} is divisible by: {1}", x, list.First());
                if (list.Count() > 1)
                {
                    foreach (int item in list.Skip(1).Take(list.Count() - 2))
                    {
                        Console.Write(", {0}", item);
                    }
                    Console.Write(" and {0}", list.Last());
                }
                Console.WriteLine();
            }
        }



        [TestCase(3, true)]
        [TestCase(0, true)]
        [TestCase(2, false)]
        [TestCase(7, false)]
        public void DivisibleBy3(int x, bool expected)
        {
            Assert.AreEqual(expected, DivisibleBy(x, 3));
        }

        [TestCase(100, 47)]
        public void Test(int max, int expected)
        {
            var total = new List<IEnumerable<int>>();
            foreach(int x in Enumerable.Range(1,max))
            {
                var list = DivBy3And15(x);
                Display(x, list);
                if (list.Any())
                {
                    total.Add(list);
                }
            }
            Assert.AreEqual(expected, total.Count);
        }
    }
}
