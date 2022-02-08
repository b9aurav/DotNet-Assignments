using System;
using Properties;

namespace MainProgram {
    class Program {
        public static void Main() {
            const string name = "Gaurav Bambhaniya";
            Console.WriteLine($"name: {name}\nTime: {DateTime.Now.ToString("HH:mm:ss tt")}");
            TimePeriod t = new TimePeriod();
            t.Hours = 1;
            Console.WriteLine($"Time in hours: {t.Hours}");
            var person = new Person("Gaurav", "Bambhaniya");
            Console.WriteLine(person.Name);
            var item = new SaleItem("Shoes", 19.95m);
            Console.WriteLine($"{item.Name}: sells for {item.Price:C2}");
            var autoImplementedItem = new AutoImplementedSaleItem{ Name = "Socks", Price = 21.50m };
            Console.WriteLine($"{autoImplementedItem.Name}: sells for {autoImplementedItem.Price:C2}");
        }
    }
}