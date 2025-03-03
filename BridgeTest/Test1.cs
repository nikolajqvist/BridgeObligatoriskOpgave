using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Bridge;
using Microsoft.Testing.Platform.MSBuild;

namespace BridgeTest
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod_PriceCar()
        {
            Car car1 = new Car("XK72828");

            var expectedprice = car1.Price();

            double result = 230;

            Assert.IsTrue(expectedprice == result);
        }
        [TestMethod]
        public void TestMethod_ReturnStringCar()
        {
            Car c1 = new Car("FJ46726");

            string iscar = "Car";

            var expected = c1.VehicleType();

            Assert.IsTrue(expected == iscar);
        }
        [TestMethod]
        public void TestMethod_PriceMC()
        {
            MC m = new MC("TJ47283");

            double expectedprice = 120;

            var actualprice = m.Price();

            Assert.IsTrue(expectedprice == actualprice);
        }
        [TestMethod]
        public void TestMethod_ReturnStringMC()
        {
            MC m = new MC("TJ47283");

            string expectedprice = "MC";

            var actualprice = m.Vehicle();

            Assert.IsTrue(expectedprice == actualprice);
        }
        [DataRow("XJ43432")]
        [TestMethod]
        public void TestConstructorCar(string licensplate)
        {
            Car c1 = new Car(licensplate);

            string expected = c1.Licensplate;

            string result = "XJ43432";

            Assert.AreEqual(expected, result);
        }
        [DataRow("XJ43432")]
        [TestMethod]
        public void TestConstructorMC(string licensplate)
        {
            MC c1 = new MC(licensplate);

            string expected = c1.LicensPlate;

            string result = "XJ43432";

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestConstructorCar_DateOnly()
        {
            Car c1 = new Car("GJ24294");

            var expected = c1.Date;

            var result = DateTime.Now;

            //Tester om datoen passer.
            Assert.IsTrue((result - expected).TotalSeconds < 1);
        }
        [TestMethod]
        public void TestConstructorMC_DateOnly()
        {
            MC c1 = new MC("GJ24294");

            var expected = c1.Date;

            var result = DateTime.Now;

            //Tester om datoen passer. Er true hvis forskellen i sekunder er mindre en 1.
            Assert.IsTrue((result - expected).TotalSeconds < 1);
        }
        [TestMethod]
        public void TestConstructorCar_Time()
        {
            Car c1 = new Car("GJ24294");

            var expected = c1.Date;

            var result = DateTime.Now;

            //Tester om datoen passer.
            Assert.IsTrue((result - expected).TotalSeconds < 1);
        }
        [TestMethod]
        public void TestConstructorMC_Time()
        {
            MC c1 = new MC("GJ24294");

            var expected = c1.Date;

            var result = DateTime.Now;

            //Tester om datoen passer.
            Assert.IsTrue((result - expected).TotalSeconds < 1);
        }
    }
}
