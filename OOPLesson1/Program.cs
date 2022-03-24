using System;


namespace OOPLesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //проверка работы конструкторов
            ChekInBank chekInBank = new ChekInBank();
            ChekInBank chekInBank2 = new ChekInBank(60000);
            ChekInBank chekInBank3 = new ChekInBank( ChekInBank.TypeChek.type1);
            ChekInBank chekInBank4 = new ChekInBank(700000, ChekInBank.TypeChek.type3);
            Console.WriteLine("**********Проверка работы конструкторов.******");
            chekInBank.ConsoleShowChek();
            chekInBank2.ConsoleShowChek();
            chekInBank3.ConsoleShowChek();
            chekInBank4.ConsoleShowChek();
            //проверка работы свойств
            Console.WriteLine("\n*****************Проверка свойств**********");
            chekInBank.numberChek = 80000;
            chekInBank.typeChek = ChekInBank.TypeChek.type2;
            chekInBank.balanc = 999;
            chekInBank.ConsoleShowChek();
            //проверка работы снятия сосчета и положить на счет
            Console.WriteLine("\n***Проверка работы снятия сосчета и положить на счет***");
            chekInBank.ToDeposit(1000);
            chekInBank.ConsoleShowChek();
            chekInBank.WithdrawFromChek(3000);
            chekInBank.ConsoleShowChek();
            chekInBank.WithdrawFromChek(1000);
            chekInBank.ConsoleShowChek();

            Console.ReadLine();
        }
    }
}
