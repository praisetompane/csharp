using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Tab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        GameReserveList GList = new GameReserveList();
        GameReserve a;
        private void Form1_Load(object sender, EventArgs e)
        {

            a = new GameReserve(); { a.kilometers = 1212; }
            GList.Add(a);
            a = new GameReserve(); { a.kilometers = 9089; }
            GList.Add(a);
            a = new GameReserve(); { a.kilometers = 1342; }
            GList.Add(a);

            GList.WriteDataToFile();

            try
            {
                GList.ReadDataFromFile();
            }
            catch (FileNotFoundException f)
            {
                MessageBox.Show(f.Message );
            }
            /*for (int i = 0; i < 3; i++)
                textBox1.Text = Convert.ToString(GList[i].kilometers);*/
            textBox1.Text = Convert.ToString(GList[0].kilometers + " " +  GList[1].kilometers + " " + GList[2].kilometers);
        }

       
    }
}
