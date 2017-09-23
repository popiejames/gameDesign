using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class Les3 : AbstractGame
    {
        public override void GameStart()
        {
            //Everything that has to happen when the game starts happens here.
            //F.e. initializing objects.
        }

        public override void GameEnd()
        {
            //Clean up unmanaged objects here (F.e. bitmaps & fonts)

            //For example:
            //m_Bitmap.Dispose();
            //m_Font.Dispose();
        }

        public override void Update()
        {
            //Update everything here.
            //F.e. get input, move objects, etc...
            bool B_Input_Space;

            //For example:
            // float deltaTime = GAME_ENGINE.GetDeltaTime();

            //met hulp van mark
            if (GAME_ENGINE.GetKey(Key.Space))
                B_Input_Space = true;
            else
                B_Input_Space = false;


        }

        public override void Paint()
        {
            //Draw everything here.

            //For example:
            //met hulp van mark
            // if (B_Input_Space)
            // {
            GAME_ENGINE.FillRectangle(30, 80, 50, 50);
            // }
        }
    }
}
