using UCSGame.Base;

namespace UCSGame.Scenarios
{
    internal class Store : Scene
    {
        public Store()
        {
            Add("Você está na loja...");
            Add("            ╔╗");
            Add("          ╔════╗");
            Add("          ║╬╬╬╬║");
            Add("╔══════════════╗");
            Add("║LOJA MEDIEVAL ║");
            Add("║  ╔╗  ╔╗  ╔╗  ║");
            Add(" ╩╬╬╬╬╬╬╬╬╬╬╬╬╩");
            Add("1) Listar os produtos");
            Add("2) Voltar para a Cidade");
        }

        public override Scene Options(string option)
        {
            if (option == "1")
            {
                string[] items = new string[]
                {
                    "Armaduras",
                    "Armas",
                    "Roupas",
                    "Suprimentos",
                    "Poções"
                };

                List storeList = new List(items);

                return storeList;
            }
            else
            {
                return new City();
            }
        }

        public void ItemsList()
        {
            Console.WriteLine("Lista de itens para venda:");
            Console.WriteLine("Item 1");
            Console.WriteLine("Item 2");
            Console.WriteLine("Item 3");
            Console.WriteLine("Item 4");
            Console.WriteLine("Item 5");

            Console.WriteLine("Qual item você deseja comprar?");

            string option = Console.ReadLine();

            Console.WriteLine($"O personagem comprou o item {option}");
        }
    }
}
