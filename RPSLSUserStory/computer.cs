using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSUserStory
{
    public class computer : Player
    {
        public override void PlayerGesture()
        {
            Random RNG = new Random();            
            int index = RNG.Next(gestureOptions.Count);
            gesture = gestureOptions[index];
        }

    }
}