// Abstraction Pattern
// Abstraction pattern, kullanıcıların soyut sınıflar veya arayüzler üzerinden sınıflarla etkileşime geçmesini sağlar. Bu, implementasyon detaylarını gizler ve esnekliği artırır.

using System;

public abstract class Animal
{
    public abstract void MakeSound();
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks.");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows.");
    }
}

public class AnimalTrainer
{
    public void Train(Animal animal)
    {
        animal.MakeSound();
    }
}
