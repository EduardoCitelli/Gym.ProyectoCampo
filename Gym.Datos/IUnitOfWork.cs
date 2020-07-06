namespace Gym.Datos
{
    public interface IUnitOfWork
    {
        IRepository<T> GetRepository<T>() where T : class;        

        void Save();

        void Dispose();
    }
}
