using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            //--Arrange
            var source = "AndreeaMonica";
            var expected = "Andreea Monica";

            //--Act
            var actual = source.InsertSpaces();
            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpacesTestWithExistingSpace()
        {
            //--Arrange
            var source = "Andreea Monica";
            var expected = "Andreea Monica";

            //--Act
            var actual = source.InsertSpaces();
            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
