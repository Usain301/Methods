using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            add();
            add();
            var result=Add2(20,21);
            int a = 25;

            int number1 = 20;
            int number2 = 100;
            var result2 = Add3(number1 , number2);
            Console.WriteLine(result2);
            Console.WriteLine(number1);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        static void add() {
            Console.WriteLine("Added!");
        }
        public static int Add2(int number1 ,int number2)
        {
            var result = number1 + number2;
           
            return result;

        }
        public static int Add3(int number1,int number2) {
            number1=30;

            return number1+number2;

        

        }
        
        
    }
}
