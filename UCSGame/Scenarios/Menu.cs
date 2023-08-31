using UCSGame.Base;

namespace UCSGame.Scenarios
{
    internal class Menu : Scene
    {
        public Menu()
        {
            Add("1) Jogar");
            Add("2) Sair");
        }

        public override Scene Options(string option)
        {
            if (option != "1")
            {
                Environment.Exit(0);
            } 

            return new PlayerCreate();
        }
    }
}
