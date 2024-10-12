using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTT_Magui_Anca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        int jucator = 1;
        private void btn_1_Click(object sender, EventArgs e)
        {
            if (btn_1.Text == "")
            {
                jucator++;
                if (jucator % 2 == 0)
                    btn_1.Text = "X";
                else
                    btn_1.Text = "0";
            }
            if (btn_1.Text == btn_2.Text & btn_2.Text == btn_3.Text & btn_3.Text!=""||
                btn_4.Text == btn_5.Text & btn_5.Text == btn_6.Text &btn_5.Text != "" ||
                btn_7.Text == btn_8.Text & btn_8.Text == btn_9.Text &btn_7.Text != "" ||
               
                btn_1.Text == btn_4.Text & btn_4.Text == btn_7.Text &btn_4.Text != "" ||
                btn_2.Text == btn_5.Text & btn_5.Text == btn_8.Text & btn_8.Text != "" ||
                btn_3.Text == btn_6.Text & btn_6.Text == btn_9.Text & btn_6.Text != "" ||

                btn_1.Text == btn_5.Text & btn_5.Text == btn_9.Text & btn_9.Text != "" ||
                btn_3.Text == btn_5.Text & btn_5.Text == btn_7.Text& btn_3.Text!= "")

                MessageBox.Show ("A castigat "+btn_1.Text);
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (btn_2.Text == "")
            {
                jucator++;
                if (jucator % 2 == 0)
                    btn_2.Text = "X";
                else
                    btn_2.Text = "0";
            }
            if(btn_1.Text == btn_2.Text & btn_2.Text == btn_3.Text & btn_3.Text != "" ||
                btn_4.Text == btn_5.Text & btn_5.Text == btn_6.Text & btn_5.Text != "" ||
                btn_7.Text == btn_8.Text & btn_8.Text == btn_9.Text & btn_7.Text != "" ||

                btn_1.Text == btn_4.Text & btn_4.Text == btn_7.Text & btn_4.Text != "" ||
                btn_2.Text == btn_5.Text & btn_5.Text == btn_8.Text & btn_8.Text != "" ||
                btn_3.Text == btn_6.Text & btn_6.Text == btn_9.Text & btn_6.Text != "" ||

                btn_1.Text == btn_5.Text & btn_5.Text == btn_9.Text & btn_9.Text != "" ||
                btn_3.Text == btn_5.Text & btn_5.Text == btn_7.Text & btn_3.Text != "")

                MessageBox.Show("A castigat " + btn_2.Text);
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (btn_3.Text == "")
            {
                jucator++;
                if (jucator % 2 == 0)
                    btn_3.Text = "X";
                else
                    btn_3.Text = "0";
            }
            if (btn_1.Text == btn_2.Text & btn_2.Text == btn_3.Text & btn_3.Text != "" ||
                btn_4.Text == btn_5.Text & btn_5.Text == btn_6.Text & btn_5.Text != "" ||
                btn_7.Text == btn_8.Text & btn_8.Text == btn_9.Text & btn_7.Text != "" ||

                btn_1.Text == btn_4.Text & btn_4.Text == btn_7.Text & btn_4.Text != "" ||
                btn_2.Text == btn_5.Text & btn_5.Text == btn_8.Text & btn_8.Text != "" ||
                btn_3.Text == btn_6.Text & btn_6.Text == btn_9.Text & btn_6.Text != "" ||

                btn_1.Text == btn_5.Text & btn_5.Text == btn_9.Text & btn_9.Text != "" ||
                btn_3.Text == btn_5.Text & btn_5.Text == btn_7.Text & btn_3.Text != "")

                MessageBox.Show("A castigat " + btn_3.Text);
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (btn_4.Text == "")
            {
                jucator++;
                if (jucator % 2 == 0)
                    btn_4.Text = "X";
                else
                    btn_4.Text = "0";
            }
            if (btn_1.Text == btn_2.Text & btn_2.Text == btn_3.Text & btn_3.Text != "" ||
                 btn_4.Text == btn_5.Text & btn_5.Text == btn_6.Text & btn_5.Text != "" ||
                 btn_7.Text == btn_8.Text & btn_8.Text == btn_9.Text & btn_7.Text != "" ||

                 btn_1.Text == btn_4.Text & btn_4.Text == btn_7.Text & btn_4.Text != "" ||
                 btn_2.Text == btn_5.Text & btn_5.Text == btn_8.Text & btn_8.Text != "" ||
                 btn_3.Text == btn_6.Text & btn_6.Text == btn_9.Text & btn_6.Text != "" ||

                 btn_1.Text == btn_5.Text & btn_5.Text == btn_9.Text & btn_9.Text != "" ||
                 btn_3.Text == btn_5.Text & btn_5.Text == btn_7.Text & btn_3.Text != "")

                MessageBox.Show("A castigat " + btn_4.Text);
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (btn_5.Text == "")
            {
                jucator++;
                if (jucator % 2 == 0)
                    btn_5.Text = "X";
                else
                    btn_5.Text = "0";
            }
            if (btn_1.Text == btn_2.Text & btn_2.Text == btn_3.Text & btn_3.Text != "" ||
                 btn_4.Text == btn_5.Text & btn_5.Text == btn_6.Text & btn_5.Text != "" ||
                 btn_7.Text == btn_8.Text & btn_8.Text == btn_9.Text & btn_7.Text != "" ||

                 btn_1.Text == btn_4.Text & btn_4.Text == btn_7.Text & btn_4.Text != "" ||
                 btn_2.Text == btn_5.Text & btn_5.Text == btn_8.Text & btn_8.Text != "" ||
                 btn_3.Text == btn_6.Text & btn_6.Text == btn_9.Text & btn_6.Text != "" ||

                 btn_1.Text == btn_5.Text & btn_5.Text == btn_9.Text & btn_9.Text != "" ||
                 btn_3.Text == btn_5.Text & btn_5.Text == btn_7.Text & btn_3.Text != "")

                MessageBox.Show("A castigat " + btn_5.Text);
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (btn_6.Text == "")
            {
                jucator++;
                if (jucator % 2 == 0)
                    btn_6.Text = "X";
                else
                    btn_6.Text = "0";
            }
            if (btn_1.Text == btn_2.Text & btn_2.Text == btn_3.Text & btn_3.Text != "" ||
                btn_4.Text == btn_5.Text & btn_5.Text == btn_6.Text & btn_5.Text != "" ||
                btn_7.Text == btn_8.Text & btn_8.Text == btn_9.Text & btn_7.Text != "" ||

                btn_1.Text == btn_4.Text & btn_4.Text == btn_7.Text & btn_4.Text != "" ||
                btn_2.Text == btn_5.Text & btn_5.Text == btn_8.Text & btn_8.Text != "" ||
                btn_3.Text == btn_6.Text & btn_6.Text == btn_9.Text & btn_6.Text != "" ||

                btn_1.Text == btn_5.Text & btn_5.Text == btn_9.Text & btn_9.Text != "" ||
                btn_3.Text == btn_5.Text & btn_5.Text == btn_7.Text & btn_3.Text != "")

                MessageBox.Show("A castigat " + btn_6.Text);
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (btn_7.Text == "")
            {
                jucator++;
                if (jucator % 2 == 0)
                    btn_7.Text = "X";
                else
                    btn_7.Text = "0";
            }
            if (btn_1.Text == btn_2.Text & btn_2.Text == btn_3.Text & btn_3.Text != "" ||
                 btn_4.Text == btn_5.Text & btn_5.Text == btn_6.Text & btn_5.Text != "" ||
                 btn_7.Text == btn_8.Text & btn_8.Text == btn_9.Text & btn_7.Text != "" ||

                 btn_1.Text == btn_4.Text & btn_4.Text == btn_7.Text & btn_4.Text != "" ||
                 btn_2.Text == btn_5.Text & btn_5.Text == btn_8.Text & btn_8.Text != "" ||
                 btn_3.Text == btn_6.Text & btn_6.Text == btn_9.Text & btn_6.Text != "" ||

                 btn_1.Text == btn_5.Text & btn_5.Text == btn_9.Text & btn_9.Text != "" ||
                 btn_3.Text == btn_5.Text & btn_5.Text == btn_7.Text & btn_3.Text != "")

                MessageBox.Show("A castigat " + btn_7.Text);

        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (btn_8.Text == "")
            {
                jucator++;
                if (jucator % 2 == 0)
                    btn_8.Text = "X";
                else
                    btn_8.Text = "0";
            }
            if (btn_1.Text == btn_2.Text & btn_2.Text == btn_3.Text & btn_3.Text != "" ||
                btn_4.Text == btn_5.Text & btn_5.Text == btn_6.Text & btn_5.Text != "" ||
                btn_7.Text == btn_8.Text & btn_8.Text == btn_9.Text & btn_7.Text != "" ||

                btn_1.Text == btn_4.Text & btn_4.Text == btn_7.Text & btn_4.Text != "" ||
                btn_2.Text == btn_5.Text & btn_5.Text == btn_8.Text & btn_8.Text != "" ||
                btn_3.Text == btn_6.Text & btn_6.Text == btn_9.Text & btn_6.Text != "" ||

                btn_1.Text == btn_5.Text & btn_5.Text == btn_9.Text & btn_9.Text != "" ||
                btn_3.Text == btn_5.Text & btn_5.Text == btn_7.Text & btn_3.Text != "")

                MessageBox.Show("A castigat " + btn_8.Text);
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (btn_9.Text == "")
            {
                jucator++;
                if (jucator % 2 == 0)
                    btn_9.Text = "X";
                else
                    btn_9.Text = "0";
            }
            if (btn_1.Text == btn_2.Text & btn_2.Text == btn_3.Text & btn_3.Text != "" ||
                btn_4.Text == btn_5.Text & btn_5.Text == btn_6.Text & btn_5.Text != "" ||
                btn_7.Text == btn_8.Text & btn_8.Text == btn_9.Text & btn_7.Text != "" ||

                btn_1.Text == btn_4.Text & btn_4.Text == btn_7.Text & btn_4.Text != "" ||
                btn_2.Text == btn_5.Text & btn_5.Text == btn_8.Text & btn_8.Text != "" ||
                btn_3.Text == btn_6.Text & btn_6.Text == btn_9.Text & btn_6.Text != "" ||

                btn_1.Text == btn_5.Text & btn_5.Text == btn_9.Text & btn_9.Text != "" ||
                btn_3.Text == btn_5.Text & btn_5.Text == btn_7.Text & btn_3.Text != "")

                MessageBox.Show("A castigat " + btn_9.Text);
        }

        private void btn_i_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            btn_1.Text = "";
            btn_2.Text = "";
            btn_3.Text = "";
            btn_4.Text = "";
            btn_5.Text = "";
            btn_6.Text = "";
            btn_7.Text = "";
            btn_8.Text = "";
            btn_9.Text = "";
        }
    }
}
