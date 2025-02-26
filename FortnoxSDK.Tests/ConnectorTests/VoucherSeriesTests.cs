using System.Threading.Tasks;
using Fortnox.SDK;
using Fortnox.SDK.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FortnoxSDK.Tests.ConnectorTests
{
    [TestClass]
    public class VoucherSeriesTests
    {
        public FortnoxClient FortnoxClient = TestUtils.DefaultFortnoxClient;

        [TestMethod]
        public async Task Test_VoucherSeries_CRUD()
        {
            #region Arrange
            //Add code to create required resources
            #endregion Arrange

            var connector = FortnoxClient.VoucherSeriesConnector;

            #region CREATE
            //var digits = new char[]{ '0', '1', '2', '3', '4', '5'}
            var newVoucherSeries = new VoucherSeries()
            {
                Code = TestUtils.RandomInt().ToString(),
                Description = "TestVoucherSeries",
            };

            var createdVoucherSeries = await connector.CreateAsync(newVoucherSeries) ?? await connector.UpdateAsync(newVoucherSeries); //if already exists, update it instead
            Assert.AreEqual("TestVoucherSeries", createdVoucherSeries.Description);

            #endregion CREATE

            #region UPDATE

            createdVoucherSeries.Description = "UpdatedTestVoucherSeries";

            var updatedVoucherSeries = await connector.UpdateAsync(createdVoucherSeries); 
            Assert.AreEqual("UpdatedTestVoucherSeries", updatedVoucherSeries.Description);

            #endregion UPDATE

            #region READ / GET

            var retrievedVoucherSeries = await connector.GetAsync(createdVoucherSeries.Code);
            Assert.AreEqual("UpdatedTestVoucherSeries", retrievedVoucherSeries.Description);

            #endregion READ / GET

            #region DELETE
            //Not supported
            #endregion DELETE

            #region Delete arranged resources
            //Add code to delete temporary resources
            #endregion Delete arranged resources
        }
    }
}
