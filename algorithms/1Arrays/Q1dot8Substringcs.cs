using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interview1
{
    // check if s2 is a rotation of s1, using only one call to a function isSubstring.
    // e.g. is "waterbottle" a rotation of "erbottlewat" 
    class Q1dot8Substringcs
    {
        public bool isRotation(string s1, string s2)
        {
            var s = s2 + s2;
            return s.Contains(s1);
        }

        [TestCase("waterbottle", "erbottlewat")]
        public void isSubstring_withSubstring_isTrue(string s1, string s2)
        {
            Assert.IsTrue(isRotation(s1, s2));
        }
        [TestCase("waterbottle", "erbotlewat")]
        public void isSubstring_withNoSubstring_isFalse(string s1, string s2)
        {
            Assert.IsFalse(isRotation(s1, s2));
        }
    }
}
