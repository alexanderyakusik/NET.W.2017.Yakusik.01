using System;

namespace ArrayUtils
{
    public static class ArrayUtils
    {
        public static void QuickSort(int[] array)
        {
            // TODO
        }

        public static void MergeSort(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException();
            }

            RecursiveMerge(array, 0, array.Length);
        }

        // Sorts part of an array [leftIndex; rightIndex) recursively.
        private static void RecursiveMerge(int[] array, int leftIndex, int rightIndex)
        {
            if (leftIndex + 1 >= rightIndex)
            {
                return;
            }

            int middleIndex = (rightIndex + leftIndex) / 2;

            RecursiveMerge(array, leftIndex, middleIndex);
            RecursiveMerge(array, middleIndex, rightIndex);

            Merge(array, leftIndex, middleIndex, rightIndex);
        }

        // Merges two parts of an array.
        // First part:  [leftIndex; middleIndex)
        // Second part: [middleIndex; rightIndex)
        private static void Merge(int[] array, int leftIndex, int middleIndex, int rightIndex)
        {
            int currentLeftIndex = leftIndex;
            int currentRightIndex = middleIndex;
            int currentBufferIndex = 0;

            int[] buffer = new int[rightIndex - leftIndex];

            while (currentLeftIndex < middleIndex && currentRightIndex < rightIndex)
            {
                if (array[currentLeftIndex] <= array[currentRightIndex])
                {
                    buffer[currentBufferIndex++] = array[currentLeftIndex++];
                }
                else
                {
                    buffer[currentBufferIndex++] = array[currentRightIndex++];
                }
            }

            if (currentRightIndex == rightIndex)
            {
                while (currentLeftIndex < middleIndex)
                {
                    buffer[currentBufferIndex++] = array[currentLeftIndex++];
                }
            }
            else
            {
                while (currentRightIndex < rightIndex)
                {
                    buffer[currentBufferIndex++] = array[currentRightIndex++];
                }
            }

            currentBufferIndex = 0;
            for (int i = leftIndex; i < rightIndex; i++)
            {
                array[i] = buffer[currentBufferIndex++];
            }
        }
    }
}
