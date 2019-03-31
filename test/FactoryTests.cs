using System;
using Xunit;
using src.Factory;

namespace test
{
    public class FactoryTests
    {
        [Fact]
        public void Test_Factory()
        {
            /*
                REQUIREMENT:

                Pizza store concept is franchised and there are two stores NY Pizza and CA Pizza sell the pizzas and in future other stores will be added.
                Each store creates pizza in there own style 
                    - NY Pizzas are thin crust, light cheese and triangle cut
                    - CA pizza are think crust, think cheese and square cut

                Handler - NYPizzaStore, CAPizzaStore
                Factory - NYPizzaFactory, CAPizzaFactory are optional
                Products - NYVeggiePizza, NYCheesePizza, CAVeggiePizza, CACheesePizza

                Dependency Inversion Principle - refer the PizzaStore class
                PizzaStore concreate class create the concreate pizza class -  fair approach but not a ideal way

             */

            var nyPizzaStore = new NYPizzaStore();
            var cheesePizza = nyPizzaStore.OrderPizza("CheesePizza");
            Assert.NotNull(cheesePizza as NYCheesePizza);

            var caPizzaStore = new CAPizzaStore();
            var veggiePizza = caPizzaStore.OrderPizza("VeggiePizza");
            Assert.NotNull(veggiePizza as CAVeggiePizza);
        }
    }
}