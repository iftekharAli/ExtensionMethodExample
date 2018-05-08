using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodExample
{

         /*
    
           An extension method is a static method of a static class, 
           where the "this" modifier is applied to the first parameter. 
           The type of the first parameter will be the type that is extended.
           Extension methods are only in scope when you explicitly import the namespace into your source code with a using directive.

        */
    public static class ExtensionMethods
    {
        public static string UppercaseFirstLetter(this string value)
        {
            // Uppercase the first letter in the string.
            if (value.Length > 0)
            {
                char[] array = value.ToCharArray();
                array[0] = char.ToUpper(array[0]);
                return new string(array);
            }
            return value;
        }
        public static int MultiplyBy(this int value, int mulitiplier)
        {
            // Uses a second parameter after the instance parameter.
            return value * mulitiplier;
        }
    }

    public class ExtensionMethodsCustom
    {
        public void Test1()
        {
            Console.WriteLine("I am test 1");
        }
        public void Test2()
        {
            Console.WriteLine("I am test 2");
        }
    }
    public static class CustomeExtensionMethodAddNewFunction
    {
        public static void Test3(this ExtensionMethodsCustom obj)
        {
            Console.WriteLine("i am test3");
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            string value = "dot net perls";
            value = value.UppercaseFirstLetter();
            ExtensionMethodsCustom obj = new ExtensionMethodsCustom();
            obj.Test1();
            obj.Test2();
            obj.Test3();
            int a = 10.MultiplyBy(2);
            Console.WriteLine(a);
            Console.ReadKey();

        }
    }

}
