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
    }
}