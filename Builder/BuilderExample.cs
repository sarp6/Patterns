// Builder Pattern
// Builder pattern, karmaşık nesnelerin adım adım oluşturulmasını sağlar.
// Nesne oluşturma sürecini kontrol eder ve farklı türde nesneler oluşturmak için aynı süreci kullanır.

using System;

public class Meal
{
    public string MainCourse { get; set; }
    public string SideDish { get; set; }
    public string Drink { get; set; }
    public string Dessert { get; set; }

    public override string ToString()
    {
        return $"Meal with Main Course: {MainCourse}, Side Dish: {SideDish}, Drink: {Drink}, Dessert: {Dessert}";
    }
}

public class MealBuilder
{
    private string _mainCourse;
    private string _sideDish;
    private string _drink;
    private string _dessert;

    public MealBuilder SetMainCourse(string mainCourse)
    {
        _mainCourse = mainCourse;
        return this;
    }

    public MealBuilder SetSideDish(string sideDish)
    {
        _sideDish = sideDish;
        return this;
    }

    public MealBuilder SetDrink(string drink)
    {
        _drink = drink;
        return this;
    }

    public MealBuilder SetDessert(string dessert)
    {
        _dessert = dessert;
        return this;
    }

    public Meal Build()
    {
        return new Meal
        {
            MainCourse = _mainCourse,
            SideDish = _sideDish,
            Drink = _drink,
            Dessert = _dessert
        };
    }
}

public class Director
{
    public Meal ConstructItalianMeal(MealBuilder builder)
    {
        return builder
            .SetMainCourse("Spaghetti")
            .SetSideDish("Bruschetta")
            .SetDrink("Wine")
            .SetDessert("Tiramisu")
            .Build();
    }

    public Meal ConstructJapaneseMeal(MealBuilder builder)
    {
        return builder
            .SetMainCourse("Sushi")
            .SetSideDish("Miso Soup")
            .SetDrink("Sake")
            .SetDessert("Mochi")
            .Build();
    }
}
