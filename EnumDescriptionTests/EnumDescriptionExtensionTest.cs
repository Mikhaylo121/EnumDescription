using System;
using EnumDescription;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EnumDescriptionTests
{
    [TestClass]
    public class EnumDescriptionExtensionTest
    {
        const string Expected = "Full-time";

        [TestMethod]
        public void GetEnumDescriptionWithoutGenericTest()
        {
            string actual = ((Enum) EmployeeType.FullTime).GetDescription();

            Assert.AreEqual(Expected, actual);
        }

        [TestMethod]
        public void GetEnumDescriptionWithGenericTest()
        {

            string actual = EmployeeType.FullTime.GetDescription();

            Assert.AreEqual(Expected, actual);
        }
    }
}
