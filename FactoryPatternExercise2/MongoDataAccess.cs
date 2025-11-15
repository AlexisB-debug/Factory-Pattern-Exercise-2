namespace FactoryPatternExercise2;

public class MongoDataAccess : IDataAccess
{
    List<Product> Products = new List<Product>();
    public MongoDataAccess()
    {
        do
        {
            Console.WriteLine("Please, type the parcel to place it in the shopping cart or type 'checkout'!");
            string input = Console.ReadLine();

            if (input.ToLower() == "checkout")
            {
                break;
            }

            string parcel = input;
            Console.WriteLine($"Please, type the price of {parcel}");

            bool priceIsADecimal;
            decimal price;

            do
            {
                Console.WriteLine("The price is a figure");
                priceIsADecimal = decimal.TryParse(Console.ReadLine(), out price);
            }while(!priceIsADecimal);

            Product newProduct = new Product()
            {
                Name = parcel,
                Price = price
            };
            Products.Add(newProduct);
        }while (true);
    }
    public List<Product> LoadData()
    {
        Console.WriteLine($"I am reading data from {typeof(MongoDataAccess)}");
        return new List<Product>() {new Product() {Name = "", Price = 0}};
    }

    public void SaveData()
    {
        Console.WriteLine($"I am saving data to a {typeof(MongoDataAccess)} database");
    }
}