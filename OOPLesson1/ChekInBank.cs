using System;
namespace OOPLesson1
{
    internal class ChekInBank
    {
        /* Урок 2, часть 4
         * В классе все методы для заполнения и получения значений полей заменить на
         * свойства. Написать тестовый пример.
         * часть 5  (*) Добавить в класс счет в банке два метода: снять со счета и положить на счет.
         * Метод снять со счета проверяет, возможно ли снять запрашиваемую сумму, и в
         * случае положительного результата изменяет баланс.
         */

        private int _numberChek;
        private int _balanc;
        private TypeChek _typeChek;
        private static int startChekNumber;

        public int numberChek
        {
            get
            {
                return _numberChek;
            }

            set
            {
                if (_numberChek != 0) Console.WriteLine("Номер счета будт изменен с" + _numberChek + " на " + value);
                _numberChek = value;
            }
        }

        public int balanc
        {
            set
            {
                _balanc = value;
            }
            get
            {
                return _balanc;
            }
        }

        public TypeChek typeChek
        {
            set
            {
                _typeChek = value;
            }

            get
            {
                return _typeChek;
            }
        }

        public bool WithdrawFromChek(int sum)
        {
            bool withdrawSucces = false;
            if (_balanc - sum >= 0)
            {
                _balanc = _balanc - sum;
                Console.WriteLine("Со счета " + _numberChek + " снята сумма: " + sum);
                withdrawSucces = true;
            }
            else Console.WriteLine("На счете " + _numberChek + " недостаточно средств для снятия: " + sum);
            return withdrawSucces;
        }

        public void ToDeposit(int sum)
        {
            _balanc += sum;
            Console.WriteLine("На счет " + _numberChek + " положена сумма: " + sum);
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
            Console.WriteLine("\nДанные номера счета:" + _numberChek);
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

