using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCSGame.Base;

namespace UCSGame.Components
{
    internal abstract class Character
    {
        public string Name;

        public int Live = 100;

        public bool Defending = false;

        public Fight Fight = new();

        public abstract string GetFightingMove();

        public void Fighting(Character character, string option)
        {
            if (!character.Defending)
            {
                character.Live -= Fight.GetDamage(option);

                if (character.Live < 0)
                    character.Live = 0;
            }
            else
            {
                character.Defending = Fight.ChangeDefense(character.Defending);
            }
        }
    }
}
