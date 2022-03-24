using System;


namespace OOPLesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChekInBank chekInBank = new ChekInBank();
            ChekInBank chekInBank2 = new ChekInBank(60000);
            ChekInBank chekInBank3 = new ChekInBank( ChekInBank.TypeChek.type1);
            ChekInBank chekInBank4 = new ChekInBank(700000, ChekInBank.TypeChek.type3);
            chekInBank.ConsoleShowChek();
            chekInBank2.ConsoleShowChek();
            chekInBank3.ConsoleShowChek();
            chekInBank4.ConsoleShowChek();
            Console.ReadLine();
        }
    }
}
