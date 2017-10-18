using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ArrayUtils.Tests
{
    [TestClass]
    public class ArrayUtilsTests
    {
        [TestMethod]
        public void QuickSort_ValidRandomArray_SortsCorrectly()
        {
            int[] actualArray   = new int[] { 3, 1, -4, 2, -5, -1, 0, 5, 4, -2, -3 };
            int[] expectedArray = new int[] { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 };

            ArrayUtils.QuickSort(actualArray);

            CollectionAssert.AreEqual(expectedArray, actualArray);
        }

        [TestMethod]
        public void QuickSort_ValidOneElementArray_SortsCorrectly()
        {
            int[] actualArray   = new int[] { 100 };
            int[] expectedArray = new int[] { 100 };

            ArrayUtils.QuickSort(actualArray);

            CollectionAssert.AreEqual(expectedArray, actualArray);
        }

        [TestMethod]
        public void QuickSort_EmptyArray_SortsCorrectly()
        {
            int[] actualArray   = new int[0];
            int[] expectedArray = new int[0];

            ArrayUtils.QuickSort(actualArray);

            CollectionAssert.AreEqual(expectedArray, actualArray);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void QuickSort_NullPassed_ArgumentNullExceptionThrown()
        {
            int[] actualArray = null;

            ArrayUtils.QuickSort(actualArray);
        }

        [TestMethod]
        public void MergeSort_ValidRandomArray_SortsCorrectly()
        {
            int[] actualArray   = new int[] { 7, 3, 5, 0, 1, 2, 6, 4 };
            int[] expectedArray = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };

            ArrayUtils.MergeSort(actualArray);

            CollectionAssert.AreEqual(expectedArray, actualArray);
        }

        [TestMethod]
        public void MergeSort_ValidOneElementArray_SortsCorrectly()
        {
            int[] actualArray   = new int[] { -6 };
            int[] expectedArray = new int[] { -6 };

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