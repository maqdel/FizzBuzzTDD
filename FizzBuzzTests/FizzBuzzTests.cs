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
        public void get_100_numbers()
        {
            FizzBuzzLib.FizzBuzz fb = new FizzBuzzLib.FizzBuzz();
            fb.Run();            
            Assert.AreEqual(fb.Response.Count, 100);            
        }
    }
}