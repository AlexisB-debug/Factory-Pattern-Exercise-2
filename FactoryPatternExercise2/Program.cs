namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, choose a database: a List, SQL, or Mongo");
            string databaseType = DatabaseDoWhileLoop();
            
            IDataAccess databaseAccess = DataAccessFactory.GetDataAccessType(databaseType);
            List<Product> Products = databaseAccess.LoadData();
            databaseAccess.SaveData();

            foreach (Product product in Products)
            {
                Console.WriteLine($"Product: {product.Name}, Price: ${product.Price}");
            }

            static string DatabaseDoWhileLoop()
            {
                string database;

                do
                {
                    Console.WriteLine("Please, type 'List', 'SQL', or 'Mongo'");
                    database = Console.ReadLine().ToLower();
                }while(database != "list" && database != "sql" && database != "mongo");
                return database;
            }
        }
    }
}
