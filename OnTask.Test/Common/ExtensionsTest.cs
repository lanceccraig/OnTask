﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnTask.Common;
using System.Diagnostics.CodeAnalysis;

namespace OnTask.Test.Common
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class ExtensionsTest
    {
        #region Tests
        [DataRow(1, 1, true)]
        [DataRow(1, 2, false)]
        [DataTestMethod]
        [TestMethod]
        public void IsParameterNullOrEqual_Integer(int x, int y, bool expected)
        {
            var actual = x.IsParameterNullOrEqual(y);
            Assert.AreEqual(expected, actual);
        }

        [DataRow(1, 1, true)]
        [DataRow(null, null, true)]
        [DataRow(1, null, true)]
        [DataRow(1, 2, false)]
        [DataRow(null, 1, false)]
        [DataTestMethod]
        [TestMethod]
        public void IsParameterNullOrEqual_NullableInteger(int? x, int? y, bool expected)
        {
            var actual = x.IsParameterNullOrEqual(y);
            Assert.AreEqual(expected, actual);
        }

        [DataRow("foo", "foo", true)]
        [DataRow(null, null, true)]
        [DataRow("foo", null, true)]
        [DataRow("foo", "bar", false)]
        [DataRow(null, "foo", false)]
        [DataTestMethod]
        [TestMethod]
        public void IsParameterNullOrEqual_String(string x, string y, bool expected)
        {
            var actual = x.IsParameterNullOrEqual(y);
            Assert.AreEqual(expected, actual);
        }

        [DataRow(1.5, 1.5, true)]
        [DataRow(1.5, null, true)]
        [DataRow(1.5, 2.5, false)]
        [DataTestMethod]
        [TestMethod]
        public void IsParameterNullOrEqualForNonNullable_Double(double x, double? y, bool expected)
        {
            var actual = x.IsParameterNullOrEqualForNonNullable(y);
            Assert.AreEqual(expected, actual);
        }

        [DataRow(1, 1, true)]
        [DataRow(1, null, true)]
        [DataRow(1, 2, false)]
        [DataTestMethod]
        [TestMethod]
        public void IsParameterNullOrEqualForNonNullable_Integer(int x, int? y, bool expected)
        {
            var actual = x.IsParameterNullOrEqualForNonNullable(y);
            Assert.AreEqual(expected, actual);
        } 
        #endregion
    }
}
