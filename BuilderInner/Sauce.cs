using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderInner
{
    public record Sauce(string type)
    {
        public class Builder
        {
            private string _type = "Tomato";
            
            public Builder SetType(string type)
            {
                _type = type;
                return this;
            }

            public Sauce Build()
            {
                return new Sauce(_type);
            }
        }
    }
}
