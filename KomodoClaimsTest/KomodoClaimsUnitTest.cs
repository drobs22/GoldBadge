using System;
using KomodoClaims;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KomodoClaimsTest
{
    [TestClass]
    public class KomodoClaimsUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Claims claim2 = new Claims(2, "Home", "House fire in Kitchen", 400, 4 / 11 / 2018, 4 / 12 / 2018, true)

            // Arange

            int claimID = 2;
            string claimType = "Home";
            string description = "House fire in Kitchen";
            decimal amount = 400m;
            DateTime dateOfIncident = new DateTime (2018, 04, 11);
            DateTime dateOfClaim = new DateTime (2018, 04, 12);
            bool valid = false;

            // Act

            Claims testclaim = new Claims(claimID, claimType, description, amount, dateOfIncident, dateOfClaim, valid);

            // Assert

            Assert.AreEqual(claimID, testclaim.ClaimID);
            Assert.IsTrue(valid);
     
        }
    }
}
