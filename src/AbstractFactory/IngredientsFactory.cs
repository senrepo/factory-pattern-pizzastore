using System.Collections.Generic;
using System;
namespace src.AbstractFactory
{
    public interface IIngredientsFactory
    {
        ICrust CreateCrust();
        ICheese CreateCheese();
        List<string> CreateToppings();
    }

    public class NYIngredientsFactory : IIngredientsFactory
    {
        public ICrust CreateCrust()
        {
            Console.WriteLine("ThinCrust added");
            return new ThinCrust();
        }

        public ICheese CreateCheese()
        {
            Console.WriteLine("LightCheese added");
            return new LightChesse();
        }

        public List<string> CreateToppings()
        {
            return new List<string> { "NYStyleCut-Onion", "NYStyleCut-Pepper" };
        }
    }

    public class CAIngredientsFactory : IIngredientsFactory
    {
        public ICrust CreateCrust()
        {
            Console.WriteLine("ThickCrust added");
            return new ThinkCrust();
        }

        public ICheese CreateCheese()
        {
            Console.WriteLine("ThickCheese added");
            return new ThickChesse();
        }

        public List<string> CreateToppings()
        {
            return new List<string> { "CAStyleCut-Onion", "CAStyleCut-Pepper" };
        }
    }
}