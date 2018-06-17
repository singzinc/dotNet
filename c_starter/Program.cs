using System;

namespace c_starter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string testString = "this is test";
            Console.WriteLine("this is test....");
            //Console.WriteLine(testString) ;
            Console.WriteLine(testString.IndexOf("is"));
            int fEnd = testString.IndexOf(" is");
            Console.WriteLine(fEnd) ;
            string sub = testString.Substring(0, fEnd);
            Console.WriteLine("this is subString : " + sub);
            // this is comment
            // commit 2
        }

    }
}
