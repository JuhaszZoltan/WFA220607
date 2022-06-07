using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA220607
{
    public partial class FrmMain : Form
    {
        static Random rnd = new Random();

        static Color[] szinek = {
            Color.Red,
            Color.Blue,
            Color.Yellow,
            Color.Purple,
            Color.Green,
            Color.Cyan,
            Color.Pink,
            Color.Brown,
            Color.Orange,
            Color.Black };


        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnKoszon_Click(object sender, EventArgs e)
        {
            if (btnKoszon.Text == "Köszönj!")
            {
                if (string.IsNullOrEmpty(tbNev.Text))
                {
                    DialogResult res = MessageBox.Show(
                        caption: "FIGYELMEZTETÉS!",
                        text: "Nem írtad be a neved!\nDirekt csináltad?",
                        icon: MessageBoxIcon.Warning,
                        buttons: MessageBoxButtons.YesNo);

                    if (res == DialogResult.No)
                    {
                        MessageBox.Show("Akkor írd be!");
                    }
                    else
                    {
                        MessageBox.Show("Akkor csapassuk!");
                        btnKoszon.Text = "Click me!";
                    }
                }
                else
                {
                    MessageBox.Show($"Szia {tbNev.Text}!");
                }
            }
            else
            {
                btnKoszon.Text = "KATT HA PIROS!";
                if (!tmr.Enabled)
                {
                    tmr.Start();
                }
                else
                {
                    if(this.BackColor == Color.Red)
                    {
                        tmr.Stop();
                        MessageBox.Show("NYERTÉL!");
                    }
                    else
                    {
                        tmr.Stop();
                        MessageBox.Show("BUMM!!!");
                        Application.Exit();
                    }
                }
            }
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            this.BackColor = szinek[rnd.Next(szinek.Length)];


            //this.BackColor = Color.FromArgb(
            //        red: rnd.Next(256),
            //        green: rnd.Next(256),
            //        blue: rnd.Next(256));
        }
    }
}
