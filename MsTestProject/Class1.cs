using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsTestProject
{
  [TestClass]
   public class Class1
    {
        [AssemblyInitialize]
      public static void beforeAssembly(TestContext tc)
        {
            Console.WriteLine("This is before assembly class");
        }  
        
        [AssemblyCleanup]
        public static void afterAssembly()
        {
            Console.WriteLine("This is after assembly class");
        }  
    }
}
