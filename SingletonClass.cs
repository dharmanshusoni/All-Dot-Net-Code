using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Singleton
    {
        //static class
        //In C#, one is allowed to create a static class, by using static keyword.
        //A static class can only contain static data members, static methods, and a static constructor.
        //It is not allowed to create objects of the static class.
        //Static classes are sealed, means you cannot inherit a static class from another class.


        // Create a static variable of class and initialise it with a object in a static method
        private static Singleton Instance;
        private Singleton()
        {

        }
        public static Singleton getInstance()
        {
            if (Instance == null)
            {
                Instance = new Singleton();
            }
            return Instance;
        }

        public void Display()
        {
            Console.WriteLine(true);
        }
       
    }
    internal class SingletonClass
    {
        public static void Main1()
        {
            Singleton.getInstance().Display();
            Console.ReadKey();
        }
    }
}
