using Microsoft.VisualStudio.TestTools.UnitTesting;
using DotNetSuper;

namespace DotnetSuperTests
{
    [TestClass]
    public class StringExtensionTests
    {
        [TestMethod]
        public void TestValidString()
        {
            Assert.IsTrue("a".IsValid());
            Assert.IsTrue("aa".IsValid());
        }

        [TestMethod]
        public void TestInvalidString()
        {
            Assert.IsFalse("".IsValid());
            Assert.IsFalse("  ".IsValid());
        }

        [TestMethod]
        public void TestBefore()
        {
            string usermail = "userid:user@gmail.com";
            Assert.AreEqual("userid", usermail.Before(":"));
        }
    }
}
