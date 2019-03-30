namespace src.SimpleFactory
{

    public interface ISimplePizzaFactory
    {
        IPizza OrderPizza(string type);
    }

    public class SimplePizzaFactory : ISimplePizzaFactory
    {
        public IPizza OrderPizza(string type)
        {
            IPizza pizza = null;
            switch (type)
            {
                case "VeggiePizza":
                    pizza = new VeggiePizza();
                    break;
                case "CheesePizza":
                    pizza = new CheesePizza();
                    break;
                case "PepperoniPizza":
                    pizza = new PepperoniPizza();
                    break;
            }

            pizza.Order();
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
    
            return pizza;
        }
    }
}