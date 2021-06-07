using Fortnox.SDK;
using Fortnox.SDK.Connectors;
using Fortnox.SDK.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FortnoxSDK.Tests.ConnectorTests
{
    [TestClass]
    public class CompanyInformationTests
    {
        public FortnoxClient FortnoxClient = TestUtils.DefaultFortnoxClient;

        [TestMethod]
        public void Test_CompanyInformation_CRUD()
        {
            #region Arrange
            //Add code to create required resources
            #endregion Arrange

            ICompanyInformationConnector connector = FortnoxClient.CompanyInformationConnector;

            #region CREATE
            //Not Allowed
            #endregion CREATE

            #region UPDATE
            //Not Allowed

            #endregion UPDATE

            #region READ / GET

            var retrievedCompanyInformation = connector.Get();
            Assert.IsNotNull(retrievedCompanyInformation?.CompanyName);
            Assert.IsNotNull(retrievedCompanyInformation?.OrganizationNumber);

            #endregion READ / GET

            #region DELETE
            //Not Allowed
            #endregion DELETE

            #region Delete arranged resources
            //Add code to delete temporary resources
            #endregion Delete arranged resources
        }
    }
}
