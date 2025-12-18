namespace FactoryPatternExercise2;

public class ListDataAccess : IDataAccess
{
    List<Product> Products = new List<Product>()
    {
        new Product() {Name = "Beanie Baby", Price = 35.00m},
        new Product() {Name = "Cactus", Price = 25.00m},
        new Product() {Name = "Dr. Seuss, The Cat in the Hat, Random House, 1957", Price = 6.00m},
        new Product() {Name = "Roald Dahl, Charlie and the Chocolate Factory, Alfred A. Knopf, 1964", Price = 7.00m},
        new Product() {Name = "Dive Rings", Price = 15.00m},
        new Product() {Name = "E.T. the Extra-Terrestrial, Feature Films, 1982", Price = 17.00m},
        new Product() {Name = "Furby", Price = 70.00m},
        new Product() {Name = "Game Boy Color", Price = 75.00m},
        new Product() {Name = "Goo Goo Dolls, Dizzy Up the Girl, 1998", Price = 15.00m},
        new Product() {Name = "Monopoly", Price = 30.00m},
        new Product() {Name = "Nintendo 64", Price = 500.00m},
        new Product() {Name = "OPI Pixel Dust 15mL", Price = 12.00m},
        new Product() {Name = "Piggy Bank", Price = 15.00m},
        new Product() {Name = "Pokemon Standard Booster Pack (10 Cards)", Price = 7.00m},
        new Product() {Name = "Ragdoll Kitten", Price = 700.00m},
    };
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