using ValidationEngine.Library;

namespace ValidationEngine.Consumer
{
    public class PersonCNPIsValidRule : ValidationRule
    {
        public override bool Validate(object input)
        {
            if (input is Person p)
            {
                StringRepresentsANumberRule rule = new StringRepresentsANumberRule();
                return rule.Validate(p.CNP);
            }

            return false;
        }
    }
}
