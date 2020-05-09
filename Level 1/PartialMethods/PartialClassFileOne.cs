using System;
using System.Collections.Generic;
using System.Text;

namespace PartialMethods
{
    public partial class SamplePartialClass
    {
        partial void SamplePartialMethod();

        public void PublicMethod()
        {
            Console.WriteLine("Public Method Invoked");
            SamplePartialMethod();
        }
    }
}
