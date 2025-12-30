/*
 * Builder Pattern:
 * "Separar a construção de um objeto complexo de sua representação, tornando possível que o mesmo 
 * processo de construção possa criar diferentes representações."
 * - GoF (Gang of Four)
 * Creation Pattern
 */

using Builder;
using Builder.Builders;


IBuilder builder = new SimpleProductBuilder();

ProductDirector director = new ProductDirector(builder);

director.ConstructProduct();
Product product = builder.Build();

Console.WriteLine(product);

// ------------------------------------------------------

builder = new ComplexProductBuilder();

director = new ProductDirector(builder);

director.ConstructProduct();
product = builder.Build();

Console.WriteLine(product);

// Modelo clássico ---------------
// Sem uso do Director

builder = new SimpleProductBuilder();
builder.BuildName();
builder.BuildDescription();
product = builder.Build();
Console.WriteLine(product);

// --------------------------------
