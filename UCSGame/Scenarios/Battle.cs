using UCSGame.Base;
using UCSGame.Components;

namespace UCSGame.Scenarios
{   
    internal class Battle : Scene
    {
        private Enemy enemy = new Enemy("inimigo");
        private Fight fight = new Fight();
        private Character who = State.GetPlayer();

        public Battle() 
        {
            Add("A batalha está começando...");
            Add("█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█");
            Add("█   ___         ___   █");
            Add("█ _/___|_     _/___|_ █");
            Add("█ (҂`_´)       (`_´҂) █");
            Add("█ <;   |       |   ;> █");
            Add("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
            Add("Digite enter para continuar!");
        }

        public override Scene Options(string option)
        {
            do
            {
                string moveName;
                string move = who.GetFightingMove();
                if (move == "1")
                    moveName = "dar um soco";
                else if (move == "2")
                    moveName = "dar um chute";
                else
                {
                    moveName = "defender";
                    who.Defending = true;
                }                    

                Console.WriteLine($"O jogador {who.Name} escolheu {moveName}");

                Character next = WhoIsNext();
                who.Fighting(next, move);

                ShowLive();

                who = next;
            }
            while (State.GetPlayer().Live > 0 && enemy.Live > 0);

            if (State.GetPlayer().Live == 0)
                return new GameOver();

            State.GetPlayer().Live = 100;
            return new Victory();
        }
        
        public Character WhoIsNext()
        {
            if (who == State.GetPlayer())
                return enemy;
            else
                return State.GetPlayer();
        }

        private void ShowLive ()
        {
            Console.WriteLine($"Sua vida: {State.GetPlayer().Live}");
            Console.WriteLine($"Vida do inimigo: {enemy.Live}");
        }

    }
}