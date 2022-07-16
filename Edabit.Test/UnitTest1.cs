using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Edabit.Test
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void CupSwagginControlTest()
        {
            Assert.AreEqual(CupSwagginControl.CupSwapping(new String[] { "AB", "CA" }), "C");
            Assert.AreEqual(CupSwagginControl.CupSwapping(new String[] { "AB", "CA", "AB" }), "C");
            Assert.AreEqual(CupSwagginControl.CupSwapping(new String[] { "AC", "CA", "CA", "AC" }), "B");
            Assert.AreEqual(CupSwagginControl.CupSwapping(new String[] { "BA", "AC", "CA", "BC" }), "A");
            Assert.AreEqual(CupSwagginControl.CupSwapping(new String[] { "BC", "CB", "CA", "BA" }), "A");
            Assert.AreEqual(CupSwagginControl.CupSwapping(new String[] { "BC" }), "C");
            Assert.AreEqual(CupSwagginControl.CupSwapping(new String[] { "BA", "CA", "CB", "CA" }), "B");
            Assert.AreEqual(CupSwagginControl.CupSwapping(new String[] { }), "B");

        }

        [TestMethod]
        public void NextPrimeControlTest()
        {
            Assert.AreEqual(NextPrimeControl.NextPrime(12),13);
            Assert.AreEqual(NextPrimeControl.NextPrime(24),29);
            Assert.AreEqual(NextPrimeControl.NextPrime(11),11);
            Assert.AreEqual(NextPrimeControl.NextPrime(13),13);
            Assert.AreEqual(NextPrimeControl.NextPrime(14),17);
            Assert.AreEqual(NextPrimeControl.NextPrime(33),37);
        }




		[DataRow("12/03/2020", "19/03/2020")]
		[DataRow("21/12/1989", "28/12/1989")]
		[DataRow("01/01/2000", "08/01/2000")]
		[DataRow("24/09/1924", "01/10/1924")]
		[DataRow("21/07/1964", "28/07/1964")]
		[DataRow("14/07/2085", "21/07/2085")]
		[DataRow("25/04/1953", "02/05/1953")]
		[DataRow("02/01/2200", "09/01/2200")]
		[DataRow("06/01/2007", "13/01/2007")]
		[DataRow("07/04/2195", "14/04/2195")]
		[DataRow("04/09/2094", "11/09/2094")]
		[DataRow("20/08/1910", "27/08/1910")]
		[DataRow("12/12/1894", "19/12/1894")]
		[DataRow("02/11/2094", "09/11/2094")]
		[DataRow("22/12/1955", "29/12/1955")]
		[DataRow("18/04/1859", "25/04/1859")]
		[DataRow("17/03/1847", "24/03/1847")]
		[DataRow("17/03/2142", "24/03/2142")]
		[DataRow("26/01/2145", "02/02/2145")]
		[DataRow("03/12/1959", "10/12/1959")]
		[DataRow("01/06/1947", "08/06/1947")]
		[DataRow("26/12/1853", "02/01/1854")]
		[DataRow("27/10/2068", "03/11/2068")]
		[DataRow("05/05/2080", "12/05/2080")]
		[DataRow("22/12/2144", "29/12/2144")]
		[DataRow("12/05/1870", "19/05/1870")]
		[DataRow("07/01/1882", "14/01/1882")]
		[DataRow("16/06/2032", "23/06/2032")]
		[DataRow("02/10/2007", "09/10/2007")]
		[DataRow("24/03/1871", "31/03/1871")]
		[DataRow("19/08/1847", "26/08/1847")]
		[DataRow("24/07/2157", "31/07/2157")]
		[DataRow("28/12/1848", "04/01/1849")]
		[DataRow("20/07/1951", "27/07/1951")]
		[DataRow("14/11/2071", "21/11/2071")]
		[DataRow("07/12/2170", "14/12/2170")]
		[DataRow("01/03/2080", "08/03/2080")]
		[DataRow("28/04/1906", "05/05/1906")]
		[DataRow("15/06/2023", "22/06/2023")]
		[DataRow("11/08/1950", "18/08/1950")]
		[DataRow("15/11/2103", "22/11/2103")]
		[DataRow("23/11/1852", "30/11/1852")]
		[DataRow("08/01/1928", "15/01/1928")]
		[DataRow("14/11/2118", "21/11/2118")]
		[DataRow("11/10/2096", "18/10/2096")]
		[DataRow("02/12/1816", "09/12/1816")]
		[DataRow("10/10/1937", "17/10/1937")]
		[DataRow("28/11/1959", "05/12/1959")]
		[DataRow("27/05/2133", "03/06/2133")]
		[DataRow("28/04/1932", "05/05/1932")]
		[DataRow("23/02/2050", "02/03/2050")]
		[DataRow("23/05/2146", "30/05/2146")]
		[DataRow("24/07/2167", "31/07/2167")]
        [TestMethod]
        public void WeekAfterControlTest(string input,string expected)
        {
			//var result = WeekAfterControl.WeekAfter(input);

			//Assert.AreEqual(expected));
        }


		[TestMethod]
		public void DrivingLicenseControlTest()
		{
			Assert.AreEqual(DrivingLicenseControl.License("Zebediah", 1, "Bob Jim Becky Pat"), 100);
			Assert.AreEqual(DrivingLicenseControl.License("Eric", 2, "Adam Caroline Rebecca Frank"), 40);
			Assert.AreEqual(DrivingLicenseControl.License("Aaron", 3, "Jane Max Olivia Sam"), 20);
		}

		[TestMethod]
		public void TracktheRobotTest()
		{
			Assert.AreEqual(TracktheRobot.TrackRobot("..<.<."), new int[] { 1, 1 });
			Assert.AreEqual(TracktheRobot.TrackRobot("....................................................................................................") , new int[] { 100, 0 });
			Assert.AreEqual(TracktheRobot.TrackRobot("<>>>><><<<><>>>><><<<><>>><>"), new int[] { 0, 0 });
			Assert.AreEqual(TracktheRobot.TrackRobot(".<..<...<....<.....<......"), new int[] { 3, 4 });
			Assert.AreEqual(TracktheRobot.TrackRobot(">>.."), new int[] { -2, 0 });
			Assert.AreEqual(TracktheRobot.TrackRobot("..<<..>>..<<..>>.."), new int[] { 2, 0 });
		}


		




	}
}