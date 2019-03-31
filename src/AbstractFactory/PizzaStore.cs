using System;

namespace src.AbstractFactory
{
    /* Create the Abstract PizzaStore class to sell the Pizza concept to be franchised */

    public interface IPizzaStore
    {
        IPizza OrderPizza(string type);
    }

    public abstract class PizzaStore : IPizzaStore
    {
        public IPizza OrderPizza(string type)
        {
            var pizza = CreatePizza(type);
            pizza?.Prepare();
            pizza?.Bake();
            pizza?.Cut();
            pizza?.Box();
            return pizza;
        }

        /* Use the Dependency Inversion Principle
           Dependency - dependents (Create responsibility) are externalized to derived class.
           Inversion - normally OOD derived class use the bass class implementations but the inversion is just opposite, the base class use the derived class implementations.
           Decouple the handler class from concreate products. All concreate products are created in the handler sub class
         */
        protected abstract IPizza CreatePizza(string type);
    }

    /*
        Handler class not using any factory class instead its creating the concreate product types.
        Though not a ideal way but considered as a fair approach.
     */
    public class NYPizzaStore : PizzaStore
    {
        IIngredientsFactory nyIngredientsFactory = new NYIngredientsFactory();
        public NYPizzaStore()
        {
        }

        protected override IPizza CreatePizza(string type)
        {
            IPizza pizza = null;
            switch (type)
            {
                case "VeggiePizza":throw new NotImplementedException() ; break;
                case "CheesePizza": pizza = new NYCheesePizza(nyIngredientsFactory); break;
            }
            return pizza;
        }
    }  

    public class CAPizzaStore : PizzaStore
    {
        IIngredientsFactory caIngredientsFactory = new CAIngredientsFactory();
        public CAPizzaStore()
        {
        }

        protected override IPizza CreatePizza(string type)
        {
            IPizza pizza = null;
            switch (type)
            {
                case "VeggiePizza":throw new NotImplementedException() ; break;
                case "CheesePizza": pizza = new CACheesePizza(caIngredientsFactory); break;
            }
            return pizza;
        }
    }      
}