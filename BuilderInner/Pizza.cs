using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderInner
{
    public record Pizza(
        Dough Dough,
        Sauce Sauce,
        string Cheese,
        List<string> Toppings
    )
    {
        public class Builder
        {
            private Dough _dough = default!;
            private Sauce _sauce = default!;
            private string _cheese = "Mozzarella";
            private List<string> _toppings = [];

            public Builder SetDough(Dough dough)
            {
                _dough = dough;
                return this;
            }

            public Builder SetSauce(Action<Sauce.Builder> buildSauceAction)
            {
                var sauceBuilder = new Sauce.Builder();

                buildSauceAction(sauceBuilder);
                _sauce = sauceBuilder.Build();

                return this;
            }

            public Builder SetCheese(string cheese)
            {
                _cheese = cheese;
                return this;
            }

            public Builder AddTopping(string topping)
            {
                _toppings.Add(topping);
                return this;
            }

            public Pizza Build()
            {
                return new Pizza(_dough, _sauce, _cheese, _toppings);
            }
        }
    }
}
