namespace FactoryPatternExercise2;

public class ListDataAccess : IDataAccess
{
    // public static List<Product> Products = new List<Product>() { new Product() {Name = "", Price = 0} };
    List<Product> Products = new List<Product>();
    public ListDataAccess()
    {
        do
        {
            Console.WriteLine("Please, type the parcel to place it in the shopping cart or type 'checkout'!");
            string input = Console.ReadLine();

            if (input == "Checkout" || input == "checkout")
            {
                break;
            }

            string parcel = input;
            Console.WriteLine($"Please, type the price of {parcel}");
            decimal price = decimal.Parse(Console.ReadLine());

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
        Console.WriteLine($"I am reading data from {typeof(ListDataAccess)}");
        return Products;
    }

    public void SaveData()
    {
        Console.WriteLine($"I am saving data to a {typeof(ListDataAccess)} database");
    }
}