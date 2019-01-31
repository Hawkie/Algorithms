using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interview1
{

    [TestFixture]
    class Q1dot2Reverse
    {
        public string Reverse(string s)
        {
            var nString = "";
            for (int i=s.Length-2;i>=0; i--)
            { 
                nString += s[i];
            }
            return nString;
        }

        [TestCase("cigam", "agic")]
        [TestCase("scigam", "agics")]
        public void Test1dot2(string s, string sExpected)
        {
            StringAssert.AreEqualIgnoringCase(sExpected, Reverse(s));
        }
    }
}
