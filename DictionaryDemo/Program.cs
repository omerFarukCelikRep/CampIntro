using System;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Dictionary 
             * ---------------------
             * Anahtar(Key) ve Değer(Value) olmak üzere iki kavram vardır.
             * Dizilere eklediğimiz elemanları Değer, o elemanlara erişmek için kullandığımız indeksleri de Anahtar olarak düşünebilirsiniz.
             * Her bir Değerin farklı bir Anahtarı olmalıdır yani koleksiyon içerisinde yer alan Anahtarlar birbirinden farklı olmalıdır.
             * 
             * Dictionary sınıfından bir nesne oluştururken, anahtar ve değerin veri tiplerini belirtmemiz gerekmekte. 
             * Aşağıdaki kod satırında, Key_Tipi yerine Anahtarın veri tipini, Value_Tipi yerine de Değerin verini tipini belirtmeliyiz.
             * 
             * Dictionary<Key_Tipi, Value_Tipi> Referans_Adi = new Dictionary<Key_Tipi, Value_Tipi>();
             * 
             * 
             */


            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Ali");
            myDictionary.Add(2, "Veli");

            foreach (var item in myDictionary.Key)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(myDictionary.Key[0] + " " + myDictionary.Value[0]);

        }
    }
}
