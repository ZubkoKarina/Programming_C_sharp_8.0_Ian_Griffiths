using System;

public class InitializationTestClass{
        public InitializationTestClass(){
            Console.WriteLine("Constructor");
        }
        static InitializationTestClass(){
            Console.WriteLine("Static constructor");
        }
        public static int s1 = GetValue("Static field 1");
        public int ns1 = GetValue("Non-Static field 1");
        public static int s2 = GetValue("Static field 2");
        public  int ns2 = GetValue("Non-Static field 2");

        private static int GetValue(String message){
            Console.WriteLine(message);
            return 1;
        }

        public static void Foo(){
            Console.WriteLine("Static method");
        }
    }

class Program_3_33{
    static void Main(string[] args){
        Console.WriteLine("Main");
        InitializationTestClass.Foo();
        Console.WriteLine("Constructing 1");
        InitializationTestClass i = new InitializationTestClass();
        Console.WriteLine("Constructing 2");
        i = new InitializationTestClass();
    }
}