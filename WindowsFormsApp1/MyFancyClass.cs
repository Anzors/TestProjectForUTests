using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectForUtests
{
    [TestClass]
    class MyFancyClass
    {
        MyFancyClass my;

        [ClassInitialize]

        public static void TestFixtureSetup(TestContext context)
        {
            Debug.WriteLine("Class set up: " + context);

        }


        [TestInitialize]

        public void Setup()
        {
            Debug.WriteLine("Hello this is setup");
            my = new MyFancyClass(6, 7);
        }


        [TestMethod]

        public void TestAdd()
        {
            Debug.WriteLine("TestAdd");
            int sum = my.add();
            Assert.AreEqual(13, sum);
        }

        [TestMethod]
        public void TestSub()
        {
            Debug.WriteLine("TestSub");
            int sum = my.sub();
            Assert.AreEqual(-1, sum);
        }

        [TestCleanup]

        public void Cleanup()
        {
            Debug.WriteLine("Cleaned");
        

        }
    }
}
