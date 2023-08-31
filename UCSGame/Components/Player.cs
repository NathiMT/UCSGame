namespace UCSGame.Components
{
    internal class Player : Character
    {      
        public string Bag = "vazio";

        public override string GetFightingMove()
        {
            string option = "";

            do
            {
                Console.WriteLine("Escolha sua ação:");
                Console.WriteLine("1) Dar soco");
                Console.WriteLine("2) Dar chute");
                Console.WriteLine("3) Defender");

                string userOption = Console.ReadLine();

                if (userOption != "1" && userOption != "2" && userOption != "3")
                {
                    option = "";
                    Console.WriteLine("Opção inválida!");
                }
                else
                {
                    option = userOption;
                }
            }
            while (option == "");

            return option;
        }
    }
}
