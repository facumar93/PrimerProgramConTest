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
        public void Test1() // comprueba que se esté impidiendo que ingresen fechas inválidas.
        {
            bool expected = true;
            CheckDateExist toDate = new CheckDateExist("10/11/1977");
            Assert.AreEqual(expected, toDate.CheckExist());
        }
         [Test]
        public void Test2()
        {
            string expected = "10-11-1977";
            string resultado;
            CheckDateExist toDate1 = new CheckDateExist("10/11/1977");
            ChangeFormat date = new ChangeFormat(toDate1);
            
            Assert.AreEqual(expected,date.FSlashToDash());
        }
    }
}