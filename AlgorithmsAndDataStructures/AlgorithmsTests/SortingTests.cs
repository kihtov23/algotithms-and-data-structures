using Algorithms;

namespace AlgorithmsTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BubbleSort_Returns_SortedArray()
        {
            //Act
            var sortedArray = Sorting.BubbleSort(new int[] { 6, 4, 7, 2 });

            //Assert
            CollectionAssert.IsOrdered(sortedArray);
        }

        [Test]
        public void SelectionSort_Returns_SortedArray()
        {
            //Act 
            var sortedArray = Sorting.SelectionSort(new int[] { 6, 4, 7, 2 });

            //Assert
            CollectionAssert.IsOrdered(sortedArray);
        }
    }
}