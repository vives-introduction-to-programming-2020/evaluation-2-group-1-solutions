using System;

namespace FindTheKey
{
    class Program
    {
        static void Main(string[] args)
        {
            KeyValueParser parser = new KeyValueParser();

            string keyValue = "name: Nico De Witte";
            Console.WriteLine($"Value of keyValue \"{keyValue}\" => \"{parser.GetValue(keyValue)}\"");

            string invalid = "This is not a valid string";
            Console.WriteLine($"Value of invalid \"{invalid}\" => \"{parser.GetValue(invalid)}\"");

            string empty = "";
            Console.WriteLine($"Value of empty \"{empty}\" => \"{parser.GetValue(empty)}\"");

            string another = "msg: Hello World";
            Console.WriteLine($"Value of another \"{another}\" => \"{parser.GetValue(another)}\"");
        }
    }
}
