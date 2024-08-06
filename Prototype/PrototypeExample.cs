// Prototype Pattern
// Prototype pattern, bir nesnenin mevcut bir örneğini kopyalayarak yeni nesneler oluşturur. Bu, nesnelerin bir şablon gibi kullanılmasını sağlar ve aynı türden nesneleri hızlı bir şekilde oluşturur.

using System;

public abstract class Prototype
{
    public string Id { get; set; }

    public Prototype(string id)
    {
        Id = id;
    }

    public abstract Prototype Clone();
}

public class ConcretePrototype : Prototype
{
    public ConcretePrototype(string id) : base(id) { }

    public override Prototype Clone()
    {
        return (Prototype)this.MemberwiseClone();
    }
}
