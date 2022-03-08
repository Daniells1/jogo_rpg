using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace jogo_rpg.src.Entities
{
    public class Witch : Arus
    {
        public override string Attack ()
        {
            return this.Name + "Lançou Magia";
        }
    }
}
