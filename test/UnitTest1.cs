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
            var SimpleFactory = new SimplePizzaFactory();
            var simplePizzaStore = new SimplePizzaStore(SimpleFactory);
            var pizza = simplePizzaStore.OrderPizza("VeggiePizza");
            Assert.NotNull(pizza as VeggiePizza);
        }

        public void Test_MultipleFactory()
        {

        }
    }
}
