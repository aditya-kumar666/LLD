namespace DecoratorDesignPattern_PizzaOrder
{
    internal class Mushroom : ToppingDecorator
    {
        BasePizza basePizza;
        public Mushroom(BasePizza bp)
        {
            basePizza = bp;
        }

        public override int cost()
        {
            return basePizza.cost()+50;
        }
    }
}
