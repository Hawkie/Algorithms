using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interview1
{
    public class Q1dot5Replace
    {
        public string ReplaceSpace(string s1)
        {
            string s = "";
            for (int i=0; i<s1.Length; i++)
            {
                char c = s1[i];
                string r = c.ToString();
                if (c == ' ')
                {
                    r = "%20";
                }
                s += r;
            }
            return s;
        }

        public string ReplaceSpaceCheat(string s1)
        {
            var s = s1.Replace(" ", "%20");
            return s;
        }

        [TestCase("I am Happy", "I%20am%20Happy")]
        public void Replace(string s, string expected)
        {
            StringAssert.AreEqualIgnoringCase(expected, ReplaceSpace(s));
        }
    }
}
