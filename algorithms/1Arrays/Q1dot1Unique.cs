using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interview1
{
    class Q1dot1Unique
    {
        bool unique(string s)
        {
            HashSet<char> occurred = new HashSet<char>();
            //for (int i = 0; i < s.Length; i++)
            foreach (char c in s)
            {
                if (occurred.Contains(c))
                {
                    return false;
                }
                occurred.Add(c);
            }
            return true;
        }

        bool uniqueWithList(string s)
        {
            List<char> occurred = new List<char>();
            // for (int i = 0; i < s.Length; i++)
            foreach (char c in s)
            {
                if (occurred.Contains(c))
                {
                    return false;
                }
                occurred.Add(c);
            }
            return true;
        }

        bool uniqueWithNoData(string s)
        {
            for (int i = 0; i < s.Length - 1; i++)
            //foreach (char c in s)
            {
                char c = s[i];
                if (s.Skip(i + 1).Contains(c))
                {
                    return false;
                }
            }
            return true;
        }

        [TestCase("acdbghi")]
        public void IsUnique(string s)
        {

            Assert.IsTrue(unique(s));
        }

        [TestCase("acdbghi c")]
        public void IsNotUnique(string s)
        {

            Assert.IsFalse(unique(s));
        }

        [TestCase("acdbghi")]
        public void IsUnique_WithNoData(string s)
        {

            Assert.IsTrue(uniqueWithNoData(s));
        }

        [TestCase("acdbghi c")]
        public void IsNotUnique_WithNoData(string s)
        {

            Assert.IsFalse(uniqueWithNoData(s));
        }


    }
}
