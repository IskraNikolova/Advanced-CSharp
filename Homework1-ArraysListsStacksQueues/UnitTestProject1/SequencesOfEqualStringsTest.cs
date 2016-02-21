namespace UnitTestProject1
{
    using System;
    using System.Collections.Generic;    
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Problem4_SequencesOfEqualStrings;

    [TestClass]
    public class SequencesOfEqualStringsTest
    {
        [TestMethod]
        public void Test_OrderEqualsElementsInGroup_ShouldContainsOnlyEqualsElementInOneGroup()
        {
            string[] elements = { "first", "second", "first", "first" };

            var actualeGroup = new Dictionary<string, string>();

            SequencesOfEqualStrings.OrderEqualsElementsInGroupByDictionary(elements, actualeGroup);

            string firstLine = actualeGroup["first"];
            string secondLine = actualeGroup["second"];

            Assert.AreEqual("first first first", firstLine);
            Assert.AreEqual("second", secondLine);
        }

        [TestMethod]
        public void Test_OrderElementsInOneGroup_ShouldContainsOnlyEqualsElementInOneGroup()
        {
            string[] elements = { "first", "first", "first", "first" };

            var actualeGroup = new Dictionary<string, string>();

            SequencesOfEqualStrings.OrderEqualsElementsInGroupByDictionary(elements, actualeGroup);

            string firstLine = actualeGroup["first"];

            Assert.AreEqual("first first first first", firstLine);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_OrderEmptyStringForData_ShouldThrowException()
        {
            string[] elements = new string[0];

            var actualeGroup = new Dictionary<string, string>();

            SequencesOfEqualStrings.OrderEqualsElementsInGroupByDictionary(elements, actualeGroup);
        }
    }
}
