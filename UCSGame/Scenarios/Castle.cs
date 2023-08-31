using UCSGame.Base;

namespace UCSGame.Scenarios
{
    internal class Castle : Scene
    {
        public Castle()
        {
            Add("Você está dentro do castelo...");
            Add("É mais quente aqui, mas há inimigos!");
            Add("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
            Add("█░░╦─╦╔╗╦─╔╗╔╗╔╦╗╔╗░░█");
            Add("█░░║║║╠─║─║─║║║║║╠─░░█");
            Add("█░░╚╩╝╚╝╚╝╚╝╚╝╩─╩╚╝░░█");
            Add("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
            Add("1) Fugir");
            Add("2) Lutar");
        }

        public override Scene Options(string option)
        {
            if (option == "1")
            {
                return new City();
            }

            return new Battle();
        }
    }
}
