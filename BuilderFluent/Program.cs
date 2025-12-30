
using BuilderFluent;

Product product = new Product.Builder()
    .SetName("Product A")
    .SetDescription("This is Product A")
    .Build();

Console.WriteLine(product);