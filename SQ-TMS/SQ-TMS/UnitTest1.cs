using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SQ_TMS;

namespace UnitTestProject_TMS
{
    //===================================================================================================================
    /// \class UnitTest1
    ///
    /// \brief The purpose of this class is have unit tests for the various classes
    /// \details <b>Details</b>
    ///
    /// UnitTest1 holds all of the unit tests within the project.
    ///
    /// \author BNSM <i>Transportation Management System Experts</i>
    //===================================================================================================================
    [TestClass]
    public class UnitTest1
    {
        ///==============================================================================================================
        /// \brief To test Admin Methods
        /// \details <b>Details</b>
        ///
        /// Unit test for happy path Admin method UpdateAdminInfo. This unit test creats a an object of type Admin
        /// and then passes that object, along with the new Admin ID, into the method UpdateAdminID. This method
        /// will return a false if the id of the object was not updated, or true, if the object id was updated.
        /// This test sends information and the test should succeed if the Assert.AreEqual succeeds.
        ///
        /// \return no return
        ///==============================================================================================================
        [TestMethod]
        public void TestMethod1()
        {
            Admin Jason = new Admin(1224, "Jason", "Fischer");
            bool changed = Jason.UpdateAdminID(Jason, 2345);
            Assert.AreEqual(true, changed);
        }

        ///==============================================================================================================
        /// \brief To test Admin Methods
        /// \details <b>Details</b>
        ///
        /// Unit test for exceptional test for Admin method UpdateAdminInfo. This unit test creats a an object of type Admin
        /// and then passes that object, along with the new Admin ID, into the method UpdateAdminID. This method
        /// will return a false if the id of the object was not updated, or true, if the object id was updated.
        /// This test sends information and the test should succeed if the Assert.AreEqual succeeds.
        ///
        /// \return no return
        ///==============================================================================================================
        [TestMethod]
        public void TestMethod2()
        {
            Admin admin2 = new Admin(7224, "Blake", "Roon");
            bool changed = admin2.UpdateAdminID(admin2, 0);
            Assert.AreEqual(false, changed);
        }

        ///==============================================================================================================
        /// \brief To test Admin Methods
        /// \details <b>Details</b>
        ///
        /// Unit test for exceptional test for Admin method UpdateAdminInfo. This unit test creats a an object of type Admin
        /// and then passes that object, along with the new Admin ID, into the method UpdateAdminID. This method
        /// will return a false if the id of the object was not updated, or true, if the object id was updated.
        /// This test sends information and the test should succeed if the Assert.AreEqual succeeds.
        ///
        /// \return no return
        ///==============================================================================================================
        [TestMethod]
        public void TestMethod3()
        {
            Admin admin3 = new Admin(0224, "Alexander", "Dolkaner");
            bool changed = admin3.UpdateAdminID(admin3, 0);
            Assert.AreEqual(false, changed);
        }

        ///==============================================================================================================
        /// \brief To test Admin Methods
        /// \details <b>Details</b>
        ///
        /// Unit test for happy path for Admin method UpdateAdminInfo. This unit test creats a an object of type Admin
        /// and then passes that object, along with the new Admin ID, into the method UpdateAdminID. This method
        /// will return a false if the id of the object was not updated, or true, if the object id was updated.
        /// This test sends information and the test should succeed if the Assert.AreEqual succeeds.
        ///
        /// \return no return
        ///==============================================================================================================
        [TestMethod]
        public void TestMethod4()
        {
            Admin admin4 = new Admin(0001, "Sydney", "Ali");
            bool changed = admin4.UpdateAdminID(admin4, 44);
            Assert.AreEqual(true, changed);
        }

        //=============================================================================================================

        ///==============================================================================================================
        /// \brief To test Planner Methods
        /// \details <b>Details</b>
        ///
        /// Unit test for happy path planner method UpdatePlannerInfo. This unit test creats a an object of type Planner
        /// and then passes that object, along with the new Planner ID, into the method UpdatePlannerID. This method
        /// will return a false if the id of the object was not updated, or true, if the object id was updated.
        /// This test sends information and the test should succeed if the Assert.AreEqual succeeds.
        ///
        /// \return no return
        ///==============================================================================================================
        [TestMethod]
        public void TestMethod5()
        {
            Planner planner1 = new Planner(1224, "Jason", "Fischer", "N/A");
            bool changed = planner1.UpdatePlannerID(planner1, 2345);
            Assert.AreEqual(true, changed);
        }

        ///==============================================================================================================
        /// \brief To test Planner Methods
        /// \details <b>Details</b>
        ///
        /// Unit test for Exceptional path planner method UpdatePlannerInfo. This unit test creats a an object of type Planner
        /// and then passes that object, along with the new Planner ID, into the method UpdatePlannerID. This method
        /// will return a false if the id of the object was not updated, or true, if the object id was updated.
        /// This test sends information and the test should succeed if the Assert.AreEqual succeeds.
        ///
        /// \return no return
        ///==============================================================================================================
        [TestMethod]
        public void TestMethod6()
        {
            Planner planner1 = new Planner(1224, "Jason", "Fischer", "N/A");
            bool changed = planner1.UpdatePlannerID(planner1, 0);
            Assert.AreEqual(false, changed);
        }

