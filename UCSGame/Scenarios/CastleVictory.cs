using UCSGame.Base;

namespace UCSGame.Scenarios
{
    internal class CastleVictory : Scene
    {
        public CastleVictory()
        {
            Add("Você eliminou os inimigos do catelo!");
            Add("O que deseja fazer agora?");
            Add("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
            Add("█░░╦─╦╔╗╦─╔╗╔╗╔╦╗╔╗░░█");
            Add("█░░║║║╠─║─║─║║║║║╠─░░█");
            Add("█░░╚╩╝╚╝╚╝╚╝╚╝╩─╩╚╝░░█");
            Add("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
            Add("1) Voltar para a cidade");
            Add("2) Explorar o castelo");
        }

        public override Scene Options(string option)
        {
            if (option == "1")
            {
                return new City();
            }

            return new CastleExploration();
        }
    }
}
