namespace Exam2;

public interface IRepository<T> where T: Model
{
    void Add(T item);
    void ReadAll();
    void Modify(int id, T item);
    void Delete(int id);
}