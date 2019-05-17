using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsTestProject
{
    [TestClass]
    public class Class3
    {
        [TestMethod, TestCategory("Smoke")]
        public void TestMethod3()
        {
            Console.WriteLine("This is a method in class 3");
        }
    }
}
