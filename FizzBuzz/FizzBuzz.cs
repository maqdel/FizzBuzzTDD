using System;

namespace FizzBuzzTDD.FizzBuzzLib
{
    public class FizzBuzz
    {
        public List<string> Response = new List<string>();

        public void Run()
        {
            Response = new List<string>();
            for(int i = 1; i <= 100; i++){
                Response.Add(i.ToString());
            }
        }

        public FizzBuzz()
        {
            
        }
    }
}