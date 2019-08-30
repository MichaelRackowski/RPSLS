using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSUserStory
{
    class Program
    {
        static void Main(string[] args)
        {
            computer test = new computer();

            test.PlayerGesture();


            Game game = new Game();
            game.RunGame();
        }
    }
}
