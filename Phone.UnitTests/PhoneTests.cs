using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PhoneProject;

namespace UnitTests
{
    [TestClass]
    public class PhoneTests
    {
        [TestMethod]
        public void MakePhoneCall_UserHasCredit_ReturnsTrue()   
        {
            var phone = new Phone(2);

            Assert.IsTrue(phone.MakePhoneCall());
        }
    }
}
