using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MsTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [ClassInitialize]
        public static void BeforeTestClass(TestContext Te)
        {
            Console.WriteLine("This is the test Before class");
        }

        [ClassCleanup]
        public static void AfterTestClass()
        {
            Console.WriteLine("This is the test after class");
        }
        [TestInitialize]
        public void BeforeTest()
        {
            Console.WriteLine("This is the test Before method");
        }
        [TestCleanup]
        public void AfterTest()
        {
            Console.WriteLine("This is the test after method");
        }
        [TestMethod, TestCategory("Smoke")]
        public void TestMethod1()
        {
            Console.WriteLine("This is first test method");
        }
        [TestMethod, TestCategory("Smoke")]
        public void TestMethod2()
        {
            Console.WriteLine("This is two test method");
        }
    }
}
