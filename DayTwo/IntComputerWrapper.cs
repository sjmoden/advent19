using IntComputer;

namespace DayTwo
{
    public class IntComputerWrapper
    {
        private readonly IntcodeComputer _intcodeComputer;
        public IntComputerWrapper(int noun, int verb, string memory)
        {
            var startingMemory = memory.ReplaceMemoryValues(1, noun);
            startingMemory = startingMemory.ReplaceMemoryValues(2, verb);
            _intcodeComputer = new IntcodeComputer(startingMemory);
        }

        public int FirstCharacter
        {
            get
            {
                _intcodeComputer.RunAllOperations();
                return _intcodeComputer.FirstValue;
            }
        }
    }
}
