using Builder.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class ProductDirector(IBuilder builder)
    {
        public void ConstructProduct()
        {
            builder.BuildName();
            builder.BuildDescription();
        }
    }
}