using ExerciseEnumAndComposition.Entities;
using ExerciseEnumAndComposition.Entities.Enum;
using System.Globalization;

namespace ExerciseEnumAndComposition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order= new Order();

            //Dados básicos do cliente:
            Console.WriteLine("Enter cliente data:");
            Console.Write($"Name: ");
            string name = Console.ReadLine();
            Console.Write($"Email: ");
            string email = Console.ReadLine();
            Console.Write($"Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, birthDate);
            order.Client = client;
            order.Moment = DateTime.Now;

            //Dados do pedido
            Console.WriteLine($"Enter order data: ");
            Console.Write($"Status: ");
            OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());

            
            //Cadastro do pedido
            Console.Write($"How many items to this order? ");
            int n = int.Parse(Console.ReadLine());       
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write($"Product name: ");
                string productName = Console.ReadLine() ;
                Console.Write($"Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write($"Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Product product = new Product(productName, price);
                OrderItem orderItem = new OrderItem(quantity, price, product);
                order.AddOrdemItem(orderItem);
            }   
            
            Console.Write($"{order}");
        }
    }
}