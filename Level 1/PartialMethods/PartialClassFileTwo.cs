using System;
using System.Collections.Generic;
using System.Text;

namespace PartialMethods
{
    public partial class SamplePartialClass
    {
        partial void SamplePartialMethod()
        {
            Console.WriteLine("Partial Method Invoked");

        }

    }
}
