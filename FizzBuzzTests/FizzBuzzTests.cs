using System;
using FizzBuzzTDD.FizzBuzzLib;

//FizzBuzz
//
//1 get the firts 100 numbers
//2 if is divided by 3 change for Fizz
//3 if is divided by 5 change for Buzz
//4 if is divided by 3 and 5 change for FizzBuzz
//

namespace FizzBuzzTDD.FizzBuzzTests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void evaluate_fizzbuzz()
        {
            FizzBuzzLib.FizzBuzz fb = new FizzBuzzLib.FizzBuzz();
            fb.Run();            
            Assert.AreEqual(fb.Serie.Count, 100);
            Assert.AreEqual(fb.Serie[0], "1");
            Assert.AreEqual(fb.Serie[2], "Fizz");
            Assert.AreEqual(fb.Serie[4], "Buzz");
            Assert.AreEqual(fb.Serie[14], "FizzBuzz");
            Assert.AreEqual(fb.Serie[98], "Fizz");
            Assert.AreEqual(fb.Serie[99], "Buzz");
        }

        [TestMethod]
        public void evaluate_any()
        {
            FizzBuzzLib.FizzBuzz fb = new FizzBuzzLib.FizzBuzz();
            fb.Run(1);                     
            Assert.AreEqual(fb.SingleValue, "1");
        } 

        [TestMethod]
        public void evaluate_1095()
        {
            FizzBuzzLib.FizzBuzz fb = new FizzBuzzLib.FizzBuzz();
            fb.Run(1095);         
            Assert.AreEqual(fb.SingleValue, "FizzBuzz");
        }
    }
}