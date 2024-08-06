// Singleton Pattern
// Singleton pattern, bir sınıfın yalnızca bir örneğe sahip olmasını sağlar ve bu örneğe evrensel bir erişim noktası sağlar.

using System;

public class Singleton
{
    private static Singleton instance;

    private Singleton() 
    {
        Console.WriteLine("Singleton instance created.");
    }

    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }

    public void DoSomething()
    {
        Console.WriteLine("Singleton instance is working.");
    }
}
