using System;


namespace OOPLesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChekInBank chekInBank = new ChekInBank();
            chekInBank.setNumberChek(400009000);
            chekInBank.setTypeChek(ChekInBank.TypeChek.type1);
            chekInBank.setBalnceChek(6012345);
            Console.WriteLine("Данные счета:");
            Console.WriteLine("Номер счета: " + chekInBank.getNumberChek());
            Console.WriteLine("Тип счета: " + chekInBank.getTypeChek());
            Console.WriteLine("Баланс счета: " + chekInBank.getBalnceChek());
            Console.ReadLine();
        }
    }
}
