using System;
using System.Collections.Generic;
using System.Text;

namespace ExoFruit
{
    interface Offers
    {
        bool appleOffer { set; get; }
        bool orangeOffer { set; get; }
        void FreeApple();
        void FreeOrange();
    }
}
