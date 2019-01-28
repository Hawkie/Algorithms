using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interview1
{
    class Q1dot3Duplicates
    {
        // mutating version of remove duplicate
        public string RemoveDuplicates(string s)
        {
            char previous = s[s.Length -1];
            for (int i=s.Length-2; i>=0; i--)
            {
                if (previous == s[i])
                {
                    s = s.Substring(0, i + 1) + s.Substring(i + 2);
                }
                else
                {
                    previous = s[i];
                }
            }
            return s;
        }

        [TestCase("baggy", "bagy")]
        [TestCase("baggyy", "bagy")]
        [TestCase("bbbaaaaggggyyyy", "bagy")]
        public void RemoveDup(string s, string sExpected)
        {
            StringAssert.AreEqualIgnoringCase(sExpected, RemoveDuplicates(s));
        }
    }
}
