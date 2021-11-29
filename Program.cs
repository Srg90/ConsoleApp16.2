using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using System.Web.Script.Serialization;
using Newtonsoft;



namespace ConsoleApp16._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:/Task16/Products.json";

            int n = 5;
            string goodsInfoJson = File.ReadAllText(path);

            Goods[] Product = JsonConvert.DeserializeObject<Goods[]>(goodsInfoJson);

            Console.WriteLine("Информация о продуктах");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Наименование товара: {0}", Product[i].Name);
                Console.WriteLine("Код (номер) товара: {0}", Product[i].Code);
                Console.WriteLine("Стоимость товара: {0} рублей", Product[i].Price);
                Console.WriteLine();

            }
                      
            
            var maxPrice = Product.Max(p => p.Price);
            var NameMaxPrice = Product.First(p => p.Price == maxPrice).Name;

            Console.WriteLine("Самый дорогой товар из списка: {0}", NameMaxPrice);
            Console.WriteLine("Стоимость: {0} рублей", maxPrice);
            

            Console.ReadKey();
        }
      


        public class Goods
        {

            //[JsonPropertyName("Наименование товара")]
            public string Name { get; set; }
            //[JsonPropertyName("Код (номер) товара")]
            public int Code { get; set; }
            //[JsonPropertyName("Стоимость товара")]
            public double Price { get; set; }

        }

    }
}
