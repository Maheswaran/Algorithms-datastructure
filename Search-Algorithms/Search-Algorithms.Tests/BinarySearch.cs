using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Binary_Search.Tests
{
    [TestClass]
    public class BinarySearchTest
    {

        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [TestMethod]                
        public void TestSearchMethod_1()
        {
            BinarySearch srch = new BinarySearch();
            int indexPos = srch.Search(new int[] { 23, 44, 56, 78, 98, 13, 67 }, 56);
            Assert.AreEqual(indexPos, 4);
        }

        [TestMethod]
        public void TestSearchMethod_2()
        {
            BinarySearch srch = new BinarySearch();
            int indexPos = srch.Search(new int[] { 23, 44, 56, 78, 98, 13, 67 }, 13);
            Assert.AreEqual(indexPos, 1);            
        }

        [TestMethod]
        public void TestSearchMethod_3()
        {
            BinarySearch srch = new BinarySearch();
            int indexPos = srch.Search(new int[] { 23, 44, 56, 78, 98, 13, 67 }, 78);
            Assert.AreEqual(indexPos, 6);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "TextFile1.CSV", "TextFile1#CSV", DataAccessMethod.Sequential)]
        [TestMethod]        
        public void TestSearchMethod_DDT_usingtxtfile_csv()
        {
            BinarySearch srch = new BinarySearch();
            string[] x = TestContext.DataRow["ArrayElements"].ToString().Split(';');
            int[] y = Array.ConvertAll(x, temparr => Convert.ToInt32(temparr));
            int elementTobeFound = Convert.ToInt32(TestContext.DataRow["ElementTobeFound"].ToString());
            int elementPostion = Convert.ToInt32(TestContext.DataRow["elementposition"].ToString());            
            Assert.AreEqual(srch.Search(y, elementTobeFound), elementPostion);
        }


        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "TestCasesInputDataxml.xml", "TestInput_method3", DataAccessMethod.Sequential)]
        [TestMethod]        
        public void TestSearchMethod_DDT_UsingXML()
        {
            BinarySearch srch = new BinarySearch();
            string[] x = TestContext.DataRow["ArrayElements"].ToString().Split(';');
            int[] y = Array.ConvertAll(x, temparr => Convert.ToInt32(temparr));
            int elementTobeFound = Convert.ToInt32(TestContext.DataRow["ElementTobeFound"].ToString());
            int elementPostion = Convert.ToInt32(TestContext.DataRow["elementposition"].ToString());
            Assert.AreEqual(srch.Search(y, elementTobeFound), elementPostion);
        }


        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "TextFile2.CSV", "TextFile2#CSV", DataAccessMethod.Sequential)]
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestSearchMethod_DDT_usingtxtfile_csv2()
        {
            BinarySearch srch = new BinarySearch();
            string[] x = TestContext.DataRow["ArrayElements"].ToString().Split(';');
            int[] y = Array.ConvertAll(x, temparr => Convert.ToInt32(temparr));
            int elementTobeFound = Convert.ToInt32(TestContext.DataRow["ElementTobeFound"].ToString());
            int elementPostion = Convert.ToInt32(TestContext.DataRow["elementposition"].ToString());
            Assert.AreEqual(srch.Search(y, elementTobeFound), elementPostion);
        }
    }
}
