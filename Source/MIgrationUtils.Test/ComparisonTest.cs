using System;
using System.Collections;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MigrationUtils.Test
{
    [TestClass]
    public static class ComparisonTest
    {
        [TestMethod]
        public static void Compare(object object1,object object2, Type listType)
        {
            var object1List = ((IEnumerable)object1).Cast<object>().ToList();
            var object2List = ((IEnumerable)object2).Cast<object>().ToList();
            object1List.Count.Should().Be(object2List.Count);
            for (var i = 0; i < object1List.Count; i++)
            {
                object1List[i].Should().BeEquivalentTo(object2List[i]);
            }
        }
    }
}