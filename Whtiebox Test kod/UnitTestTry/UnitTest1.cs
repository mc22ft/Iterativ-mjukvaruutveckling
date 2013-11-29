using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTry
{
    [TestClass]
    public class TriagleUnitTest1
    {


        //testa koden alla vilkors satser och konsruktioner
        //test - Analyse code coverage - all test
        //Clicka till vänster om "krysset"
                
        [TestMethod]
        public void isScaleneTest1()    //Inga lika sidor
        {
            //Skickar in tre olika och ska få true tillbaka

            Triangle triangle = new Triangle(2.5, 3.5, 4.5);           
            Assert.IsFalse(triangle.isScalene());
            
            //Returnerar false!
        }

        [TestMethod]
        public void isScaleneTest2()    
        {
            //Skickar in array
            double[] testArray = { 2.5, 2.5, 4.5 };
            Triangle triangle = new Triangle(testArray);
            Assert.IsFalse(triangle.isScalene());

            //Returnerar false!
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
       // [ExpectedException(typeof(ArgumentNullException))]
        public void isEquilateral1()  
        {
            //Skickar array

            Point[] pointArray = { new Point(1, 2), new Point(3, 4), new Point (5, 0) };
            Triangle triangle = new Triangle(pointArray);
            Assert.IsFalse(triangle.isScalene());

            //Returnerar false!
        }

        [TestMethod]
        public void isEquilateral2()   
        {
            //Skickar in array             
            
            Point[] pointArray = { new Point(1, 2), new Point(3, 4), new Point(2, 2)};
            Triangle triangle = new Triangle(pointArray);
            Assert.IsFalse(triangle.isScalene());

            //Returnerar False!
        }

        [TestMethod]
        public void isEquilateral3()   //Liksidig
        {
            //Skickar in liksidig för att få true tillbaka

            Triangle triangle = new Triangle(2.5, 2.5, 2.5);
            Assert.IsTrue(triangle.isScalene());

            //Returnerar true!
        }

        [TestMethod]
        public void isEquilateral4()   //Liksidig
        {
            //Skickar in likbent för att få false tillbaka

            Triangle triangle = new Triangle(2.5, 2.5, 4.5);
            Assert.IsFalse(triangle.isScalene());

            //Returnerar false!
        }

        [TestMethod]
        public void isEquilateral5()   //Liksidig
        {
            //Skickar in olika sidor för att få false tillbaka

            Triangle triangle = new Triangle(2.5, 3.5, 4.5);
            Assert.IsFalse(triangle.isScalene());

            //Returnerar false!
        }



        [TestMethod]
        public void isIsoscelesTest1()   //Likbent
        {
            //Skickar in liksidig för att få false tillbaka

            Triangle triangle = new Triangle(2.5, 2.5, 2.5);
            Assert.IsTrue(triangle.isScalene());

            //Returnerar true!
        }

        [TestMethod]
        public void isIsoscelesTest2()   //Likbent
        {
            //Skickar in likbent för att få true tillbaka

            Triangle triangle = new Triangle(2.5, 2.5, 4.5);
            Assert.IsFalse(triangle.isScalene());

            //Returnerar false!
        }

        [TestMethod]
        public void isIsoscelesTest3()   //Likbent
        {
            //Skickar in olika sidor för att få false tillbaka

            Triangle triangle = new Triangle(2.5, 3.5, 4.5);
            Assert.IsFalse(triangle.isScalene());

            //Returnerar false!
        }
        
    }
}
