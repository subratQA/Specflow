using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsTestProject
{
    [TestClass]
    public class Class2
    {
        [TestMethod,TestCategory("Sanity")]
        public void TestCaseOne()
        {
            Console.WriteLine("This is Test method in class two");
        }

        
    }
}
