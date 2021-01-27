namespace ValidationEngine.Library
{
    public class StringIsNotNullOrEmptyRule : ValidationRule
    {
        public override bool Validate(object input)
        {
            if (input is null)
            {
                return false;
            }

            if (input is string stringInput)
            {
                return !string.IsNullOrEmpty(stringInput);
            }
            
            // input is not string!
            return false;
        }
    }
}
