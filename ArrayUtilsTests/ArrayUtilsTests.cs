using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ArrayUtils.Tests
{
    [TestClass]
    public class ArrayUtilsTests
    {
        [TestMethod]
        public void MergeSort_ValidArray_SortsCorrectly()
        {
            int[] actualArray   = new int[] { 7, 3, 5, 0, 1, 2, 6, 4 };
            int[] expectedArray = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };

            ArrayUtils.MergeSort(actualArray);

            CollectionAssert.AreEqual(expectedArray, actualArray);
        }

        [TestMethod]
        public void MergeSort_EmptyArray_SortsCorrectly()
        {
            int[] actualArray   = new int[0];
            int[] expectedArray = new int[0];

            ArrayUtils.MergeSort(actualArray);

            CollectionAssert.AreEqual(expectedArray, actualArray);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void MergeSort_NullPassed_ThrowsArgumentNullException()
        {
            int[] actualArray = null;

            ArrayUtils.MergeSort(actualArray);
        }
    }
}