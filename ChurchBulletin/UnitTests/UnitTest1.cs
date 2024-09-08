using Pwi.Church.Core;
using Shouldly;

namespace UnitTests
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
            var class1 = new Class1();
            class1.ShouldNotBeNull();
        }
    }
}