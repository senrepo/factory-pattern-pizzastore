namespace src.SimpleFactory
{
    public interface IPizza
    {
        string Order();
        string Prepare();
        string Bake();
        string Cut();
        string Box();
    }

    public class VeggiePizza : IPizza
    {
        private string name = "VeggiePizza";
        public string Bake()
        {
            return $"{name} baked";
        }

        public string Cut()
        {
            return $"{name} cut";
        }

        public string Box()
        {
            return $"{name} boxed";
        }

        public string Order()
        {
            return $"{name} ordered";
        }

        public string Prepare()
        {
            return $"{name} prepared";
        }
    }

    public class CheesePizza : IPizza
    {
        private string name = "CheesePizza";
        public string Bake()
        {
            return $"{name} baked";
        }

        public string Cut()
        {
            return $"{name} cut";
        }

        public string Box()
        {
            return $"{name} boxed";
        }

        public string Order()
        {
            return $"{name} ordered";
        }

        public string Prepare()
        {
            return $"{name} prepared";
        }
    }

    public class PepperoniPizza : IPizza
    {
        private string name = "PepperoniPizza";
        public string Bake()
        {
            return $"{name} baked";
        }

        public string Cut()
        {
            return $"{name} cut";
        }

        public string Box()
        {
            return $"{name} boxed";
        }

        public string Order()
        {
            return $"{name} ordered";
        }

        public string Prepare()
        {
            return $"{name} prepared";
        }
    }
}