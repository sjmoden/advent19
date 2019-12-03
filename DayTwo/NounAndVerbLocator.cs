using System;

namespace DayTwo
{
    public class NounAndVerbLocator
    {
        private readonly string _memory;
        public NounAndVerbLocator(string memory)
        {
            _memory = memory;
        }

        public int FindNounVerbValue(int value)
        {
            for (int noun = 0; noun < 100; noun++)
            {
                for(int verb = 0; verb < 100; verb++)
                {
                    var intComputerWrapper = new IntComputerWrapper(noun,verb,_memory);

                    try
                    {
                        var firstCharacter = intComputerWrapper.FirstCharacter;

                        if (firstCharacter > value)
                        {
                            continue;
                        }

                        if (firstCharacter == value)
                        {
                            return (100 * noun) + verb;
                        }
                    }
                    catch { }
                }
            }

            throw new ApplicationException("Value not found");
        }
    }
}
