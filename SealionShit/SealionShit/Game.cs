using SealionShit.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealionShit
{
    internal class Game
    {
        TitleScreen TitleScreen;
       public Game()
        {
            TitleScreen = new TitleScreen();
        }
        public void start()
        {
            TitleScreen.showTitleScreen();
        }
    }
}
