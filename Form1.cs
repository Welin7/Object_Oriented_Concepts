using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;



namespace Object_Oriented_Concepts
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32.dll")]
        public static extern bool Beep(UInt32 frequency, UInt32 duration);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //use metod override to songs first bell
        public class BellFirst : Bell
        {
            public override void Music()
            {
                Beep(500, 200);
                Beep(1000, 200);
                Beep(500, 200);
                Beep(1000, 200);
            }
        }

        //use metod override to songs second bell
        public class BellSecond : Bell
        {
            public override void Music()
            {
                Beep(1000, 300);
                Beep(500, 200);
                Beep(700, 300);
                Beep(1200, 500);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Bell bellone = new BellFirst();
            bellone.Sound();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bell belltwo = new BellSecond();
            belltwo.Sound();
        }
    }
   
}
