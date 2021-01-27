namespace ValidationEngine.Library
{
    public class StringRepresentsANumberInIntervalRule : StringRepresentsANumberRule
    {
        public StringRepresentsANumberInIntervalRule(
            int fromValue,
            int toValue)
        {
            FromValue = fromValue;
            ToValue = toValue;
        }

        public int FromValue { get; }

        public int ToValue { get; }

        public override bool Validate(object input)
        {
            if (base.Validate(input))
            {
                // input is already a number
                if (int.TryParse(input as string, out int number))
                {
                    return (number >= FromValue) && (number <= ToValue);
                }
            }

            // input does not represent a number!
            return false;
        }
    }
}
