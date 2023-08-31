using UCSGame.Components;

namespace UCSGame
{
    internal class State
    {
        private static Player playerInstance;

        public static Player GetPlayer()
        {
            if (playerInstance == null)
            {
                playerInstance = new Player();
            }

            return playerInstance;
        }
    }
}
