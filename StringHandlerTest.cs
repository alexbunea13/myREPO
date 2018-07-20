using System;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            //Arrange
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";
            //var handler = new StringHandler();

            //Act

            //var actual = StringHandler.insertSpaces(source);
            var actual = source.insertSpaces();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpacesTestWithExistingSpace()
        {
            //Arrange
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";
            //var handler = new StringHandler();

            //Act
            //var actual = StringHandler.insertSpaces(source);
            var actual = source.insertSpaces();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
