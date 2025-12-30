
using BuilderInner;

Dough dough = new Dough.Builder()
    .SetThickness(5)
    .SetFlour("Whole Wheat")
    .Build();

Pizza pizza = new Pizza.Builder()
    .SetDough(dough)
    .SetSauce(sauce => sauce.SetType("Tomato"))
    .SetCheese("Goat Cheese")
    .AddTopping("Sun-dried Tomatoes")
    .AddTopping("Arugula")
    .Build();

Console.WriteLine(pizza);