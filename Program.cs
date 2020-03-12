using System;

namespace Enums
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            // These are two ways of converting an Enum to and from an integer.

            /* Internally, Enum are integers, internally. So we can cast that
            to an int if we want the numeric value. The value of the first
            member of an enum (if not set) is 0. */
            var method = ShippingMethod.Express;
            System.Console.WriteLine((int)method);

            /* Let's say that we receive a value from a different system and
            we need to convert this value to a ShippingMethod in the application.
            We can use casting to convert the value to a ShippMethod. */
            var methodId = 3;
            System.Console.WriteLine((ShippingMethod)methodId);

            /* There are times when we need to convert an Enum to a string.
            Or, get a string and convert it to an Enum. If we want the string
            of a value, we can convert the method to a string. */
            System.Console.WriteLine(method.ToString());

            /* What if we have a string, and we want to convert that to an Enum?
            Let's say that we have that string stored somewhere in a database
            or in another system. We use parsing to convert the string to a
            different type. The first value in the Enum is a target, the second
            is a value. This returns an object, so we need to cast the object to
            a ShippingMethod.*/
            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
        }
    }
}
