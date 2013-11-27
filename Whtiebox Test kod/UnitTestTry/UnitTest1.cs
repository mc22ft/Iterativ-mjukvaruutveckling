using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTry
{
    [TestClass]
    public class TriagleUnitTest1
    {
        /*
        [TestMethod]
        public void testOfConstructorn()
        {
            Triangle test1 = new Triangle(1.5, 2, 3);
        
        }
        */

        [TestMethod]
        public void isScaleneTest1()    //Inga lika sidor
        {
            //Skickar in tre olika och ska få true tillbaka

            Triangle triangle = new Triangle(2.5, 3.5, 4.5);           
            Assert.IsFalse(triangle.isScalene());
            
            //Returnerar false!
        }

        [TestMethod]
        public void isScaleneTest2()    //Inga lika sidor
        {
            //Skickar in likbent för att få false tillbaka

            Triangle triangle = new Triangle(2.5, 2.5, 4.5);
            Assert.IsFalse(triangle.isScalene());

            //Returnerar true!
        }

        [TestMethod]
        public void isScaleneTest3()    //Inga lika sidor
        {
            //Skickar in liksidig för att få false tillbaka

            Triangle triangle = new Triangle(2.5, 2.5, 2.5);
            Assert.IsTrue(triangle.isScalene());

            //Returnerar true!
        }



        [TestMethod]
        public void isEquilateral1()   //Liksidig
        {
            //Skickar in liksidig för att få true tillbaka

            Triangle triangle = new Triangle(2.5, 2.5, 2.5);
            Assert.IsTrue(triangle.isScalene());

            //Returnerar true!
        }

        [TestMethod]
        public void isEquilateral2()   //Liksidig
        {
            //Skickar in likbent för att få false tillbaka

            Triangle triangle = new Triangle(2.5, 2.5, 4.5);
            Assert.IsFalse(triangle.isScalene());

            //Returnerar false!
        }

        [TestMethod]
        public void isEquilateral3()   //Liksidig
        {
            //Skickar in olika sidor för att få false tillbaka

            Triangle triangle = new Triangle(2.5, 3.5, 4.5);
            Assert.IsFalse(triangle.isScalene());

            //Returnerar false!
        }



        
    }
}
