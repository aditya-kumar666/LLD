namespace DecoratorDesignPattern_PizzaOrder
{
    public class ExtraCheese : ToppingDecorator
    {
        BasePizza basePizza;

        public ExtraCheese(BasePizza pizza)
        {
            this.basePizza = pizza;
        }

        public override int cost()
        {
            return basePizza.cost() + 20;
        }
    }
}
