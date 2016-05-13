using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace DataBase
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Mem MemLib = new Mem();

        int gameProcId;

       

        

        private void Form2_Load(object sender, EventArgs e)
        {
         
        }


        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if(gameProcId > 0)
            {
                MemLib.writeMemory("Little Inferno.exe+0x0041FF00,0x30,0x4,0x158,0x0,0x20", "int", metroTextBox1.Text);
            }
            else
            {
                MessageBox.Show("There was a problem Handeling your Request, Please Contact the Creator of the trainer");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
     
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            gameProcId = MemLib.getProcIDFromName("Little Inferno");

            if (gameProcId != 0)
            {
                metroLabel6.Text = gameProcId.ToString();
                MemLib.OpenGameProcess(gameProcId);
                metroLabel4.Text = "Game Found!";
                metroLabel4.Style = MetroFramework.MetroColorStyle.Green;
                metroTextBox1.Enabled = true;
                metroTextBox2.Enabled = true;
                metroButton1.Enabled = true;
                metroButton2.Enabled = true;
                metroButton3.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error Game Must Be Running First");
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if(gameProcId > 0)
            {
                MemLib.writeMemory("Little Inferno.exe+0041FF00,0x30,0x4,0x158,0x0,0x24", "int", metroTextBox2.Text);
            }
        }
    }
    
}
