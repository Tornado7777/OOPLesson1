namespace OOPLesson1
{
    internal class ChekInBank
    {
        private int _numberChek;
        private int _balanc;
        private TypeChek _typeChek;

        public int numberChek
        {
            get
            {
                return _numberChek;
            }

            set
            {
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

        public enum TypeChek
        {
            type1,
            type2,
            type3
        }
    }
    
    
}

