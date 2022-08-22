using System;

namespace FizzBuzzTDD.FizzBuzzLib
{
    public class FizzBuzz
    {
        public List<string> Serie = new List<string>();

        public string SingleValue;


        private string SetValue(int value){
            string answer = value.ToString();
            if(value % 3 == 0 && value % 5 == 0){
                answer = "FizzBuzz";            
            }else if(value % 3 == 0){
                answer = "Fizz";
                }else if(value % 5 == 0){
                    answer = "Buzz";
                }            
            return answer;
        }

/*         private string SetValue(int value){
            string answer = value.ToString();
            if(value % 3 == 0){
                answer = "Fizz";
            }   
            if(value % 5 == 0){
                answer = "Buzz";
            }
            if(value % 3 == 0 && value % 5 == 0){
                answer = "FizzBuzz";
            }
            return answer;
        } */

/*         private string SetValue(int value){
            string answer = value.ToString();
            if(value % 3 == 0){
                answer = "Fizz";
            }   
            if(value % 5 == 0){
                answer = "Buzz";
            }
            return answer;
        } */

/*         private string SetValue(int value){
            string answer = "";

            if(value % 3 == 0){
                answer = "Fizz";
            }else{
                answer = value.ToString();
            }            
            return answer;
        } */

        public void Run()
        {
            Serie = new List<string>();
            for(int i = 1; i <= 100; i++){
                Serie.Add(SetValue(i));
            }
        }

        public void Run(int value)
        {
            SingleValue = SetValue(value);
        }

        public FizzBuzz()
        {
            
        }
    }
}