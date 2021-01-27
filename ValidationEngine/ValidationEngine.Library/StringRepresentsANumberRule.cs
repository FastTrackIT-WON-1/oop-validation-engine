namespace ValidationEngine.Library
{
    public class StringRepresentsANumberRule : ValidationRule
    {
        public override bool Validate(object input)
        {
            if (input is null)
            {
                return false;
            }

            if (input is string stringInput)
            {
                foreach (char c in stringInput)
                {
                    if (!char.IsDigit(c))
                    {
                        return false;
                    }
                }

                return true;
            }

            // input is not string!
            return false;
        }
    }
}
