namespace src.SimpleFactory
{

    public interface IPizzaFactory
    {
        IPizza OrderPizza(string type);
    }

    public class SimplePizzaStore : IPizzaFactory
    {
        private readonly ISimplePizzaFactory factory;

        public SimplePizzaStore(ISimplePizzaFactory factory)
        {
            this.factory = factory;
        }

        public IPizza OrderPizza(string type)
        {
           IPizza pizza = factory.OrderPizza(type);
           return pizza;
        }
    }
}