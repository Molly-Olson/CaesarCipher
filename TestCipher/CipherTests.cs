using CaesarCipher; //why is it not finding this dang project?!

namespace TestCipher
{
    public class CipherTests
    {
        CaesarCipher.Cipher c;

        [SetUp]
        public void Setup()
        {
            c = new CaesarCipher.Cipher();
        }

        [Test]
        public void TestMoveForward()
        {
            var r = c.MoveForward("The slow brown cow.");
            Assert.That(r, Is.EqualTo("Ftq exai ndaiz oai."));
        }
        [Test]
        public void TestMoveBackward()
        {
            var r = c.MoveBackward("The slow brown cow.");
            Assert.That(r, Is.EqualTo("Hvs gzcl pfckb qck.."));
        }
    }
}
