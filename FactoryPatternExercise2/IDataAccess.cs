namespace FactoryPatternExercise2;

public interface IDataAccess
{
    public List<Product> LoadData();
    public void SaveData();
}