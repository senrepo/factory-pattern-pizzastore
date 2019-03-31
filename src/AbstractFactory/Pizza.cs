namespace src.AbstractFactory
{
    public interface IPizza
    {
        string Prepare();
        string Bake();
        string Cut();
        string Box();
    }

    public abstract class Pizza : IPizza
    {
        protected abstract string Name { get; set; }
        public abstract string Prepare();
        public string Bake() => $"{this.Name} baked";
        public virtual string Cut() => $"{this.Name} cut in triangle";
        public string Box() => $"{this.Name} boxed";
    }

    public class NYCheesePizza : Pizza
    {
        private readonly IIngredientsFactory ingredientsFactory;

        public NYCheesePizza(IIngredientsFactory ingredientsFactory)
        {
            this.ingredientsFactory = ingredientsFactory;
        }

        protected override string Name { get; set; } = "NYCheesePizza";

        public override string Prepare()
        {
            var str = $"{this.Name} prepared with ";
            var cheese = ingredientsFactory.CreateCheese();
            var crust = ingredientsFactory.CreateCrust();
            ingredientsFactory.CreateToppings();

            if (cheese is LightChesse) str += "LightCheese";
            if (crust is ThinCrust) str += ", ThinCrust";

            return str;
        }
    }

    public class CACheesePizza : Pizza
    {
        private readonly IIngredientsFactory ingredientsFactory;

        public CACheesePizza(IIngredientsFactory ingredientsFactory)
        {
            this.ingredientsFactory = ingredientsFactory;
        }

        protected override string Name { get; set; } = "CACheesePizza";

        public override string Prepare()
        {
            var str = $"{this.Name} prepared with ";
            var cheese = ingredientsFactory.CreateCheese();
            var crust = ingredientsFactory.CreateCrust();
            ingredientsFactory.CreateToppings();

            if (cheese is ThickChesse) str += "ThickCheese";
            if (crust is ThinkCrust) str += ", ThickCrust";

            return str;
        }
    }

}