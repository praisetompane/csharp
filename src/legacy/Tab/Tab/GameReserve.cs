using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.ComponentModel;

namespace Tab
{
    [Serializable ]
    class GameReserve
    {
        private double mKilomters;

        public double kilometers
        {
            get { return mKilomters; }
            set { mKilomters = value;}
        }
    }
}
