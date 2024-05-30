namespace DecoratorDesignPattern_PizzaOrder
{
    public class FarmHouse : BasePizza
    {
        public override int cost()
        {
            return 200;
        }
    }
}
