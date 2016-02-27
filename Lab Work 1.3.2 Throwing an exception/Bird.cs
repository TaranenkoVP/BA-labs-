using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usr_Exception
{
    class Bird
    {

        public  int[] FlySpeed = {5,15,25,35};
        public int NormalSpeed { get; set; }
        public string Nick { get; set; }

        private bool BirdFlewAway;

        public Bird() { }
        public Bird( string name, int speed )
        {
            NormalSpeed = speed;
            Nick = name;
        }

        #region Opr

        public void FlyAway( int incrmnt )
        {
            if (BirdFlewAway)
                Console.WriteLine("{0} flew away ...", Nick);
            else
            {
                NormalSpeed += incrmnt;
                if (NormalSpeed >= FlySpeed[3])
                {
                    BirdFlewAway = true;
                    NormalSpeed = 0;

                    BirdFlewAwayException ex =
                        new BirdFlewAwayException(string.Format("{0} flew with incredible speed!", Nick),
                                               "Oh! Startle.", DateTime.Now);
                    ex.HelpLink = "http://en.wikipedia.org/wiki/Tufted_titmouse";

                    throw ex;
                }
                else
                    Console.WriteLine("... flying close with the speed = {0}", NormalSpeed);
            }
        }
    }
    #endregion
}
