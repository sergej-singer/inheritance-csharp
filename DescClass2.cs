using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance_csharp
{
    internal class DescClass2:BaseClass
    {
        private double id;
        private DateTime date;

        public new double Id { get => id; set => id = value; }
        public new DateTime Date { get => date; set => date = value; }

        public DescClass2() { }

        //protected new bool DoStuff(string test) { return false; }         //Member verbergen

        //protected override bool DoStuff(string test) { return false; }      //Member überschreiben

        protected bool DoStuff(string test) { return false; }   //Member überladen

        public int DoBrandnewStuff(DateTime date)
        {
            Console.WriteLine("DescClass2 old id: " + Id);
            Console.WriteLine("..or: " + id + "??");
            Console.WriteLine("DescClass2 old content: " + Content);
            Console.WriteLine("DescClass2 old secret Number: " + SecretNo);
            this.id = 11.0;
            base.Id = 1;
            this.Content = "From DC2 instance.";
            base.DoStuff("Wohoo");
            this.DoOtherStuff(77);
            Console.WriteLine("DescClass2 old id: " + Id);
            Console.WriteLine("..or: " + id + "??");
            Console.WriteLine("DescClass2 old content: " + Content);
            Console.WriteLine("DescClass2 old secret Number: " + SecretNo);

            return 432;
        }

        private new int DoOtherStuff(int id)
        {
            Console.WriteLine("DescClass2 got: " + id);
            return 432;
        }

    }
}
