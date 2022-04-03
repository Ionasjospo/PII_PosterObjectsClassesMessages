using System;
using System.Linq;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person julio = new Person("julio", "1.234.-2");
            Person jose = new Person("", "1.234.567-2");
            Person juan = new Person("", "1.234.56-2");
            Person john = new Person("John", "1.234.567-2");
            Person jane = new Person("Jane Doe", "8.765.432-7");
            julio.IntroduceYourself();
            jose.IntroduceYourself();
            juan.IntroduceYourself();
            john.IntroduceYourself();
            jane.IntroduceYourself();
            
        }
    }
}
