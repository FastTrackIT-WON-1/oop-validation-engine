namespace ValidationEngine.Library
{
    public class ValidationEngine
    {
        public ValidationEngine(ValidationRule[] rules)
        {
            Rules = rules ?? new ValidationRule[] { };
        }

        public ValidationRule[] Rules { get; }

        public bool Validate(object input)
        {
            foreach (ValidationRule rule in Rules)
            {
                bool isValid = rule.Validate(input);
                if (!isValid)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
