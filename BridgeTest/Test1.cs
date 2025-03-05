using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Bridge;
using StoreBaeltTicketLibrary;
using Microsoft.Testing.Platform.MSBuild;
using Oresundbron;

namespace BridgeTest
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod_PriceCar()
        {
            Car car1 = new Car("XK72828", false);

            var expectedprice = car1.Price();

            double result = 230;

            Assert.IsTrue(expectedprice == result);
        }
        [TestMethod]
        public void TestMethod_ReturnStringCar()
        {
            Car c1 = new Car("FJ46726", false);

            string iscar = "Car";

            var expected = c1.VehicleType();

            Assert.IsTrue(expected == iscar);
        }
        [TestMethod]
        public void TestMethod_PriceMC()
        {
            MC m = new MC("TJ47283", false);

            double expectedprice = 120;

            var actualprice = m.Price();

            Assert.IsTrue(expectedprice == actualprice);
        }
        [TestMethod]
        public void TestMethod_ReturnStringMC()
        {
            MC m = new MC("TJ47283", false);

            string expectedprice = "Motorcycle";

            var actualprice = m.VehicleType();

            Assert.IsTrue(expectedprice == actualprice);
        }
        [DataRow("XJ43432")]
        [TestMethod]
        public void TestConstructorCar(string licensplate)
        {
            Car c1 = new Car(licensplate, false);

            string expected = c1.LicensPlate;

            string result = "XJ43432";

            Assert.AreEqual(expected, result);
        }
        [DataRow("XJ43432")]
        [TestMethod]
        public void TestConstructorMC(string licensplate)
        {
            MC c1 = new MC(licensplate, false);

            string expected = c1.LicensPlate;

            string result = "XJ43432";

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestConstructorCar_DateOnly()
        {
            Car c1 = new Car("GJ24294", false);

            var expected = c1.Date;

            var result = DateTime.Now;

            //Tester om datoen passer.
            Assert.IsTrue((result - expected).TotalSeconds < 1);
        }
        [TestMethod]
        public void TestConstructorMC_DateOnly()
        {
            MC c1 = new MC("GJ24294", false);

            var expected = c1.Date;

            var result = DateTime.Now;

            //Tester om datoen passer. Er true hvis forskellen i sekunder er mindre en 1.
            Assert.IsTrue((result - expected).TotalSeconds < 1);
        }
        [TestMethod]
        public void TestConstructorCar_Time()
        {
            Car c1 = new Car("GJ24294", false);

            var expected = c1.Date;

            var result = DateTime.Now;

            //Tester om datoen passer.
            Assert.IsTrue((result - expected).TotalSeconds < 1);
        }
        [TestMethod]
        public void TestConstructorMC_Time()
        {
            MC c1 = new MC("GJ24294", false);

            var expected = c1.Date;

            var result = DateTime.Now;

            //Tester om datoen passer.
            Assert.IsTrue((result - expected).TotalSeconds < 1);
        }
        [TestMethod]
        public void TestBroBizzCar()
        {
            Car c1 = new Car("LS85948", true);

            StoreBaeltTicket sto = new StoreBaeltTicket(c1);

            double expected = 207.0;

            double result = sto.StoreBaeltCar(c1);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestBroBizzMc()
        {
            MC c1 = new MC("LS85948", true);

            StoreBaeltTicket sto = new StoreBaeltTicket(c1);

            double expected = 108;

            double result = sto.StoreBaeltMC(c1);
            //Forskel på de to expected og result må maks være fem. Delta er maks "Difference" between
            Assert.AreEqual(expected, result, 2);
        }
        [TestMethod]
        public void TestMethodPriceWithWeekendNoBrobizz()
        {
            Car c1 = new Car("FG85475", false);

            c1.Date = new DateTime(2025, 3, 1);

            StoreBaeltTicket sto = new StoreBaeltTicket(c1);

            double result = sto.StoreBaeltCar(c1);

            double expectedprice = 195.5;

            Assert.AreEqual(result, expectedprice);
        }
        [TestMethod]
        public void TestMethodPriceWithWeekendWithBrobizz()
        {
            Car c1 = new Car("FG85475", true);

            c1.Date = new DateTime(2025, 3, 1);

            StoreBaeltTicket sto = new StoreBaeltTicket(c1);

            double result = sto.StoreBaeltCar(c1);

            double expectedprice = 175.95;

            //Forskellen må maks være 0.1kr.
            Assert.AreEqual(expectedprice, result, 0.1d);
        }
        [TestMethod]
        public void TestMethodPriceWithoutWeekendAndBroBizz()
        {
            Car c1 = new Car("FG85475", false);

            StoreBaeltTicket sto = new StoreBaeltTicket(c1);

            double result = sto.StoreBaeltCar(c1);

            double expectedprice = 230.0;

            Assert.AreEqual(result, expectedprice);
        }
        [TestMethod]
        public void TestMethodDayofWeekOutcome()
        {
            Car c1 = new Car("FJ28384", false);

            DayOfWeek resultday = c1.Date.DayOfWeek;

            DayOfWeek expectedday = DayOfWeek.Wednesday;

            Assert.AreEqual(expectedday, resultday);
        }
        [TestMethod]
        public void TestOresundVehiclesCarPriceNoBroBizz()
        {
            OresundCar car = new OresundCar("TY39484", false);

            double expectedprice = 460.0;

            double result = car.Price();

            Assert.AreEqual(expectedprice, result);
        }
        [TestMethod]
        public void TestOresundVehiclesMCPriceNoBroBizz()
        {
            OresundMC mc = new OresundMC("TY39434", false);

            double expectedprice = 235;

            double result = mc.Price();

            Assert.AreEqual(expectedprice, result);
        }
        [TestMethod]
        public void TestOresundVehiclesCarPriceWithBroBizz()
        {
            OresundCar car = new OresundCar("TY39484", true);

            double expectedprice = 178.0;

            double result = car.Price();

            Assert.AreEqual(expectedprice, result);
        }
        [TestMethod]
        public void TestOresundVehiclesMCPriceWithBroBizz()
        {
            OresundMC mc = new OresundMC("TY39434", true);

            double expectedprice = 92.0;

            double result = mc.Price();

            Assert.AreEqual(expectedprice, result);
        }
        [TestMethod]
        public void WhatTypeOfOresundVehicleCar()
        {
            OresundCar car = new OresundCar("TK28383", false);

            string expectedstring = "Oresund car";

            string result = car.VehicleType();

            Assert.AreEqual(expectedstring, result);
        }
        [TestMethod]
        public void WhatTypeOfOresundVehicleMC()
        {
            OresundMC mc = new OresundMC("TJ29838", false);

            string expectedstring = "Oresund MC";

            string result = mc.VehicleType();

            Assert.AreEqual(expectedstring, result);
        }
        [TestMethod]
        public void AddingTicketTolist()
        {
            StorebaeltRepository repo = new StorebaeltRepository();

            Car c1 = new Car("TU28483", false);
            Car c2 = new Car("TT28483", false);
            Car c3 = new Car("RU28483", false);
            MC mc1 = new MC("FK29484", false);
            MC mc2 = new MC("UK29484", false);
            MC mc3 = new MC("LK29484", false);

            StoreBaeltTicket ticket1 = new StoreBaeltTicket(c1);
            StoreBaeltTicket ticket2 = new StoreBaeltTicket(c2);
            StoreBaeltTicket ticket3 = new StoreBaeltTicket(c3);
            StoreBaeltTicket ticket4 = new StoreBaeltTicket(mc1);

            repo.AddTicket(ticket1);
            repo.AddTicket(ticket2);
            repo.AddTicket(ticket3);
            repo.AddTicket(ticket4);

            int expectednumberofticket = 4;

            int result = repo.TicketInList();

            Assert.AreEqual(expectednumberofticket, result);
        }
        [TestMethod]
        public void TestOMethodAllTicketForLicensPlate()
        {
            MC mc3 = new MC("LK29484", false);
            StorebaeltRepository repo = new StorebaeltRepository();
            StoreBaeltTicket ticket1 = new StoreBaeltTicket(mc3);
            StoreBaeltTicket ticket2 = new StoreBaeltTicket(mc3);
            StoreBaeltTicket ticket3 = new StoreBaeltTicket(mc3);
            StoreBaeltTicket ticket4 = new StoreBaeltTicket(mc3);

            var result = repo.AllTicketForLicensPlate(mc3.LicensPlate);

            var expected = repo.AllTicketForLicensPlate(mc3.LicensPlate);

            CollectionAssert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestAllTicketMethod()
        {
            MC mc3 = new MC("LK29484", false);
            StorebaeltRepository repo = new StorebaeltRepository();
            StoreBaeltTicket ticket1 = new StoreBaeltTicket(mc3);
            StoreBaeltTicket ticket2 = new StoreBaeltTicket(mc3);
            StoreBaeltTicket ticket3 = new StoreBaeltTicket(mc3);
            StoreBaeltTicket ticket4 = new StoreBaeltTicket(mc3);

            repo.AddTicket(ticket4);
            repo.AddTicket(ticket3);
            repo.AddTicket(ticket2);
            repo.AddTicket(ticket1);

            int result = repo.AllTickets().Count();

            int expectednumberinlist = 4;

            Assert.AreEqual(expectednumberinlist, result);
        }
    }
}
