using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BinarySearchLib;
using NUnit.Framework;

namespace BinarySearchLibTest
{
    [TestFixture]
    public class BinarySearchTest
    {
        [Test]
        public void FindNumber()
        {
            var numbers = new List<int>() { 1,2,3,4,5,6,7,8,9};

            var position = BinarySearch.Find( numbers, 3 );
            Assert.AreEqual( 2, position);
        }
    }

}
