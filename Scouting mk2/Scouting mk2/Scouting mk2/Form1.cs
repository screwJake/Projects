using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scouting_mk2
    {


    public partial class Form1 : Form
        {
        int Lval1 = 0;
        int Lval2 = 0;
        int Lval3 = 0;
        int Lval4 = 0;
        int AGT = 0;
        int AH = 0;
        int TH = 0;
        int TGT = 0;
        string gear = "No";
        string scale = "No";
        string baseLine = "no";
        string output = null;
        string path = "C:\\FileFolder\\";
        string rotors = null;
        String newPath = null;
        public Form1()
            {
            InitializeComponent();





            }
        public void concat()
            {
            string name = NameBox.Text.Substring(NameBox.Text.IndexOf(": ") + 1);
            string match = MatchBox.Text.Substring(MatchBox.Text.IndexOf(": ") + 1);
            string number = TeamBox.Text.Substring(TeamBox.Text.IndexOf(": ") + 1);
            int AutoLow = Lval1 + Lval2 / 2;
            int TeleLow = Lval3 + Lval4 / 2;
            output = name + " @ " + match + " @ " + number + " @ " + AutoGearText.Text + " @ " + AutoHighText.Text + " @ " + AutoLow + " @ " + TeleGearText.Text + " @ " + TeleHighText.Text + " @ " + TeleLow + " @ " + baseLine + " @ " + rotors + " @ " + gear + " @ " + scale + " @ " + NotesText.Text + "/n";
            }


        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
            {

            }

        public void AutoS1(object sender, EventArgs e)
            {

            Lval1 = AutoBarOne.Value;
            AutoLowOne.Text = "" + Lval1;
            while (Lval2 - Lval1 <= 4)
                {
                Lval2++;
                AutoLowTwo.Text = "" + Lval2;
                AutoBarTwo.Value = Lval2;
                AutoBarTwo.Update();
                }

            }

        public void AutoBarTwo_Scroll(object sender, EventArgs e)
            {
            Lval2 = AutoBarTwo.Value;
            AutoLowTwo.Text = "" + Lval2;
            while (Lval2 - Lval1 <= 4)
                {
                Lval1--;
                AutoLowOne.Text = "" + Lval1;
                AutoBarOne.Value = Lval1;
                AutoBarOne.Update();
                }


            }

        private void submit_Click(object sender, EventArgs e)
            {
            
            
            concat();
            //C:\Users\Public\TestFolder

           
            System.IO.File.AppendAllText(newPath, output);
            //System.IO.File.AppendAllText(newPath, output);

            System.Windows.Forms.Application.Exit();
            }

        private void AutoGearDown_Click(object sender, EventArgs e)
            {
            if (AGT > 0)
                {
                AGT--;
                AutoGearText.Text = "" + AGT;
                }
            }

        private void AutoGearUp_Click(object sender, EventArgs e)
            {
            AGT++;
            AutoGearText.Text = "" + AGT;
            }

        private void AutoHighDown_Click(object sender, EventArgs e)
            {
            if (AH > 0)
                {
                AH--;
                AutoHighText.Text = "" + AH;
                }
            }

        private void AutoHighUp_Click(object sender, EventArgs e)
            {
            AH++;
            AutoHighText.Text = "" + AH;
            }

        private void TeleGearDown_Click(object sender, EventArgs e)
            {
            if (TGT > 0)
                {
                TGT--;
                TeleGearText.Text = "" + TGT;
                }
            }

        private void TeleGearUp_Click(object sender, EventArgs e)
            {
            TGT++;
            TeleGearText.Text = "" + TGT;
            }

        private void TeleHighDown_Click(object sender, EventArgs e)
            {
            if (TH > 0)
                {
                TH--;
                TeleHighText.Text = "" + TH;
                }
            }

        private void TeleHighUp_Click(object sender, EventArgs e)
            {
            TH++;
            TeleHighText.Text = "" + TH;
            }

        private void TeleBar1_Scroll(object sender, EventArgs e)
            {
            Lval3 = trackBar1.Value;
            TeleLow1.Text = "" + Lval3;
            while (Lval4 - Lval3 <= 4)
                {
                Lval4++;
                TeleLow2.Text = "" + Lval4;
                trackBar2.Value = Lval4;
                trackBar2.Update();
                }
            }

        private void TeleBar2_Scroll(object sender, EventArgs e)
            {
            Lval4 = trackBar2.Value;
            TeleLow2.Text = "" + Lval4;
            while (Lval4 - Lval3 <= 4)
                {
                Lval3--;
                TeleLow1.Text = "" + Lval3;
                trackBar1.Value = Lval3;
                trackBar1.Update();
                }
            }

        private void GearBool_CheckedChanged(object sender, EventArgs e)
            {
            gear = "Yes";
            }

        private void ScaleBool_CheckedChanged(object sender, EventArgs e)
            {
            scale = "Yes";
            }

        private void button1_Click(object sender, EventArgs e)
            {
            /*
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                path = saveFileDialog1.FileName;
                saveFileDialog1.Dispose();
                //newPath = path + "\\Output.txt";
                }
            if (!System.IO.File.Exists(path))
                {
                System.IO.File.CreateText(path);
                }
            */
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                newPath = openFileDialog1.FileName;


                }

            }

        private void tableLayoutPanel14_Paint(object sender, PaintEventArgs e)
            {

            }

        private void R1_CheckedChanged(object sender, EventArgs e)
            {
            rotors = "1";
            }

        private void R2_CheckedChanged(object sender, EventArgs e)
            {
            rotors = "2";
            }

        private void R3_CheckedChanged(object sender, EventArgs e)
            {
            rotors = "3";
            }

        private void R4_CheckedChanged(object sender, EventArgs e)
            {
            rotors = "4";
            }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
            {
            baseLine = "yes";
            }
        }
    }
