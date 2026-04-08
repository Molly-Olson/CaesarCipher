using CaesarCipher;
using NUnit.Framework; // IDE populated this, do we need it though?

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
        public void Test1()
        {
            Assert.Pass();
        }
    }
}
