using DecoratorDesignPattern_PizzaOrder;

public class Program
{
    public static void Main(string[] args)
    {
        BasePizza pizza = new Mushroom(new ExtraCheese(new FarmHouse()));

        Console.WriteLine("Farm House Pizza cost with Extra Cheese and Mushroom is " + pizza.cost());
    }
}