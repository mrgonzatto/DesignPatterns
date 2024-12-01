using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.SimpleFactory
{
    // A concrete class that creates a concrete instance froma  set of defined classes
    // using inheritance or interface implementation
    public class PasswordFactory2
    {
        public static IPassword Generate(ushort length /* .. */ )
        {
            // logic
            return (length < 5 ? new SimplePassword() : new ComplexPassword());
        }
    }

    public interface IPassword;

    public class SimplePassword : IPassword;
    public class ComplexPassword : IPassword;

    public class PasswordFactory
    {
        public static Password Generate( /* .. */ )
        { 
            // logic
            return new Password();
        }
    }

    // A static factory method - a static methos defined in a concrete type that creates that type
    public class Password
    {
        public Password() 
        { 
        }

        public static Password Generate( /* .. */ )
        {
            // logic
            return new Password();
        }
    }
}