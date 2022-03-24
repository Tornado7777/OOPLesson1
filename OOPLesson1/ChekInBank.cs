namespace OOPLesson1
{
    internal class ChekInBank
    {
        /* Урок 2, часть 1
         * Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип
         * банковского счета (использовать перечислимый тип). Предусмотреть методы для
         * доступа к данным – заполнения и чтения. Создать объект класса, заполнить его
         * поля и вывести информацию об объекте класса на печать
         */
        
        private int _numberChek;
        private int _balanc;
        private TypeChek _typeChek;

        public void setNumberChek(int numberChek)
        {
            _numberChek = numberChek;
        }
        public int getNumberChek()
        {
             return _numberChek;
        }
        public void setTypeChek(TypeChek typeChek)
        {
            _typeChek = typeChek;
        }
        public TypeChek getTypeChek()
        {
            return _typeChek;
        }
        public void setBalnceChek(int balanc)
        {
            _balanc = balanc;
        }
        public int getBalnceChek()
        {
            return _balanc;
        }
        
        public enum TypeChek
        {
            type1,
            type2,
            type3
        }
    }
    
    
}

