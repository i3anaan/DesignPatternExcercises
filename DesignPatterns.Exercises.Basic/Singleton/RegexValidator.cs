using System.Text.RegularExpressions;

namespace DesignPatterns.Exercises.Basic.Singleton
{
    public class RegexValidator
    {
        public const string ConfigFileLocation = "../../../../DesignPatterns.Exercises.Basic/Singleton/ValidatorConfig.json";

        private bool _useStrictMode;


        public RegexValidator(bool useStrictMode)
        {
            _useStrictMode = useStrictMode;
        }

        public bool ValidateString(string input)
        {
            var regex = new Regex(_useStrictMode ? "^\\w*$" : "^[\\w\\s]*$");

            return regex.Match(input).Success;
        }
    }
}
