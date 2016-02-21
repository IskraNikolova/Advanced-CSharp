namespace UnitTestProject1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Problem2_SortArrayOfNumbersUsingSelectionSort;

    [TestClass]
    public class SortArrayOfNumbersUsingSelectionSortTest
    {
        [TestMethod]
        public void Test_SelectionSort_ShoudSortElementsInCollection()
        {
            int[] collectionToSort = new int[] { 3, 2, 1, 0 };

            SortArrayOfNumbersUsingSelectionSort.SelectionSort(collectionToSort);

            for (int i = 0; i < collectionToSort.Length; i++)
            {
                Assert.AreEqual(i, collectionToSort[i]);
            }
        }
    }
}
