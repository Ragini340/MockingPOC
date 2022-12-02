using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockingPOC;
using Moq;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod("Check")]
        
        public void TestMethod1()
        {
            Console.WriteLine("I am under TestMethod1");
            Mock<MockingPOC.checkEmployee> chk = new Mock<checkEmployee>();
            
            //TestC.WriteLine("I am in TestMethod1" + chk);
             //Console.WriteLine("Test in Test"+chk);

            checkEmployee check = new checkEmployee();
            //Console.WriteLine("Test in Test real" + check);


            // Console.WriteLine("Test in Test" + chk.checkEmp());

            //Console.WriteLine("I am in TestMethod1");
            chk.Setup(x => x.checkEmp()).Returns(true);

            checkEmployee.processEmployee obje = new checkEmployee.processEmployee();
            Assert.AreEqual(obje.insertEmployee(chk.Object), true);


        }
    }
}
