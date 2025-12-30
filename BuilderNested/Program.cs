
using BuilderNested;

Product.Builder builder = new Product.Builder();

builder.BuildName("Sample Product");
builder.BuildDescription("This is a sample product created using the Builder pattern.");

Product product = builder.Build();

Console.WriteLine(product);