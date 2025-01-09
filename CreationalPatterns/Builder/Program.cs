using Builder;
using Builder.Builders;


IBuilder builder = new ComplexProductBuilder();

ProdcutDirector director = new(builder);

director.ConstructProduct();

Product product = builder.Build();

