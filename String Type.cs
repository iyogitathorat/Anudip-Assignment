using System;

namespace string_type
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] arr = new string[] { "c++", "java", "c#" };
            foreach (String a in arr)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
    }
}