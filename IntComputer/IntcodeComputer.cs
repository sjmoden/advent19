using System;

namespace IntComputer
{
    public class IntcodeComputer
    {
        private readonly int[] _memory;
        public IntcodeComputer(string memory)
        {
            var memoryArray = memory.Split(',');
            _memory = Array.ConvertAll(memoryArray, int.Parse);
        }

        public string DisplayCurrentCode => string.Join(',', _memory);
        public int FirstValue => _memory[0];

        public void RunAllOperations()
        {
            var startingPostion = 0;
            while (RunOperations(startingPostion))
            {
                startingPostion += 4;
            }
        }

        private bool RunOperations(int startingPosition)
        {
            var instructionCode = _memory[startingPosition];

            switch (instructionCode)
            {
                case 1:
                    AddOperation(startingPosition + 1, startingPosition + 2, startingPosition + 3);
                    return true;
                case 2:
                    MultiplyOperation(startingPosition + 1, startingPosition + 2, startingPosition + 3);
                    return true;
                case 99:
                    return false;
            }

            throw new ApplicationException($"Operation not found: {instructionCode}");
        }

        private void AddOperation(int firstPosition, int secondPosition, int replacePosition)
        {
            var values = GetValues(firstPosition, secondPosition, replacePosition);

            _memory[values.Item3] = values.Item1 + values.Item2;
        }

        private void MultiplyOperation(int firstPosition, int secondPosition, int replacePosition)
        {
            var values = GetValues(firstPosition, secondPosition, replacePosition);

            _memory[values.Item3] = values.Item1 * values.Item2;
        }

        private Tuple<int, int, int> GetValues(int firstPosition, int secondPosition, int replacePosition)
        {
            var firstValuePosition = _memory[firstPosition];
            var secondValuePosition = _memory[secondPosition];

            var firstValue = _memory[firstValuePosition];
            var secondValue = _memory[secondValuePosition];

            var replaceValue = _memory[replacePosition];

            return new Tuple<int, int, int>(firstValue, secondValue, replaceValue);
        }
    }
}
