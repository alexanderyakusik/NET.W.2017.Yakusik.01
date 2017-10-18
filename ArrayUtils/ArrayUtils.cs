using System;

namespace ArrayUtils
{
    public static class ArrayUtils
    {
        public static void QuickSort(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException();
            }

            if (array.Length == 0)
            {
                return;
            }

            RecursiveQuickSort(array, 0, array.Length - 1);
        }

        // Sorts part of an array [leftIndex; rightIndex] recursively using quick sort.
        private static void RecursiveQuickSort(int[] array, int leftIndex, int rightIndex)
        {
            int currentLeftIndex = leftIndex;
            int currentRightIndex = rightIndex;

            int middleElement = array[(leftIndex + rightIndex) / 2];

            do
            {
                while (array[currentLeftIndex] < middleElement)
                {
                    currentLeftIndex++;
                }

                while (array[currentRightIndex] > middleElement)
                {
                    currentRightIndex--;
                }

                if (currentLeftIndex <= currentRightIndex)
                {
                    int temp = array[currentLeftIndex];
                    array[currentLeftIndex] = array[currentRightIndex];
                    array[currentRightIndex] = temp;

                    currentLeftIndex++;
                    currentRightIndex--;
                }
            } while (currentLeftIndex <= currentRightIndex);

            if (currentRightIndex > leftIndex)
            {
                RecursiveQuickSort(array, leftIndex, currentRightIndex);
            }

            if (currentLeftIndex < rightIndex)
            {
                RecursiveQuickSort(array, currentLeftIndex, rightIndex);
            }
        }

        public static void MergeSort(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException();
            }

            RecursiveMergeSort(array, 0, array.Length);
        }

        // Sorts part of an array [leftIndex; rightIndex) recursively using merge sort.
        private static void RecursiveMergeSort(int[] array, int leftIndex, int rightIndex)
        {
            if (leftIndex + 1 >= rightIndex)
            {
                return;
            }

            int middleIndex = (rightIndex + leftIndex) / 2;

            RecursiveMergeSort(array, leftIndex, middleIndex);
            RecursiveMergeSort(array, middleIndex, rightIndex);

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
