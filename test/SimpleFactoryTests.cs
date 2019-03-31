using System;
using src.SimpleFactory;
using Xunit;

namespace test
{
    public class UnitTest1
    {
        [Fact]
        public void Test_SimpleFactory()
        {
            /*
                REQUIREMENT:

                Pizza Store sells different types of pizza like cheese, veggie and pepperoni
                Pizza store work flow receve the odrer of a pizza, prepare, bake, cut and box

                Handler -> PizzaStore who handles all type of pizza  *** PizzaStore ***
                Creator -> knows how to create the right object based on handler reqeust *** Factory **
                Product -> actual objects *** CheesePizza, VeggiePizza and PepperoniPizza ***
            
            */

            var SimpleFactory = new SimplePizzaFactory();
            var simplePizzaStore = new SimplePizzaStore(SimpleFactory);
            var pizza = simplePizzaStore.OrderPizza("VeggiePizza");
            Assert.NotNull(pizza as VeggiePizza);
        }
    }
}
