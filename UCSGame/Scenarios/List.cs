using UCSGame.Base;

namespace UCSGame.Scenarios
{
    internal class List : Scene
    {
        public string[] Items;

        public List(string[] items)
        {
            Items = items;

            Add("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");

            int n = 1;
            
            foreach (string item in items) 
            {
                string line = $"█ -> {n}) {item}";
                line = line.PadRight(21, ' ');
                line += "█";

                Add(line);

                n++;
            }

            Add("█--------------------█");
            Add("█ -> 0) Sair         █");
            Add("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");  
        }

        public override Scene Options(string option)
        {
            return new City();
        }
    }
}
