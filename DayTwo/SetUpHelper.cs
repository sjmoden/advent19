namespace DayTwo
{
    public static class SetUpHelper
    {
        public static string ReplaceMemoryValues(this string input, int replacePosition, int replaceValue)
        {
            var inputArray = input.Split(',');

            inputArray[replacePosition] = replaceValue.ToString();

            return string.Join(',', inputArray);
        }

    }
}
