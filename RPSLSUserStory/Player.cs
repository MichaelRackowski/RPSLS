using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSUserStory
{
    public abstract class Player
    {
        public string gesture;
        public List<string> gestureOptions;
        public int score;
        public string selection;

        public Player ()
        {
            gesture = "";
            gestureOptions = new List<string>();
            score = 0;
            selection = "";
        }

        public abstract void PlayerGesture();
        
    }
}
