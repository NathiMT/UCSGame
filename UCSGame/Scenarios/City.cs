using UCSGame.Base;

namespace UCSGame.Scenarios
{
    internal class City : Scene
    {
        public City() 
        {
            Add($"A cidade é fria, {State.GetPlayer().Name}...");
            Add("Você sente frio...");
            Add("─────────█▄██▄█");
            Add("█▄█▄█▄█▄█▐█┼██▌█▄█▄█▄█▄█");
            Add("███┼█████▐████▌█████┼███");
            Add("█████████▐████▌█████████");
            Add("1) Entrar no Castelo e se abrigar");
            Add("2) Ir para a Loja");
            Add("3) Voltar para o Menu");
        }

        public override Scene Options(string option)
        {
            if (option == "1")
            {
                return new Castle();
            }
            else if (option == "2")
            {
                return new Store();
            }
            else
            {
                return new Menu();
            }
        }
    }
}
