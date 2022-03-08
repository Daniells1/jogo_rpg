using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using jogo_rpg.src;

namespace jogo_rpg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arus hero = new Arus("Arus",23,"Knight");
            Arus opponent = new Arus("Brian",102, "Dark King");
            Witch witch = new Arus("Melizandre", 102, "Witch");
            Console.WriteLine(hero.ToString());
            Console.WriteLine(hero.Attack());

        }
    }
}
