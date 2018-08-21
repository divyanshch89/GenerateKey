using GenerateKey.DAL;
using GenerateKey.Models;
using Microsoft.Azure.Documents;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        public UnitTest1()
        {
            DocumentDBRepository<WOModel>.Initialize();
        }
        [TestMethod]
        public async void CreateDummyOrder()
        {
            var wo = new WOModel
            {
                WorkOrder = new WorkOrder()
            };
            wo.WorkOrder.RoutingElements = new RoutingElements
            {
                Origin = "SI7",
                Target = "FacilitySource"
            };
            wo.WorkOrder.Keys = new Keys
            {
                Source_WO_ID = "XX-12234",
                Unified_WO_ID = "This will be generated here"
               
            };
            var result = await DocumentDBRepository<WOModel>.CreateItemAsync(wo);
            Assert.IsNotNull(result);
        }
    }
}
