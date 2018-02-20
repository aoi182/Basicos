using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataModel;

namespace DataModelUnitTestProject
{
    [TestClass]
    public class ContextUnitTest
    {
        [TestMethod]
        public void TestContext()
        {
            using (dbserviproductoEntities ctx = new dbserviproductoEntities())
            {
                var x = ctx.archivo.ToList();
            }
        }
    }
}