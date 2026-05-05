using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance_csharp
{
    internal class BaseClass
    {
        private int id;
        private string content;
        private int secretNo;

        public int SecretNo { get =>  secretNo; set => secretNo = value; }
        protected int Id { get => id; set => id = value; }
        protected string Content { get => content; set => content = value; }

        public BaseClass()
        {
            content = "Initialised by BaseClass";
            Console.WriteLine(this.id);
        }

        private void doSecretStuff()
        {
            this.id = 23;
            this.content = "BaseClass says: \'peekaboo\'";
            this.secretNo = -23;
            Console.WriteLine("BaseClass is doing Secret Stuff");
            Console.WriteLine("The secret No is"+secretNo.ToString());
        }

        protected virtual bool DoStuff(string test)
        {
            Console.WriteLine("BaseClass says thanks for giving " + test + "!");
            doSecretStuff();
            return true; 
        }

        public int DoOtherStuff(int number)
        {
            Console.WriteLine("BaseClass is temporarily busy doing " + number + " times other Stuff!");
            return 0;
        }
    }
}
