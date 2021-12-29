using System;

namespace Data_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            Array<string> array = new Array<string>();
            array.Add("asd");
            array.Add("bsd");
            Console.WriteLine(array.Contains("asd"));
            Console.WriteLine(array.IndexOf("bsd"));
            Console.WriteLine(array.Count);
            Console.WriteLine(array.Show());
            array.Clear();
            array.Add("1");
            Console.WriteLine(array.Show());
            array.Add("2");
            array.Add("3");
            array.Add("4");
            array.Add("5");
            array.Add("6");
            array.Add("7");
            array.Add("8");
            array.Add("9");
            array.Clear();
            Console.WriteLine(array.Show());
            Array<int> arr = new Array<int>();
            arr.Add(1,2,3,4,5,6,7,8,9);
        }
    }
}
