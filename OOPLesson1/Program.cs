using System;


namespace OOPLesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChekInBank chekInBank = new ChekInBank();
            chekInBank.numberChek = 400009000;
            chekInBank.typeChek = ChekInBank.TypeChek.type1;
            chekInBank.balanc = 6012345;
            Console.WriteLine(chekInBank.numberChek);
            Console.WriteLine(chekInBank.typeChek);
            Console.WriteLine(chekInBank.balanc);
            Console.ReadLine();
        }
    }
}
