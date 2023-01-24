using ExerciseInheritance.Entities;

namespace ExerciseInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Product> listProducts = new List<Product>();
            
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Product #{i+1} data");
                Console.Write("Common, used or imported (c/u/i): ");
                char var1 = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                if (var1 == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customFee = double.Parse(Console.ReadLine());
                    listProducts.Add(new ImportedProduct(name, price, customFee));
                }
                else if (var1 == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    listProducts.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    listProducts.Add(new Product(name, price));
                }


            }

            Console.WriteLine("PRICE TAGS:");
            foreach (Product product in listProducts)
            {
                Console.WriteLine($"{product.PriceTag()}");
            }
        }
    }
}