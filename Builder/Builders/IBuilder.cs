using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Builders
{
    public interface IBuilder
    {
        void BuildName();
        void BuildDescription();
        Product Build();
    }
}
