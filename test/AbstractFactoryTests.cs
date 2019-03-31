using System;
using Xunit;
using src.AbstractFactory;

namespace test
{
    public class AbstractFactoryTests
    {

        [Fact]
        public void Test_AbstractFactory()
        {
            /*
                REQUIREMENT - REFER THE FACTORY TESTS

                NY and CA Pizza store use the different incridents to make the pizza

                Handler - NYPizzaStore, CAPizzaStore
                Creator - 
                Product - NYCheesePizza, NYVeggiePizza, CACheesePizza, CAVeggiePizza
                Each store Products are using different ingredients (ingredients Factory)


                ABSTRACT FACTORY - 
                    - create a family of products with an interface
                    - Pizza products are created with ingredients factory

             */

             var nyPizzaStore = new NYPizzaStore();
             var nyCheesePizza = nyPizzaStore.OrderPizza("CheesePizza");
             //NYCheesePizza prepared with LightCheese, ThinCrust
             Assert.NotNull(nyCheesePizza as NYCheesePizza);

             var caPizzaStore = new CAPizzaStore();
             var caCheesePizza = caPizzaStore.OrderPizza("CheesePizza");
             //CACheesePizza prepared with ThickCheese, ThickCrust
             Assert.NotNull(caCheesePizza as CACheesePizza);             
        }
    }
}