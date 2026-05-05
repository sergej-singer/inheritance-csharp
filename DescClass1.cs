using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance_csharp
{
    internal class DescClass1:BaseClass
    {
        public DescClass1():base()
        {
            Id = 431;
        }

        public void DoBrandNewStuff()
        {
            Console.WriteLine("DescClass1 old id: " + Id);
            Console.WriteLine("DescClass1 old content: " + Content);
            Console.WriteLine("DescClass1 old secret Number: " + SecretNo);

            this.Id = 12;
            Console.WriteLine("DescClass1 current id: "+Id);
            this.Content = "This is some content.";
            Console.WriteLine("DescClass1 current content: "+Content);
            this.SecretNo = 42;
            Console.WriteLine("DescClass1 current secret Number: "+SecretNo);
            this.DoStuff("Eat this!");
            this.DoOtherStuff(431);
        }
    }
}
