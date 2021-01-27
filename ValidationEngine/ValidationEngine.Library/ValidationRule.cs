namespace ValidationEngine.Library
{
    public abstract class ValidationRule
    {
        public abstract bool Validate(object input);
    }
}
