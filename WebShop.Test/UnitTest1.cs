using NUnit.Framework;

namespace WebShop.Test
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
            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            if (false == true)
                Assert.Fail();
            else
                Assert.Pass();
        }
    }
}