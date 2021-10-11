using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Generics_Data_Structures
{//creating a dictionary from the System.Collections.Generic namespace, and perform several operations on the dictionary
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> player_numbers = new Dictionary<string, int>();

            player_numbers.Add("Seong Gi-hun", 456);
            player_numbers.Add("Cho Sang-woo", 218);
            player_numbers.Add("Kang Sae-byeok", 067);

            // Remove a key-value pair by referencing the key using the Remove() method.
            player_numbers.Remove("Seong Gi-hun");

            // The Count property allows us to obtain the number of objects in the collection.
            Console.WriteLine("Number of player_numbers : {0}", player_numbers.Count);

            // We can check for the existence of a key within the dictionary using the ContainsKey() method.
            Console.WriteLine("Do we have Kang's player number? : {0}", player_numbers.ContainsKey("Kang Sae-byeok"));

            // We can obtain the value of a key and store it. Here we will output the value of a score and store it as an integer.
            player_numbers.TryGetValue("Kang Sae-byeok", out int player_number_Kang);

            Console.WriteLine($"Kang's score : {player_number_Kang}");

            // The Clear() method allows you to clear a dictionary.
            player_numbers.Clear();
        }
    }
}
