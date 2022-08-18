using Algorithms;

namespace AlgorithmsTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        private int[][] Samples()
        {
            int[][] samples = new int[9][];
            samples[0] = new[] { 1 };
            samples[1] = new[] { 2, 1 };
            samples[2] = new[] { 2, 1, 3 };
            samples[3] = new[] { 1, 1, 1 };
            samples[4] = new[] { 2, -1, 3, 3 };
            samples[5] = new[] { 4, -5, 3, 3 };
            samples[6] = new[] { 0, -5, 3, 3 };
            samples[7] = new[] { 0, -5, 3, 0 };
            samples[8] = new[] { 3, 2, 5, 5, 1, 0, 7, 8 };

            return samples;
        }

        private void RunTestsForSortingAlgorithms(Action<int[]> sortingFunction)
        {
            foreach(var sample in Samples())
            {
                PrintBefore(sample);
                sortingFunction(sample);
                CollectionAssert.IsOrdered(sample);
                PrintAfter(sample);
            }
        }

        private void PrintBefore(int[] arr)
        {
            TestContext.Write("Array before sorting: ");
            foreach (var item in arr)
            {
                TestContext.Write($" {item} ");
            }
        }

        private void PrintAfter(int[] arr)
        {
            TestContext.Write("Array after sorting: ");
            foreach (var item in arr)
            {
                TestContext.Write($" {item} ");
            }
            TestContext.Write($"\n");
        }

        [Test]
        public void BubbleSort_Returns_SortedArray()
        {
            RunTestsForSortingAlgorithms(Sorting.BubbleSort);
        }

        [Test]
        public void SelectionSort_Returns_SortedArray()
        {
            RunTestsForSortingAlgorithms(Sorting.SelectionSort);
        }

        [Test]
        public void InsertionSort_Returns_SortedArray()
        {
            RunTestsForSortingAlgorithms(Sorting.InsertionSort);
        }
    }
}