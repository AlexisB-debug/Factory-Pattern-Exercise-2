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
            
            if (databaseType == "list" || databaseType == "mongo")
            {
                foreach (Product product in Products)
                {
                    Console.WriteLine($"Product: {product.Name}, Price: ${product.Price}");
                }
                
                decimal total = 0;
                for (int counter = 0; counter <= Products.Count - 1; counter = counter + 1)
                {
                    total = total + Products[counter].Price;
                }

                Console.WriteLine($"Total: ${total}");
            }
            else
            {
                foreach (Product product in Products)
                {
                    Console.WriteLine($"Product: {product.Name}, Price Per Unit: ${product.Price}, Quantity: {product.Quantity}, Volume Price: {product.Price * product.Quantity}");
                }

                decimal total = 0;
                for (int counter = 0; counter <= Products.Count - 1; counter = counter + 1)
                {
                    total = total + (Products[counter].Price * Products[counter].Quantity);
                }
                Console.WriteLine($"Total: ${total}");
            }
            static string DatabaseDoWhileLoop()
            {
                string database;

                do
                {
                    Console.WriteLine("Please, type 'List', 'Mongo', or 'SQL'");
                    database = Console.ReadLine().ToLower();
                }while(database != "list" && database != "sql" && database != "mongo");
                return database;
            }
        }
    }
}
