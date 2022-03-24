using System;
namespace OOPLesson1
{
    internal class ChekInBank
    {
        private int _numberChek;
        private int _balanc;
        private TypeChek _typeChek;
        private static int startChekNumber;

        /* Урок1: часть 1
         * Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип
         * банковского счета (использовать перечислимый тип). Предусмотреть методы для
         * доступа к данным – заполнения и чтения. Создать объект класса, заполнить его
         * поля и вывести информацию об объекте класса на печать
         */
        public void setNumberChek(int numberChek)
        {
            _numberChek = numberChek;
        }
        public void getNumberChek(int numberChek)
        {
            _numberChek = numberChek;
        }
        public void getTypeChek(TypeChek typeChek)
        {
            _typeChek = typeChek;
        }
        public void getBalnceChek(int balanc)
        {
            _balanc = balanc;
        }

        /*
         * Часть 3 
         * В классе банковский счет, удалить методы заполнения полей. Вместо этих
         * методов создать конструкторы. Переопределить конструктор по умолчанию,
         * создать конструктор для заполнения поля баланс, конструктор для заполнения
         * поля тип банковского счета, конструктор для заполнения баланса и типа
         * банковского счета. Каждый конструктор должен вызывать метод, генерирующий
         * номер счета.
         */
        public ChekInBank() : this(balanc: 0, typeChek: TypeChek.empty)
        {

        }
        public ChekInBank(TypeChek typeChek) : this(balanc: 0)
        {

        }
        public ChekInBank(int balanc) : this(balanc, typeChek: TypeChek.empty)
        {

        }
        public ChekInBank(int balanc, TypeChek typeChek)
        {
            _balanc = balanc;
            _typeChek = typeChek;
            _numberChek = RandomChekNumber();
        }

        public void ConsoleShowChek()
        {
            Console.WriteLine("\nДанные счета:");
            Console.WriteLine("Номер счета: " + _numberChek);
            Console.WriteLine("Тип счета: " + _typeChek);
            Console.WriteLine("Баланс счета: " + _balanc);
        }

        /* Часть2
         * Изменить класс счет в банке из упражнения таким образом, чтобы номер счета
         * генерировался сам и был уникальным. Для этого надо создать в классе
         * статическую переменную и метод, который увеличивает значение этого
         * переменной.
         */
        private int RandomChekNumber()
        {
            Random rnd = new Random();
            int randomChekNumber = rnd.Next(startChekNumber, startChekNumber + 10);
            startChekNumber = startChekNumber + 11;

            return randomChekNumber;
        }

        public enum TypeChek
        {
            type1,
            type2,
            type3,
            empty
        }
    }


}

