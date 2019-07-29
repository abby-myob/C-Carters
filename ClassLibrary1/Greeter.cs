namespace ClassLibrary1
{
    public class Greeter
    {
        private readonly string _name;

        public Greeter(string name)
        {
            _name = name;
        }

        public string GetGreeting()
        {
            if (_name == "Alice" || _name == "Bob")
            {
                return $"Hi, {_name}";
            }

            return "";
        }
    }
}