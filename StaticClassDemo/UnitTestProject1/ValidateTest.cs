using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLib;

namespace UnitTestProject1
{
    [TestClass]
    public class ValidateTest
    {

        [TestMethod]
        public void VlidateDecimalTrue_Pos() 
        {
            Assert.IsTrue(Validate.ValidateDecimal("10.5"));
        }

        [TestMethod]
        public void ValidateDecimalFalse_Pos()
        {
            Assert.IsFalse(Validate.ValidateDecimal("a"));
        }

        [TestMethod]
        public void ValidateIntegerTrue_Pos()
        {
            Assert.IsTrue(Validate.ValidateInteger("10"));
        }

        [TestMethod]
        public void ValidateIntegerFalse_Pos()
        {
            Assert.IsFalse(Validate.ValidateInteger("a"));
        }

        [TestMethod]
        public void ValidateLengthTrue_Pos()
        {
            Assert.IsTrue(Validate.ValidateLength(2,"aa"));
        }

        [TestMethod]
        public void ValidateLengthFalse_Pos()
        {
            Assert.IsFalse(Validate.ValidateLength(2, "aaa"));
        }

        [TestMethod]
        public void ValidateMaxLengthTrue_Pos()
        {
            Assert.IsTrue(Validate.ValidateMaxLength(2,"a"));
        }

        [TestMethod]
        public void ValidateMaxLengthFalse_Pos()
        {
            Assert.IsFalse(Validate.ValidateMaxLength(2, "aaa"));
        }

        [TestMethod]
        public void ValidateMinLengthTrue_Pos()
        {
            Assert.IsTrue(Validate.ValidateMinLength(2, "aa"));
        }

        [TestMethod]
        public void ValidateMinLengthFlase_Pos()
        {
            Assert.IsFalse(Validate.ValidateMinLength(2, "a"));
        }

    }
}
