using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectForUtests
{
    public class TestFancyClass
    {
        int num1;
        int num2;

        public TestFancyClass(int n1, int n2)
        {
            num1 = n1;
            num2 = n2;

        }
        public int add()
        {
            return num1 + num2;
        }
        public int sub()
        {
            return num1 - num2;
        }

    }
}
