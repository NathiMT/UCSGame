using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCSGame.Base;

namespace UCSGame.Scenarios
{
    internal class GameOver : Scene
    {
        public GameOver() 
        {
            Add("Você foi derrotado...");
            Add("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
            Add("█░░░░░░╔╗╔╗╔╦╗╔╗░░░░░█");
            Add("█░░░░░░║╗╠╣║║║╠─░░░░░█");
            Add("█░░░░░░╚╝╩╩╩─╩╚╝░░░░░█");
            Add("█░░░░░░╔╗╗╔╔╗╔╗░░░░░░█");
            Add("█░░░░░░║║║║╠─║ ░░░░░░█");
            Add("█░░░░░░╚╝╚╝╚╝╩-░░░░░░█");
            Add("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
            Add("Deseja iniciar um novo jogo?");
            Add("1) Sim");
            Add("2) Não");
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
