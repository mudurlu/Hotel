namespace Hotel.DAL.Abstract
{
    public interface IGenericDAL<T> where T : class
    {
        void Insert(T p);
        void Delete(T p);
        void Update(T p);
        List<T> GetList();
        T GetById(int id);
    }
}
