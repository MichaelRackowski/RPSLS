using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSUserStory
{
    public class human : Player
    {
        public override void PlayerGesture()
            {
                Console.WriteLine("Which would you like to pick? [Rock] [Paper] [Scissors] [Lizard] [Spock]");
            gesture = Console.ReadLine().ToLower() ;

        }

    }

}
