using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using case_study_core;

namespace case_study_test
{
    [TestClass]
    public class UnitTest1
    {

        const string mockFirstName = "Sayaka";
        const string mockLastName = "Ishihara";

        [TestMethod]
        public void TestFizzbuzzLikeEachWithNonDivisibleNumber()
        {
            //using (var sw = new StringWriter()) {
            //    Console.SetOut(sw);
            //    string Expected = "Sayaka";
            //    case_study_core.Program.Main();

            //    var result = sw.ToString().Trim();
            //    Console.WriteLine(result);
            //    Assert.AreEqual(Expected, result);
            //}

            

            var mockNumber = 1;
            var expected = "1";

            var fizzbuzzValue = Program.FizzbuzzLikeEach(mockFirstName, mockLastName, mockNumber);
            Assert.AreEqual(expected, fizzbuzzValue);
        }

        [TestMethod]
        public void TestFizzbuzzLikeEachWithDivisibleByThree()
        {
            var mockNumber = 3;
            var expected = "Sayaka";

            var fizzbuzzValue = Program.FizzbuzzLikeEach(mockFirstName, mockLastName, mockNumber);
            Assert.AreEqual(expected, fizzbuzzValue);
        }
    }
}
