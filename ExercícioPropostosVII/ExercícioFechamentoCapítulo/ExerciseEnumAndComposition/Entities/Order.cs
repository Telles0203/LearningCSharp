using ExerciseEnumAndComposition.Entities.Enum;
using System.Globalization;
using System.Text;

namespace ExerciseEnumAndComposition.Entities

{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus OrderStatus  { get; set; }
        public List<OrderItem> OrderItem { get; set;} = new List<OrderItem>();
        public Client Client { get; set; }

        public Order() { }

        public Order(DateTime moment, OrderStatus orderStatus, Client client)
        {
            Moment = moment;
            OrderStatus = orderStatus;
            Client = client;
        }
        public void AddOrdemItem(OrderItem orderItem)
        {
            OrderItem.Add(orderItem);
        }

        public void RemoveOrderItem(OrderItem orderItem)
        {
            OrderItem.Remove(orderItem);
        }

        public double Total()
        {
            double sum = 0;
            foreach (OrderItem orderItem in OrderItem)
            {
                sum += orderItem.subTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine($"Order moment:: {Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
            sb.AppendLine($"Order status: {OrderStatus}");
            sb.AppendLine($"Client: {Client.Name} ({Client.BirthDate.ToString("dd/MM/yyyy")}) - {Client.Email}");
            
            sb.AppendLine($"Order itens: ");
            foreach (OrderItem orderItem in OrderItem)
            {
                sb.AppendLine($"{orderItem.Product.Name}, ${orderItem.Product.Price.ToString("F2", CultureInfo.InvariantCulture)}, " +
                    $"Quantity: {orderItem.Quantity}, Subtotal: ${orderItem.subTotal()}");
            }
            sb.AppendLine($"Total price: $ {Total().ToString("F2", CultureInfo.InvariantCulture)}");
            

            
            return sb.ToString();
        }

    }
}
