// Builder Pattern
// Builder pattern, karmaşık nesnelerin adım adım oluşturulmasını sağlar. Nesne oluşturma sürecini kontrol eder ve farklı temsilcilerle aynı oluşturma sürecini kullanarak farklı türde nesneler oluşturabilir.

using System;

public class Product
{
    public string PartA { get; set; }
    public string PartB { get; set; }
    public string PartC { get; set; }

    public void Show()
    {
        Console.WriteLine($"Product parts: {PartA}, {PartB}, {PartC}");
    }
}

public interface IBuilder
{
    void BuildPartA();
    void BuildPartB();
    void BuildPartC();
    Product GetResult();
}

public class ConcreteBuilder : IBuilder
{
    private Product product = new Product();

    public void BuildPartA() => product.PartA = "PartA";
    public void BuildPartB() => product.PartB = "PartB";
    public void BuildPartC() => product.PartC = "PartC";
    public Product GetResult() => product;
}

public class Director
{
    public void Construct(IBuilder builder)
    {
        builder.BuildPartA();
        builder.BuildPartB();
        builder.BuildPartC();
    }
}
