// Factory Pattern
// Factory pattern, nesne oluşturma işlemini alt sınıflara bırakır. Bu sayede nesne oluşturma sürecini soyutlar ve kodun esnekliğini artırır.

using System;

public interface IProduct
{
    void DoWork();
}

public class ConcreteProductA : IProduct
{
    public void DoWork()
    {
        Console.WriteLine("ConcreteProductA is working.");
    }
}

public class ConcreteProductB : IProduct
{
    public void DoWork()
    {
        Console.WriteLine("ConcreteProductB is working.");
    }
}

public class ProductFactory
{
    public IProduct CreateProduct(string type)
    {
        switch (type)
        {
            case "A":
                return new ConcreteProductA();
            case "B":
                return new ConcreteProductB();
            default:
                throw new ArgumentException("Invalid type", nameof(type));
        }
    }
}
