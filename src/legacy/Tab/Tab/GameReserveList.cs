using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.ComponentModel;

namespace Tab
{
    [Serializable ]
    class GameReserveList : BindingList <GameReserve >
    {
        public void WriteDataToFile()
        {
            FileStream outputStream = new FileStream("GameReserveList .ser",FileMode.Create ,FileAccess .Write);
            BinaryFormatter bform = new BinaryFormatter();
            bform.Serialize(outputStream, this);//We declare the output file in the method
            outputStream.Close();

        }
        public void ReadDataFromFile()
        {
            FileStream inputStream = new FileStream("GameReserveList .ser", FileMode.Open, FileAccess.Read);
            this.Clear ();
            BinaryFormatter bform = new BinaryFormatter();
            var tempList = (GameReserveList)bform.Deserialize(inputStream);

            foreach (GameReserve a in tempList )
            {
                this.Add(a);
            }
            inputStream.Close();
        }
    }
}
