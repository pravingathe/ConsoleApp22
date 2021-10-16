using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FileData.UnitTests
{
    [TestClass]
    public class FileInformationTest
    {
        [TestMethod]
        public void TestMethod_FirstRequirement_Validate()
        {
            //Act  
            IFileInformation obj = new FileInformation();

            //Action  
            obj.FirstRequirement ("-Wrong", "D:/test.txt");

            //Assert  
            Assert.AreEqual(obj.ErrorMessage, "FirstRequirement Failed! Only -v is allowed.");
        }

        [TestMethod]
        public void TestMethod_SecondRequirement_Validate()
        {
            //Act  
            IFileInformation obj = new FileInformation();

            //Action  
            obj.SecondRequirement("-Wrong2nd", "D:/test.txt");

            //Assert  
            Assert.AreEqual(obj.ErrorMessage, "SecondRequirement Failed! Size or version param doesn't match.");
        }

        [TestMethod]
        public void TestMethod_FirstRequirement_Success()
        {
            //Act  
            IFileInformation obj = new FileInformation();

            //Action  
            obj.FirstRequirement("-v", "D:/test.txt");

            //Assert  
            Assert.IsTrue(string.IsNullOrEmpty(obj.ErrorMessage));

        }

        [TestMethod]
        public void TestMethod_SecondRequirement_Success()
        {
            //Act  
            IFileInformation obj = new FileInformation();

            //Action  
            obj.SecondRequirement("-s", "D:/test.txt");

            //Assert  
            Assert.IsTrue(string.IsNullOrEmpty(obj.ErrorMessage));
        }
    }
}
