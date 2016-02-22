using Problem3_MatrixShuffling;

namespace MultidimensionalArraysSetsDictionaries.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MatrixShuffingTest
    {
        [TestMethod]
        public void ValidataData_AddCommandWithInvalidIndexes_ShouldReturnFalse()
        {
            string[,] matrix = new string[2, 2] ;
            string[] command = "swap -1 -2 -1 -2".Split();
            string[] command2 = "swap 9 0 0 2".Split();

            bool result = MatrixShuffing.ValidateData(matrix, command);
            bool result2 = MatrixShuffing.ValidateData(matrix, command2);

            Assert.AreEqual(false, result);
            Assert.AreEqual(false, result2);
        }

        [TestMethod]
        public void ValidataData_AddInvalidCommand_ShouldReturnFalse()
        {
            string[,] matrix = new string[2, 2];
            string[] command = "0 1 1 1".Split();

            bool result = MatrixShuffing.ValidateData(matrix, command);

            Assert.AreEqual(false, result);
        }
    }
}
