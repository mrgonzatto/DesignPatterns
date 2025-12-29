using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Builders
{
    internal class ComplexProductBuilder : IBuilder
    {
        private string _name = "";
        private string _description = "";

        public Product Build()
        {
            return new Product(Name: _name, Description: _description);
        }

        public void BuildDescription()
        {
            _description = "This is a complex product.";
        }

        public void BuildName()
        {
            _name = "Complex Product";
        }
    }
}
