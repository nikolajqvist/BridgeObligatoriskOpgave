using Bridge;

namespace BridgeTest
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod_Price()
        {
            Car car1 = new Car("XK72828", DateTime.Now);

            var expectedprice = car1.Price();

            double result = 230;

            Assert.IsTrue(expectedprice == result);
        }
        [TestMethod]
        public void TestMethod_ReturnString()
        {
            Car c1 = new Car("FJ46726", DateTime.Now);

            string iscar = "Car";

            var expected = c1.VehicleType();

            Assert.IsTrue(expected == iscar);
        }
    }
}
