using NUnit.Framework;

namespace Prog2_18_04_PrimerProgramConTest.Library
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            const string expected = "2020-04-18";
            ChangeFormat dateTest = new ChangeFormat("18/04/2020");
            Assert.AreEqual(expected, dateTest.FSlachToDash());
        }
    }
}