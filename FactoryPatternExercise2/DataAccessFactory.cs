namespace FactoryPatternExercise2;

public static class DataAccessFactory
{
    public static IDataAccess GetDataAccessType(string databaseType)
    {
        switch (databaseType.ToLower())
        {
            case "list":
                return new ListDataAccess();
            case "sql":
                return new SQLDataAccess();
            default: // "mongo"
                return new MongoDataAccess();
        }
    }
}