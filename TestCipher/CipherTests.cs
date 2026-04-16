using NUnit.Framework;
using CaesarCipher; //why is it not finding this dang project?!

namespace TestCipher
{
    public class CipherTests
    {
        Caesar c;

        [SetUp]
        public void Setup()
        {
            c = new Caesar();
        }

        [Test]
        public void TestMoveForward()
        {
            var r = c.ShiftForward("The slow brown cow.");
            Assert.That(r, Is.EqualTo("Ftq exai ndaiz oai."));
        }
        [Test]
        public void TestMoveBackward()
        {
            var r = c.ShiftBackward("The slow brown cow.");
            Assert.That(r, Is.EqualTo("Hvs gzcl pfckb qck.."));
        }
    }
}
