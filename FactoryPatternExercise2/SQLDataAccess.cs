namespace FactoryPatternExercise2;

public class SQLDataAccess : IDataAccess
{
    List<Product> Products = new List<Product>()
    {
        new Product() {Name = "Beanie Baby", Price = 35.00m, Quantity = 0},
        new Product() {Name = "Cactus", Price = 25.00m, Quantity = 0},
        new Product() {Name = "Dr. Seuss, The Cat in the Hat, Random House, 1957", Price = 6.00m, Quantity = 0},
        new Product() {Name = "Roald Dahl, Charlie and the Chocolate Factory, Alfred A. Knopf, 1964", Price = 7.00m, Quantity = 0},
        new Product() {Name = "Dive Rings", Price = 15.00m, Quantity = 0},
        new Product() {Name = "E.T. the Extra-Terrestrial, Feature Films, 1982", Price = 17.00m, Quantity = 0},
        new Product() {Name = "Furby", Price = 70.00m, Quantity = 0},
        new Product() {Name = "Game Boy Color", Price = 75.00m, Quantity = 0},
        new Product() {Name = "Goo Goo Dolls, Dizzy Up the Girl, 1998", Price = 15.00m, Quantity = 0},
        new Product() {Name = "Monopoly", Price = 30.00m, Quantity = 0},
        new Product() {Name = "Nintendo 64", Price = 500.00m, Quantity = 0},
        new Product() {Name = "OPI Pixel Dust 15mL", Price = 12.00m, Quantity = 0},
        new Product() {Name = "Piggy Bank", Price = 15.00m, Quantity = 0},
        new Product() {Name = "Pokemon Standard Booster Pack (10 Cards)", Price = 7.00m, Quantity = 0},
        new Product() {Name = "Ragdoll Kitten", Price = 700.00m, Quantity = 0}
    };
    public SQLDataAccess()
    {
        List<Product> ShoppingCart = new List<Product>();
        Console.WriteLine("Please, type 'buy' to place the product in the shopping cart\nPlease, type 'decline' to keep the product on the shelf.");

        foreach (Product product in Products)
        {
            string input;
            do
            {
                Console.WriteLine($"{product.Name} ${product.Price}\nPlease, type 'buy' or 'decline'");
                input = Console.ReadLine().ToLower();
            }while(input != "buy" && input != "decline");

            if (input == "buy")
            {
                Console.WriteLine($"Please, type the quantity of {product.Name}");
                int quantity = QuantityValidationCheck();
                
                Product newProduct = new Product()
                {
                    Name = product.Name,
                    Price = product.Price,
                    Quantity = quantity
                };
                ShoppingCart.Add(newProduct);
            }
        }
        Products = ShoppingCart;
    }
    
    public int QuantityValidationCheck()
    {
        int quantity;
        
        while (!(int.TryParse(Console.ReadLine(), out quantity) && quantity >= 0))
        {
            Console.WriteLine($"Please, type a quantity that can be placed in a shopping cart!");
        };
        
        return quantity;
    }
    public List<Product> LoadData()
    {
        Console.WriteLine($"I am reading data from {typeof(SQLDataAccess)}");
        return Products;
    }
    public void SaveData()
    {
        Console.WriteLine($"I am saving data to a {typeof(SQLDataAccess)} database");
    }
}