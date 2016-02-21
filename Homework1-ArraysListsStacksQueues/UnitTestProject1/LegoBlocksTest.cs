namespace UnitTestProject1
{
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Problem8_LegoBlocks;

    [TestClass]
    public class LegoBlocksTest
    {
        [TestMethod]
        public void Test_CheckIsFitLegoBlocks_ShouldReturnCorectBoolValue()
        {
            List<int[]> firstBlocks = new List<int[]>() { new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4 } };
            List<int[]> secondBlocks = new List<int[]>() { new[] { 6, 7, 8 }, new[] { 5, 6, 7, 8 } };
            List<int[]> thirdBlocks = new List<int[]>() { new[] { 6, 7, 8 }, new[] { 5, 6, 7 } };

            bool result = LegoBlocks.CheckIsFitLegoBlocks(firstBlocks, secondBlocks);
            bool falseResult = LegoBlocks.CheckIsFitLegoBlocks(firstBlocks, thirdBlocks);

            Assert.IsTrue(result);
            Assert.IsFalse(falseResult);
        }

        [TestMethod]
        public void Test_CheckCountOfSellsOfMatrix_ShouldReturnCorectSize()
        {
            List<int[]> firstBlocks = new List<int[]>() { new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4 } };

            int sellsCount = LegoBlocks.FindCountOfSells(firstBlocks);

            Assert.AreEqual(9, sellsCount);
        }
    }
}
