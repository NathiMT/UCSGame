using UCSGame.Base;

namespace UCSGame.Scenarios
{
    internal class Victory : Scene
    {
        public Victory()
        {
            Add("Você venceu a luta!");
            Add("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
            Add("█░░╗╔─╦╔╗╔╦╗╔╗╔╗╦─╦░░█");
            Add("█░░║║─║║──║─║║║─╚═╝░░█");
            Add("█░░╚╝─╩╚╝─╩─╚╝╩──╩-░░█");
            Add("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
            Add("1) Voltar para o castelo");
        }

        public override Scene Options(string option)
        {
            if (option != "1")
            {
                Environment.Exit(0);
            }

            return new CastleVictory();
        }
    }
}
