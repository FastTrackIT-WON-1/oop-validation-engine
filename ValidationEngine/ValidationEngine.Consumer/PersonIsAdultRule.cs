using ValidationEngine.Library;

namespace ValidationEngine.Consumer
{
    public class PersonIsAdultRule : ValidationRule
    {
        public override bool Validate(object input)
        {
            if (input is Person p)
            {
                StringRepresentsANumberInIntervalRule rule = new StringRepresentsANumberInIntervalRule(
                    18,
                    int.MaxValue);

                return rule.Validate(p.Age.ToString());
            }

            return false;
        }
    }
}
