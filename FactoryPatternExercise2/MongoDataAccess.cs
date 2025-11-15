namespace FactoryPatternExercise2;

public class MongoDataAccess : IDataAccess
{
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