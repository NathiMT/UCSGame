using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCSGame.Base;

namespace UCSGame.Scenarios
{
    internal class CastleExploration : Scene
    {
        public CastleExploration()
        {
            Add("Não há nada para fazer por aqui.");
            Add("Por enquando...");
            Add("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
            Add("█──▄▀▀▀▄───────────────█");
            Add("█──█───█──────────▄▀▀▄─█");
            Add("█░███▀███░░█▀█▀▀▀▀█░░█░█");
            Add("█░███▄███░░▀░▀░░░░░▀▀░░█");
            Add("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
            Add("1) Voltar para a cidade");
        }

        public override Scene Options(string option)
        {
            if (option == "1")
            {
                return new City();
            }

            return null;
        }
    }
}
