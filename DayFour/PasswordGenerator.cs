using System.Collections.Generic;

namespace DayFour
{
    public class PasswordGenerator
    {
        private readonly int _lowValue;
        private readonly int _highValue;
        private readonly List<int> _passwords  = new List<int>();
        private readonly List<int> _newPasswords  = new List<int>();
        public PasswordGenerator(int lowValue, int highValue)
        {
            _lowValue = lowValue;
            _highValue = highValue;
        }

        public int NumberOfPasswords
        {
            get
            {
                if (_passwords.Count == 0)
                {
                    GenerateValues();
                }
                return _passwords.Count;
            }
        }

        public int NumberOfNewPasswords
        {
            get
            {
                if (_newPasswords.Count == 0)
                {
                    GenerateValues();
                }
                return _newPasswords.Count;
            }
        }
            
        private void GenerateValues()
        {
            for (int i = _lowValue; i <= _highValue; i++)
            {
                switch (PasswordValidator.ValidationException(i))
                {
                    case ValidPasswordEnum.Original:
                        _passwords.Add(i);
                        break;
                    case ValidPasswordEnum.New:
                        _newPasswords.Add(i);
                        break;
                    case ValidPasswordEnum.Both:
                        _passwords.Add(i);
                        _newPasswords.Add(i);
                        break;
                }
            }
        }
    }
}
