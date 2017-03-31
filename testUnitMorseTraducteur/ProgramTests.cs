using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MorseTraducteur;

namespace testUnitMorseTraducteur
{
    [TestClass]
    public class ProgramTests
    {
        

        [TestMethod]
        public void testTraduirMorse()
        {
            string phrase = Program.traduireMorse(".- .-  . .");

            Assert.AreEqual(phrase, "aa ee");
        }

        [TestMethod]
        public void testTraduirPhrase()
        {
            string phrase = Program.traduirePhrase("aa ee");

            Assert.AreEqual(phrase, ".- .- / . . ");
        }




    }
}
