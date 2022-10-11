using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_Csharp_1
{
    internal class task18_1
    {
         public static void Main()
        {
            Dictionary<int, string> d = new Dictionary<int, string>();

            d.Add(1, "Nilesh Shrenik Hosure");
            d.Add(2, "Karthik Belligatti");
            d.Add(3, "Nischit");


            foreach (KeyValuePair<int, string> element in d)
            {
                Console.WriteLine("ID: {0} and Name: {1}", element.Key, element.Value);
            }
            Console.WriteLine("\n");
            Hashtable h = new Hashtable();

            h.Add(1, "Belagavi");
            h.Add(2, "Dharwad");
            h.Add(3, "Mangaluru");

            
            foreach (DictionaryEntry element in h)
            {
                Console.WriteLine("ID: {0} and City: {1}", element.Key, element.Value);
            }
        }
    }
}
