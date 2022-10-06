using PizzaApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza
{
    public class EveningPriceStrategy : IPriceStrategy
    {
        public double CalculatePrice(AbstractPizza pizza)
        {
            throw new NotImplementedException();
        }
    }

    public class LunchPriceStrategy : IPriceStrategy
    {
        public double CalculatePrice(AbstractPizza pizza)
        {
            throw new NotImplementedException();
        }
    }

    public class NightPriceStrategy : IPriceStrategy
    {
        public double CalculatePrice(AbstractPizza pizza)
        {
            throw new NotImplementedException();
        }
    }
}
