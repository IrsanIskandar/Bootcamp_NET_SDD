using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalCSharp
{
    public class DictionaryListCollection
    {
        public static void LatihanDictionaryCollection()
        {
            Console.WriteLine("===================================");
            Console.WriteLine("Belajar Dictionary List Collections");
            Console.WriteLine("===================================");

            string input = string.Empty;
            Dictionary<int, string> dict = new Dictionary<int, string>()
            {
                {1, "Farhan"},
                {2, "Rahma"},
                {3, "Rara"},
                {4, "Rafi"},
                {5, "Randu"},
                {6, "Kaku"},
                {7, "Kizaru"},
            };

            do
            {
                Console.WriteLine("====================");
                Console.WriteLine("Menu Dictionary Name");
                Console.WriteLine("1. Tambah");
                Console.WriteLine("2. Get By Key");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. Hapus");
                Console.WriteLine("5. Tampilkan");
                Console.WriteLine("6. Bersihkan Layar");
                Console.WriteLine("7. Keluar");
                Console.WriteLine("====================");

                Console.Write("Pilih Menu (1, 2, 3, 4, 5, 6, 7) : ");
                input = Console.ReadLine();

                if ("1".Equals(input))
                {
                    int key = 0;
                    string name = string.Empty;
                    Console.Write("Masukan Key : ");
                    key = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Masukan Value : ");
                    name = Console.ReadLine();

                    dict.Add(key, name);

                    LoadDataDictionary(ref dict);
                }
                else if ("2".Equals(input))
                {
                    int key = 0;
                    Console.Write("Masukan Key : ");
                    key = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"===========================================");
                    Console.WriteLine($"|No. | Dictionary Key   | Dictionary Value|");
                    Console.WriteLine($"===========================================");
                    Console.WriteLine($"|1   |\t{key}\t\t|\t{dict[key]}\t  |");
                    Console.WriteLine($"===========================================");
                    
                }
                else if ("3".Equals(input))
                {
                    int key = 0;
                    string name = string.Empty;
                    Console.Write("Masukan Key : ");
                    key = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Masukan Value : ");
                    name = Console.ReadLine();


                    dict[key] = name;
                    LoadDataDictionary(ref dict);
                }
                else if ("4".Equals(input))
                {
                    int key = 0;
                    Console.Write("Masukan Key : ");
                    key = Convert.ToInt32(Console.ReadLine());

                    dict.Remove(key);
                    LoadDataDictionary(ref dict);
                }
                else if ("5".Equals(input))
                {
                    LoadDataDictionary(ref dict);
                }
                else if ("6".Equals(input))
                {
                    Console.Clear();
                }

            } while (!"7".Equals(input));
        }

        private static void LoadDataDictionary(ref Dictionary<int, string> result)
        {
            int number = 1;
            Console.WriteLine($"===========================================");
            Console.WriteLine($"|No. | Dictionary Key   | Dictionary Value|");
            Console.WriteLine($"===========================================");
            foreach (KeyValuePair<int, string> item in result)
            {
                Console.WriteLine($"|{number++}   |\t{item.Key}\t\t|\t{item.Value}\t  |");
            }
            Console.WriteLine($"===========================================");
        }
    }
}
