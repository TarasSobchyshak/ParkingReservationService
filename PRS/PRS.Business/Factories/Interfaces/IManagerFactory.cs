namespace PRS.Business.Factories.Interfaces
{
    public interface IManagerFactory
    {
        T Create<T>(string managerName);
    }
}
