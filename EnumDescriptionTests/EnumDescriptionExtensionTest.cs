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
            string actual = EmployeeType.FullTime.GetEnumDescriptionWithoutGenerics();

            Assert.AreEqual(Expected, actual);
        }

        [TestMethod]
        public void GetEnumDescriptionWithGenericTest()
        {

            string actual = EmployeeType.FullTime.GetEnumDescriptionWithGenerics();

            Assert.AreEqual(Expected, actual);
        }
    }
}
