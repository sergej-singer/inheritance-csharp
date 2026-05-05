namespace inheritance_csharp
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is an inhericance test!");
            
            BaseClass baseClass = new BaseClass();
            baseClass.SecretNo = 1;
            Console.WriteLine("Programm got from baseClass:" + baseClass.DoOtherStuff(2));

            DescClass1 descClass1 = new DescClass1();
            descClass1.SecretNo = 3;
            Console.WriteLine("Programm got from descClass1:" + descClass1.DoOtherStuff(4));
            descClass1.DoBrandNewStuff();

            DescClass2 descClass2 = new DescClass2();
            descClass2.SecretNo = 4;
            Console.WriteLine("Programm got from descClass2:" + descClass2.DoOtherStuff(5));
            Console.WriteLine("Programm got from descClass2:" + descClass2.DoBrandnewStuff(DateTime.Now));
            descClass2.Id = 123;
            descClass2.Date = DateTime.Now;
        }
    }
}