        ///==============================================================================================================
        /// \brief To test Planner Methods
        /// \details <b>Details</b>
        ///
        /// Unit test for Exceptional path planner method UpdatePlannerInfo. This unit test creats a an object of type Planner
        /// and then passes that object, along with the new Planner ID, into the method UpdatePlannerID. This method
        /// will return a false if the id of the object was not updated, or true, if the object id was updated.
        /// This test sends information and the test should succeed if the Assert.AreEqual succeeds.
        ///
        /// \return no return
        ///==============================================================================================================
        [TestMethod]
        public void TestMethod7()
        {
            Planner planner1 = new Planner(67224, "Hellen", "April", "Applicable");
            bool changed = planner1.UpdatePlannerID(planner1, -20);
            Assert.AreEqual(false, changed);
        }

        ///==============================================================================================================
        /// \brief To test Planner Methods
        /// \details <b>Details</b>
        ///
        /// Unit test for Happy path planner method UpdatePlannerInfo. This unit test creats a an object of type Planner
        /// and then passes that object, along with the new Planner ID, into the method UpdatePlannerID. This method
        /// will return a false if the id of the object was not updated, or true, if the object id was updated.
        /// This test sends information and the test should succeed if the Assert.AreEqual succeeds.
        ///
        /// \return no return
        ///==============================================================================================================
        [TestMethod]
        public void TestMethod8()
        {
            Planner planner4 = new Planner(44484, "Apru", "Hotaka-Zin", "N/A");
            bool changed = planner4.UpdatePlannerID(planner4, 2891);
            Assert.AreEqual(true, changed);
        }

        //=============================================================================================================

        ///==============================================================================================================
        /// \brief To test buyer Methods
        /// \details <b>Details</b>
        ///
        /// Unit test for Happy path Buyer method UpdateBuyerInfo. This unit test creats a an object of type Buyer
        /// and then passes that object, along with the new Buyer ID, into the method UpdateBuyerID. This method
        /// will return a false if the id of the object was not updated, or true, if the object id was updated.
        /// This test sends information and the test should succeed if the Assert.AreEqual succeeds.
        ///
        /// \return no return
        ///==============================================================================================================
        [TestMethod]
        public void TestMethod9()
        {
            Buyer buyer = new Buyer(7724, "Jason", "Fischer", "buerMan@gamil.com", "519-892-7432");
            bool changed = buyer.UpdateBuyerID(buyer, 234993);
            Assert.AreEqual(true, changed);
        }

        ///==============================================================================================================
        /// \brief To test buyer Methods
        /// \details <b>Details</b>
        ///
        /// Unit test for exceptional path Buyer method UpdateBuyerInfo. This unit test creats a an object of type Buyer
        /// and then passes that object, along with the new Buyer ID, into the method UpdateBuyerID. This method
        /// will return a false if the id of the object was not updated, or true, if the object id was updated.
        /// This test sends information and the test should succeed if the Assert.AreEqual succeeds.
        ///
        /// \return no return
        ///==============================================================================================================
        [TestMethod]
        public void TestMethod10()
        {
            Buyer buyer = new Buyer(54224, "Jason-Al", "Cher", "buerMan@gamil.com", "519-892-7432");
            bool changed = buyer.UpdateBuyerID(buyer, 0);
            Assert.AreEqual(false, changed);
        }

        ///==============================================================================================================
        /// \brief To test buyer Methods
        /// \details <b>Details</b>
        ///
        /// Unit test for Happy path Buyer method UpdateBuyerInfo. This unit test creats a an object of type Buyer
        /// and then passes that object, along with the new Buyer ID, into the method UpdateBuyerID. This method
        /// will return a false if the id of the object was not updated, or true, if the object id was updated.
        /// This test sends information and the test should succeed if the Assert.AreEqual succeeds.
        ///
        /// \return no return
        ///==============================================================================================================
        [TestMethod]
        public void TestMethod11()
        {
            Buyer buyer = new Buyer(13524, "Huient", "Otaku-Kin", "bueran@hotmail.com", "519-892-7432");
            bool changed = buyer.UpdateBuyerID(buyer, 233);
            Assert.AreEqual(true, changed);
        }

        ///==============================================================================================================
        /// \brief To test buyer Methods
        /// \details <b>Details</b>
        ///
        /// Unit test for Happy path Buyer method UpdateBuyerInfo. This unit test creats a an object of type Buyer
        /// and then passes that object, along with the new Buyer ID, into the method UpdateBuyerID. This method
        /// will return a false if the id of the object was not updated, or true, if the object id was updated.
        /// This test sends information and the test should succeed if the Assert.AreEqual succeeds.
        ///
        /// \return no return
        ///==============================================================================================================
        [TestMethod]
        public void TestMethod12()
        {
            Buyer buyer = new Buyer(19564, "Quada", "Fischer", "buerMan@gamil.com", "519-892-7432");
            bool changed = buyer.UpdateBuyerID(buyer, -21);
            Assert.AreEqual(false, changed);
        }

