using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BonusLabHomework;

namespace IComparable_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Item();
            var b = new Item();
            a.Name = "Bob";
            b.Name = "Carly";
            Console.WriteLine("{0} compared to {1} is {2}", a.Name, b.Name, a.CompareTo(b));
            a.Name = "Carly";
            b.Name = "Carly";
            Console.WriteLine("{0} compared to {1} is {2}", a.Name, b.Name, a.CompareTo(b));
            a.Name = "Edward";
            b.Name = "Carly";
            Console.WriteLine("{0} compared to {1} is {2}", a.Name, b.Name, a.CompareTo(b));

            var string1 = new Comparison();
            var string2 = new Comparison();
            string1.Name = "Yash";
            string2.Name = "Chatim";

            int alphabet = string1.CompareByName(string2);
            int length = string1.CompareByLength(string2);

            string textAlphabet = alphabet.ToString();
            string textLength = length.ToString();

            switch (alphabet)
            {
                case -1:
                    textAlphabet = "smaller than";
                    break;
                case 0:
                    textAlphabet = "same as";
                    break;
                case 1:
                    textAlphabet = "greater than";
                    break;
            }

            switch (length)
            {
                case -1:
                    textLength = "shorter";
                    break;
                case 0:
                    textLength = "same";
                    break;
                case 1:
                    textLength = "longer";
                    break;
            }


            Console.WriteLine("{0} is {1} {2} alphabetically", string1.Name, textAlphabet, string2.Name);
            Console.WriteLine("{0} is {1} length compared to {2}", string1.Name, textLength ,string2.Name);

            Console.ReadLine();
        }
    }
    public class Item : IComparable
    {
        public string Name;

        public int CompareTo(object o)
        {
            Item that = o as Item;
            return this.Name.CompareTo(that.Name);
        }
    }

    public class Comparison : ICompareByName, ICompareByLength
    {
        public string Name { get; set; }

        public int CompareByName()
        {
            return 0;
        }

        public int CompareByName(object o)
        {
            Comparison that = o as Comparison;
            return this.Name.CompareTo(that.Name);
        }

        public int CompareByLength()
        {
            return 0;
        }

        public int CompareByLength(object o)
        {
            Comparison that = o as Comparison;
            return this.Name.Length.CompareTo(that.Name.Length);
        }
    }
}
