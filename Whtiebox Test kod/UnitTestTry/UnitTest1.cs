using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTry
{
    [TestClass]
    public class TriagleUnitTest1
    {

        [TestMethod]
        public void testOfConstructorn()
        {
            Triangle test1 = new Triangle(1.5, 2, 3);
        
        }





        [TestMethod]
        public void isScaleneTest()    //Inga lika sidor
        {
            //Skickar in tre olika och ska få true tillbaka

            Triangle treeSameTri = new Triangle(2.5, 3.5, 4.5);
            Assert.IsFalse(treeSameTri.isScalene());
            Assert.IsTrue(treeSameTri.isScalene());
            Assert.AreSame(treeSameTri.isScalene());

        }

        [TestMethod]

        public void isEquilateral()   //Liksidig
        {
        
        }


        [TestMethod]
        public void isIsoscelesTest()    //Likbent 
        {
            Triangle tri = new Triangle(1.0, 0.5, 1.0);
            Assert.IsTrue(tri.isIsosceles());
        }

        
    }
}
