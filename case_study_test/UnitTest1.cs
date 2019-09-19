using Microsoft.VisualStudio.TestTools.UnitTesting;
using case_study_core;

namespace case_study_test
{
    [TestClass]
    public class UnitTestFizzbuzzLikeEach
    {
        const string mockFirstName = "Sayaka";
        const string mockLastName = "Ishihara";

        [TestMethod]
        public void TestFizzbuzzLikeEachWithNonDivisibleNumber()
        {
            var mockNumber = 2;
            var expected = "2";

            var fizzbuzzValue = Program.FizzbuzzLikeEach(mockFirstName, mockLastName, mockNumber);
            Assert.AreEqual(expected, fizzbuzzValue);
        }

        [TestMethod]
        public void TestFizzbuzzLikeEachWithDivisibleBy_3()
        {
            var mockNumber = 3;
            var expected = "Sayaka";

            var fizzbuzzValue = Program.FizzbuzzLikeEach(mockFirstName, mockLastName, mockNumber);
            Assert.AreEqual(expected, fizzbuzzValue);
        }

        [TestMethod]
        public void TestFizzbuzzLikeEachWithDivisibleBy_5()
        {
            var mockNumber = 10;
            var expected = "Ishihara";

            var fizzbuzzValue = Program.FizzbuzzLikeEach(mockFirstName, mockLastName, mockNumber);
            Assert.AreEqual(expected, fizzbuzzValue);
        }

        [TestMethod]
        public void TestFizzbuzzLikeEachWithDivisibleBy_15()
        {
            var mockNumber = 30;
            var expected = "Sayaka Ishihara";

            var fizzbuzzValue = Program.FizzbuzzLikeEach(mockFirstName, mockLastName, mockNumber);
            Assert.AreEqual(expected, fizzbuzzValue);
        }
    }

    [TestClass]
    public class UnitTestIsLessThanLimit
    {
        const int lengthLimit = 20;

        [TestMethod]
        public void TestShorterThanLimitCase()
        {
            const string mockName = "a";
            bool expected = true;

            var outcome = Program.IsLessThanLimit(mockName, lengthLimit);
            Assert.AreEqual(expected, outcome);
        }

        [TestMethod]
        public void TestLongerThanLimitCase()
        {
            const string mockName = "aaaaaaaaaaaaaaaaaaaaa";
            bool expected = false;

            var outcome = Program.IsLessThanLimit(mockName, lengthLimit);
            Assert.AreEqual(expected, outcome);
        }

    }


    [TestClass]
    public class UnitTestIsAlphabet
    {
        [TestMethod]
        public void TestAlphabetCase()
        {
            const string mockName = "Sayaka";
            bool expected = true;

            var outcome = Program.IsAlphabet(mockName);
            Assert.AreEqual(expected, outcome);
        }

        [TestMethod]
        public void TestNonAlphabetCase()
        {
            const string mockName = "a ";
            bool expected = false;

            var outcome = Program.IsAlphabet(mockName);
            Assert.AreEqual(expected, outcome);
        }
    }
}
