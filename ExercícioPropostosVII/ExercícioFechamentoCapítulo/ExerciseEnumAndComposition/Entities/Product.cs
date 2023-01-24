namespace ExerciseEnumAndComposition.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        Product() { }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
