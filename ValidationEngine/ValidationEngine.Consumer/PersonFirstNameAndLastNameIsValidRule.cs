using ValidationEngine.Library;

namespace ValidationEngine.Consumer
{
    public class PersonFirstNameAndLastNameIsValidRule : ValidationRule
    {
        public override bool Validate(object input)
        {
            if (input is Person p)
            {
                StringIsNotNullOrEmptyRule rule = new StringIsNotNullOrEmptyRule();
                return rule.Validate(p.FirstName) &&
                        rule.Validate(p.LastName);
            }

            return false;
        }
    }
}
