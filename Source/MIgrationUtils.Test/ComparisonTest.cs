using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MigrationUtils.Test
{
    [TestClass]
    public static class ComparisonTest
    {
        [TestMethod]
        public static void Compare(List<object> object1,List<object> object2)
        {
            object1.Should().BeEquivalentTo(object2);
        }
    }
}