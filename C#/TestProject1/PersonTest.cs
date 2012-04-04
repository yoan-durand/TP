using ConsoleApplicationTestUnitaire.BusinessManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApplicationTestUnitaire.DBO;
using ConsoleApplicationTestUnitaire.DataAccess;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for PersonTest and is intended
    ///to contain all PersonTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PersonTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Person Constructor
        ///</summary>
        [TestMethod()]
        public void PersonConstructorTest2()
        {
            ConsoleApplicationTestUnitaire.DBO.Person target = new ConsoleApplicationTestUnitaire.DBO.Person();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Address
        ///</summary>
        [TestMethod()]
        public void AddressTest()
        {
            ConsoleApplicationTestUnitaire.DBO.Person target = new ConsoleApplicationTestUnitaire.DBO.Person(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Address = "kremlin bicetre";
            actual = target.Address;
            Assert.AreEqual("kremlin bicetre", actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Firstname
        ///</summary>
        [TestMethod()]
        public void FirstnameTest()
        {
            ConsoleApplicationTestUnitaire.DBO.Person target = new ConsoleApplicationTestUnitaire.DBO.Person(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Firstname = "yoan";
            actual = target.Firstname;
            Assert.AreEqual("yoan", actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Function
        ///</summary>
        [TestMethod()]
        public void FunctionTest()
        {
            ConsoleApplicationTestUnitaire.DBO.Person target = new ConsoleApplicationTestUnitaire.DBO.Person(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Function = "etudiant";
            actual = target.Function;
            Assert.AreEqual("etudiant", actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Name
        ///</summary>
        [TestMethod()]
        public void NameTest()
        {
            ConsoleApplicationTestUnitaire.DBO.Person target = new ConsoleApplicationTestUnitaire.DBO.Person(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Name = "durand";
            actual = target.Name;
            Assert.AreEqual("durand", actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Person Constructor
        ///</summary>
        [TestMethod()]
        public void PersonConstructorTest1()
        {
           ConsoleApplicationTestUnitaire.DBO.Person target = new ConsoleApplicationTestUnitaire.DBO.Person();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for GetPerson
        ///</summary>
        [TestMethod()]
        public void GetPersonTest1()
        {
            int id = 0; // TODO: Initialize to an appropriate value
            ConsoleApplicationTestUnitaire.BusinessManagement.Person expected = new ConsoleApplicationTestUnitaire.BusinessManagement.Person();// TODO: Initialize to an appropriate value
            ConsoleApplicationTestUnitaire.DBO.Person actual;
            actual = ConsoleApplicationTestUnitaire.BusinessManagement.Person.GetPerson(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SavePerson
        ///</summary>
        [TestMethod()]
        public void SavePersonTest1()
        {
            ConsoleApplicationTestUnitaire.DBO.Person person = new ConsoleApplicationTestUnitaire.DBO.Person (); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = ConsoleApplicationTestUnitaire.BusinessManagement.Person.SavePerson(person);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Person Constructor
        ///</summary>
        [TestMethod()]
        public void PersonConstructorTest()
        {
            ConsoleApplicationTestUnitaire.DataAccess.Person target = new ConsoleApplicationTestUnitaire.DataAccess.Person();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for GetPerson
        ///</summary>
        [TestMethod()]
        public void GetPersonTest()
        {
            int id = 0; // TODO: Initialize to an appropriate value
            ConsoleApplicationTestUnitaire.DBO.Person expected = new ConsoleApplicationTestUnitaire.DBO.Person (); // TODO: Initialize to an appropriate value
            ConsoleApplicationTestUnitaire.DBO.Person actual;
            actual = ConsoleApplicationTestUnitaire.DataAccess.Person.GetPerson(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SavePerson
        ///</summary>
        [TestMethod()]
        public void SavePersonTest()
        {
            ConsoleApplicationTestUnitaire.DBO.Person pers = new ConsoleApplicationTestUnitaire.DBO.Person(); ; // TODO: Initialize to an appropriate value
            bool expected =false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = ConsoleApplicationTestUnitaire.DataAccess.Person.SavePerson(pers);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
