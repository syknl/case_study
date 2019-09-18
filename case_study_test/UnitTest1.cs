using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace case_study_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter()) {
                Console.SetOut(sw);
                string Expected = "Gareth";
                case_study_core.Program.Main();
                
                var result = sw.ToString().Trim();
                Console.WriteLine(result);
                Assert.AreEqual(Expected, result);
            }
        }
    }
}
