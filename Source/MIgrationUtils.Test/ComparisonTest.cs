using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MigrationUtils.Test
{
    [TestClass]
    public static class ComparisonTest
    {
        [TestMethod]
        public static void Compare(object object1,object object2)
        {
            object1.Should().BeEquivalentTo(object2);
        }
    }
}