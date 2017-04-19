using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utils;

namespace RegexUtilities.Test
{
    [TestClass]
    public class EmailTest
    {
        [TestMethod]
        public void isValidEmailMethodReturnTrueIfMailIsValidWithDomain()
        {
            //Arrange
            var expected = true;
            var actual = false;
            var canditatingEmail = "email@emai.com";

            //Act
            actual = Email.IsValidEmail(canditatingEmail);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void isValidEmailMethodReturnTrueIfMailIsValidWithIPAddress()
        {
            //Arrange
            var expected = true;
            var actual = false;
            var canditatingEmail = "email@[192.168.1.27]";

            //Act
            actual = Email.IsValidEmail(canditatingEmail);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void isValidEmailMethodReturnFalseIfMailIsFalse()
        {
            //Arrange
            var expected = false;
            var actual = false;
            var canditatingEmail = "email@.com";

            //Act
            actual = Email.IsValidEmail(canditatingEmail);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
