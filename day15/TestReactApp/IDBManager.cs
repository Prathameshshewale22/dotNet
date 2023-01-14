namespace DAL;
using BOL;

public interface IDBManager{
    List<Product> GetAll();

    Product GetById(int id);

    void Insert (Product prod);

    void Update (Product prod);

    void Delete(int id);
}