        //==============================================================================================================
        
        //=============================================================================================================
        /// \brief To test shipments Methods
        /// \details <b>Details</b>
        ///
        /// Unit test for Happy path Shipments method UpdateShipmentsInfo. This unit test creats a an object of type Shipment
        /// and then passes that object, along with the new Shipment ID, into the method UpdateShipmentID. This method
        /// will return a false if the id of the object was not updated, or true, if the object id was updated.
        /// This test sends information and the test should succeed if the Assert.AreEqual succeeds.
        ///
        /// \return no return
        ///==============================================================================================================
        [TestMethod]
        public void TestMethod13()
        {
            Shipments test = new Shipments(7368);
            bool changed = test.UpdateShipmentsID(test, 234993);
            Assert.AreEqual(true, changed);
        }

        ///==============================================================================================================
        /// \brief To test shipments Methods
        /// \details <b>Details</b>
        ///
        /// Unit test for Happy path Shipments method UpdateShipmentsInfo. This unit test creats a an object of type Shipment
        /// and then passes that object, along with the new Shipment ID, into the method UpdateShipmentID. This method
        /// will return a false if the id of the object was not updated, or true, if the object id was updated.
        /// This test sends information and the test should succeed if the Assert.AreEqual succeeds.
        ///
        /// \return no return
        ///==============================================================================================================
        [TestMethod]
        public void TestMethod14()
        {
            Shipments test = new Shipments(78);
            bool changed = test.UpdateShipmentsID(test, 3);
            Assert.AreEqual(true, changed);
        }
        ///==============================================================================================================
        /// \brief To test shipments Methods
        /// \details <b>Details</b>
        ///
        /// Unit test for Exceptional path Shipments method UpdateShipmentsInfo. This unit test creats a an object of type Shipment
        /// and then passes that object, along with the new Shipment ID, into the method UpdateShipmentID. This method
        /// will return a false if the id of the object was not updated, or true, if the object id was updated.
        /// This test sends information and the test should succeed if the Assert.AreEqual succeeds.
        ///
        /// \return no return
        ///==============================================================================================================
        [TestMethod]
        public void TestMethod15()
        {
            Shipments test = new Shipments(1776);
            bool changed = test.UpdateShipmentsID(test, 0);
            Assert.AreEqual(false, changed);
        }

        ///==============================================================================================================
        /// \brief To test shipments Methods
        /// \details <b>Details</b>
        ///
        /// Unit test for Exceptional path Shipments method UpdateShipmentsInfo. This unit test creats a an object of type Shipment
        /// and then passes that object, along with the new Shipment ID, into the method UpdateShipmentID. This method
        /// will return a false if the id of the object was not updated, or true, if the object id was updated.
        /// This test sends information and the test should succeed if the Assert.AreEqual succeeds.
        ///
        /// \return no return
        ///==============================================================================================================
        [TestMethod]
        public void TestMethod16()
        {
            Shipments test = new Shipments(1945);
            bool changed = test.UpdateShipmentsID(test, -23);
            Assert.AreEqual(false, changed);
        }

        //=============================================================================================================

        ///==============================================================================================================
        /// \brief To test Admin Methods
        /// \details <b>Details</b>
        ///
        /// Unit test for Exceptional path Admin method UpdateFirstName. This unit test creats a an object of type Admin
        /// and then passes that object, along with the new Admin Name, into the method UpdateFirstName. This method
        /// will return a false if the id of the object was not updated, or true, if the object id was updated.
        /// This test sends information and the test should succeed if the Assert.AreEqual succeeds.
        ///
        /// \return no return
        ///==============================================================================================================
        public void TestMethod17()
        {
            Admin admin4 = null;
            bool changed = admin4.UpdateFirstName(admin4, "Rachel");
            Assert.AreEqual(false, changed);
        }
        ///==============================================================================================================
        /// \brief To test Admin Methods
        /// \details <b>Details</b>
        ///
        /// Unit test for Happy path Admin method UpdateFirstName. This unit test creats a an object of type Admin
        /// and then passes that object, along with the new Admin Name, into the method UpdateFirstName. This method
        /// will return a false if the id of the object was not updated, or true, if the object id was updated.
        /// This test sends information and the test should succeed if the Assert.AreEqual succeeds.
        ///
        /// \return no return
        ///==============================================================================================================
        [TestMethod]
        public void TestMethod18()
        {
            Admin admin4 = new Admin(0001, "Quanda", "Ali");
            bool changed = admin4.UpdateFirstName(admin4, "Rachel");
            Assert.AreEqual(true, changed);
        }
    }
}
