using NUnit.Framework;

namespace NUnitTestProject2
{
    public class Tests
    {
        [SetUp]
        
        public void Setup()
        {
        }

        [Test]
        [Parallelizable(ParallelScope.All)]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}