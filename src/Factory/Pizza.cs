namespace src.Factory
{

    public interface IPizza
    {
        string Prepare();
        string Bake();
        string Cut();
        string Box();
    }

    public class NYVeggiePizza : IPizza
    {
        private string name = "NYVeggiePizza";
        public string Prepare() => $"{name} prepared with thin crust, and light cheese";
        public string Bake() => $"{name} baked";
        public string Cut() => $"{name} cut in triangle";
        public string Box() => $"{name} boxed";
    }

    public class NYCheesePizza : IPizza
    {
        private string name = "NYCheesePizza";
        public string Prepare() => $"{name} prepared with thin crust, and light cheese";
        public string Bake() => $"{name} baked";
        public string Cut() => $"{name} cut in triangle";
        public string Box() => $"{name} boxed";
    }

    public class CAVeggiePizza : IPizza
    {
        private string name = "CAVeggiePizza";
        public string Prepare() => $"{name} prepared with thick crust, and thick cheese";
        public string Bake() => $"{name} baked";
        public string Cut() => $"{name} cut in square";
        public string Box() => $"{name} boxed";
    }

    public class CACheesePizza : IPizza
    {
        private string name = "CACheesePizza";
        public string Prepare() => $"{name} prepared with thick crust, and thick cheese";
        public string Bake() => $"{name} baked";
        public string Cut() => $"{name} cut in square";
        public string Box() => $"{name} boxed";
    }
}