// Builder Pattern
// Builder pattern, karmaşık nesnelerin adım adım oluşturulmasını sağlar.
// Nesne oluşturma sürecini kontrol eder ve farklı türde nesneler oluşturmak için aynı süreci kullanır.

using System;

public class Car
{
    public string Engine { get; set; }
    public string Wheels { get; set; }
    public string Seats { get; set; }
    public string Windows { get; set; }
    public string GPS { get; set; }

    public override string ToString()
    {
        return $"Car with Engine: {Engine}, Wheels: {Wheels}, Seats: {Seats}, Windows: {Windows}, GPS: {GPS}";
    }
}

public interface ICarBuilder
{
    void SetEngine();
    void SetWheels();
    void SetSeats();
    void SetWindows();
    void SetGPS();
    Car GetCar();
}

public class SportsCarBuilder : ICarBuilder
{
    private Car _car = new Car();

    public void SetEngine() => _car.Engine = "V8 Engine";
    public void SetWheels() => _car.Wheels = "Sports Wheels";
    public void SetSeats() => _car.Seats = "Leather Seats";
    public void SetWindows() => _car.Windows = "Tinted Windows";
    public void SetGPS() => _car.GPS = "Built-in GPS";
    public Car GetCar() => _car;
}

public class SuvCarBuilder : ICarBuilder
{
    private Car _car = new Car();

    public void SetEngine() => _car.Engine = "V6 Engine";
    public void SetWheels() => _car.Wheels = "All-Terrain Wheels";
    public void SetSeats() => _car.Seats = "Fabric Seats";
    public void SetWindows() => _car.Windows = "Standard Windows";
    public void SetGPS() => _car.GPS = "Dashboard GPS";
    public Car GetCar() => _car;
}

public class CarDirector
{
    public void ConstructSportsCar(ICarBuilder builder)
    {
        builder.SetEngine();
        builder.SetWheels();
        builder.SetSeats();
        builder.SetWindows();
        builder.SetGPS();
    }

    public void ConstructSuvCar(ICarBuilder builder)
    {
        builder.SetEngine();
        builder.SetWheels();
        builder.SetSeats();
        builder.SetWindows();
        builder.SetGPS();
    }
}
