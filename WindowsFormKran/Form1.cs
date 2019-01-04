using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormKran
{
    public partial class Form1 : Form
    {
        bool box = false;
        public Form1()
        {
            InitializeComponent();
            btAN.Enabled = true;
            button2.Enabled = false;
            btLinks.Enabled = false;
            btnHakenaus.Enabled = false;
            btRechts.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            btOFF.Enabled = false;
            lblAusgabe.Visible = false;
            button1.Enabled = false;
            timerHE.Enabled = false;
            lblHaken.BackColor = System.Drawing.Color.Transparent;
            lblO.BackColor = System.Drawing.Color.Transparent;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) //Haken ausfahren
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e) //haken einfahren
        {
            timerHE.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e) //Ausleger rausfahren
        {  
            timerAA.Enabled = true;
        }
        private void button4_Click(object sender, EventArgs e) //Ausleger einfahren
        {
            timerAE.Enabled = true;
        }
        private void button5_Click(object sender, EventArgs e) //Kran rechte Seite
        {
            if (pnlAusleger.Location.X < pnlMast.Location.X)
            {
                int XR = pnlAusleger.Width;
                int WechselR = XR + 30;
                pnlAusleger.Location = new Point(pnlAusleger.Location.X + WechselR, pnlAusleger.Location.Y);
                pnlHaken.Location = new Point(pnlHaken.Location.X + WechselR + XR - 20, pnlHaken.Location.Y);
                lblHaken.Location = new Point(lblHaken.Location.X + WechselR + XR - 20, lblHaken.Location.Y);

                if (box)
                {
                    pnlBox.Location = new Point(pnlBox.Location.X + WechselR + XR - 20, pnlBox.Location.Y);
                    lblO.Location = new Point(lblO.Location.X + WechselR + XR - 20, lblO.Location.Y);
                }

            }
        }

        private void button6_Click(object sender, EventArgs e) //Kran linke Seite
        {
            if (pnlAusleger.Location.X > pnlMast.Location.X)
            {
                int XR = pnlAusleger.Width;
                int WechselR = XR + 30;
                pnlAusleger.Location = new Point(pnlAusleger.Location.X - WechselR, pnlAusleger.Location.Y);
                pnlHaken.Location = new Point(pnlHaken.Location.X - WechselR - XR + 20, pnlHaken.Location.Y);
                lblHaken.Location = new Point(lblHaken.Location.X - WechselR - XR + 20, lblHaken.Location.Y);

                if (box)
                {
                    pnlBox.Location = new Point(pnlBox.Location.X - WechselR - XR + 20, pnlBox.Location.Y);
                    lblO.Location = new Point(lblO.Location.X - WechselR - XR + 20, lblO.Location.Y);
                }

            }
        }

        private void button7_Click(object sender, EventArgs e) //Kran ausfahren
        {
            timerKA.Enabled = true;
        }

        private void button8_Click(object sender, EventArgs e) //Kran einfahren
        {
            timerKE.Enabled = true;
        }

        private void pnlHaken_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btLinks_Click(object sender, EventArgs e)
        {
            timerL.Enabled = true;
        }

        private void btRechts_Click(object sender, EventArgs e)
        {
            timerR.Enabled = true;
        }

        private void btAN_Click(object sender, EventArgs e)
        {
            btAN.Enabled = false;
            button2.Enabled = true;
            btLinks.Enabled = true;
            btnHakenaus.Enabled = true;
            btRechts.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            btOFF.Enabled = true;
            btExit.Enabled = false;
            button1.Enabled = true;
        }

        private void btOFF_Click(object sender, EventArgs e)
        {
            lblAusgabe.Visible = false;
            btAN.Enabled = true;
            button2.Enabled = false;
            btLinks.Enabled = false;
            btnHakenaus.Enabled = false;
            btRechts.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            btOFF.Enabled = false;
            btExit.Enabled = true;
            button1.Enabled = false;
            lblAusgabe.Visible = false;
            timer1.Enabled = false;
            timerHE.Enabled = false;
            timerAA.Enabled = false;
            timerAE.Enabled = false;
            timerKA.Enabled = false;
            timerKE.Enabled = false;
            timerL.Enabled = false;
            timerR.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e) //Haken ausfahren
        {
            if (pnlHaken.Height < 415 && pnlHaken.Height <= pnlMast.Height - 1)
            {
                pnlHaken.Height += 1;
                lblHaken.Location = new Point(lblHaken.Location.X, lblHaken.Location.Y + 1);
            }
            if (box)
            {
                pnlBox.Location = new Point(pnlBox.Location.X, pnlBox.Location.Y + 1);
                lblO.Location = new Point(lblO.Location.X, lblO.Location.Y + 1);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)//Stoppen aller Timer
        {
            lblAusgabe.Visible = false;
            timer1.Enabled = false;
            timerHE.Enabled = false;
            timerAA.Enabled = false;
            timerAE.Enabled = false;
            timerKA.Enabled = false;
            timerKE.Enabled = false;
            timerL.Enabled = false;
            timerR.Enabled = false;
        }

        private void timerHE_Tick(object sender, EventArgs e)//Haken einfahren
        {
            pnlHaken.Height -= 1;
            lblHaken.Location = new Point(lblHaken.Location.X, lblHaken.Location.Y - 1);
            if (pnlHaken.Height == 1)
            {
                timerHE.Enabled = false;
            }

            if (box)
            {
                pnlBox.Location = new Point(pnlBox.Location.X, pnlBox.Location.Y - 1);
                lblO.Location = new Point(lblO.Location.X, lblO.Location.Y - 1);
            }
        }

        private void timerAA_Tick(object sender, EventArgs e)//Ausleger ausfahren
        {
            if (pnlAusleger.Width <= 140)
            {         
            if (pnlAusleger.Location.X > pnlMast.Location.X && pnlHaken.Location.X < 550) //rechte Seite
            {
                pnlAusleger.Width += 1;
                pnlHaken.Location = new Point(pnlHaken.Location.X + 1, pnlHaken.Location.Y);
                lblHaken.Location = new Point(lblHaken.Location.X + 1, lblHaken.Location.Y);

                    if (box)
                    {
                        pnlBox.Location = new Point(pnlBox.Location.X + 1, pnlBox.Location.Y);
                        lblO.Location = new Point(lblO.Location.X + 1, lblO.Location.Y);
                    }
                
            }


            if (pnlAusleger.Location.X < pnlMast.Location.X && pnlHaken.Location.X > 5) //linke Seite
            {
                int SizeX = pnlAusleger.Size.Width;
                if (SizeX > 30)
                {
                    pnlAusleger.Width += 1;
                    pnlAusleger.Location = new Point(pnlAusleger.Location.X - 1, pnlAusleger.Location.Y);
                    pnlHaken.Location = new Point(pnlHaken.Location.X - 1, pnlHaken.Location.Y);
                    lblHaken.Location = new Point(lblHaken.Location.X - 1, lblHaken.Location.Y);

                        if (box)
                        {
                            pnlBox.Location = new Point(pnlBox.Location.X - 1, pnlBox.Location.Y);
                            lblO.Location = new Point(lblO.Location.X - 1, lblO.Location.Y);
                        }

                }
            }
            }

        }

        private void timerAE_Tick(object sender, EventArgs e)
        {
            if (pnlAusleger.Location.X > pnlMast.Location.X) //rechte Seite
            {
                lblAusgabe.Visible = false;
                int SizeX = pnlAusleger.Size.Width;
                if (SizeX > 70)
                {
                    pnlAusleger.Width -= 1;
                    pnlHaken.Location = new Point(pnlHaken.Location.X - 1, pnlHaken.Location.Y);
                    lblHaken.Location = new Point(lblHaken.Location.X - 1, lblHaken.Location.Y);

                    if (box)
                    {
                        pnlBox.Location = new Point(pnlBox.Location.X - 1, pnlBox.Location.Y);
                        lblO.Location = new Point(lblO.Location.X - 1, lblO.Location.Y);
                    }

                }
            }


            if (pnlAusleger.Location.X < pnlMast.Location.X) //linke Seite
            {
                int SizeX = pnlAusleger.Size.Width;
                if (SizeX > 70)
                {
                    pnlAusleger.Width -= 1;
                    pnlAusleger.Location = new Point(pnlAusleger.Location.X + 1, pnlAusleger.Location.Y);
                    pnlHaken.Location = new Point(pnlHaken.Location.X + 1, pnlHaken.Location.Y);
                    lblHaken.Location = new Point(lblHaken.Location.X + 1, lblHaken.Location.Y);

                    if (box)
                    {
                        pnlBox.Location = new Point(pnlBox.Location.X + 1, pnlBox.Location.Y);
                        lblO.Location = new Point(lblO.Location.X + 1, lblO.Location.Y);
                    }

                }
            }
        }

        private void timerKA_Tick(object sender, EventArgs e)//Kran ausfahren
        {
            if (pnlMast.Height < 407)
            {
                pnlMast.Height += 1;
                pnlMast.Location = new Point(pnlMast.Location.X, pnlMast.Location.Y - 1);
                pnlHaken.Location = new Point(pnlHaken.Location.X, pnlHaken.Location.Y - 1);
                pnlAusleger.Location = new Point(pnlAusleger.Location.X, pnlAusleger.Location.Y - 1);
                lblHaken.Location = new Point(lblHaken.Location.X, lblHaken.Location.Y - 1);

                if (box)
                {
                    pnlBox.Location = new Point(pnlBox.Location.X, pnlBox.Location.Y - 1);
                    lblO.Location = new Point(lblO.Location.X, lblO.Location.Y - 1);
                }

            }
            if (pnlMast.Height >= 407)
            {
                lblAusgabe.Visible = true;
                lblAusgabe.Text = "Kran zu groß!";
            }
        }

        private void timerKE_Tick(object sender, EventArgs e)//Kran einfahren
        {
            if (pnlAusleger.Location.Y < 394)
            {
                lblAusgabe.Visible = false;
                pnlMast.Height -= 1;
                pnlMast.Location = new Point(pnlMast.Location.X, pnlMast.Location.Y + 1);
                pnlHaken.Location = new Point(pnlHaken.Location.X, pnlHaken.Location.Y + 1);
                pnlAusleger.Location = new Point(pnlAusleger.Location.X, pnlAusleger.Location.Y + 1);
                lblHaken.Location = new Point(lblHaken.Location.X, lblHaken.Location.Y + 1);

                if (box)
                {
                    pnlBox.Location = new Point(pnlBox.Location.X, pnlBox.Location.Y + 1);
                    lblO.Location = new Point(lblO.Location.X, lblO.Location.Y + 1);
                }

            }
        }

        private void timerL_Tick(object sender, EventArgs e)
        {
            int SizeAus = pnlAusleger.Size.Width;
            if (SizeAus == 70 && pnlFundament.Location.X > 50)
            {
                lblAusgabe.Visible = false;
                pnlMast.Location = new Point(pnlMast.Location.X - 1, pnlMast.Location.Y);
                pnlHaken.Location = new Point(pnlHaken.Location.X - 1, pnlHaken.Location.Y);
                pnlFundament.Location = new Point(pnlFundament.Location.X - 1, pnlFundament.Location.Y);
                pnlAusleger.Location = new Point(pnlAusleger.Location.X - 1, pnlAusleger.Location.Y);
                lblHaken.Location = new Point(lblHaken.Location.X - 1, lblHaken.Location.Y);

                if (box)
                {
                    pnlBox.Location = new Point(pnlBox.Location.X - 1, pnlBox.Location.Y);
                    lblO.Location = new Point(lblO.Location.X - 1, lblO.Location.Y);
                }

            }
            if (SizeAus > 70)
            {
                lblAusgabe.Visible = true;
                lblAusgabe.Text = "Ausleger einfahren!";
            }
            if (pnlFundament.Location.X <= 50)
            {
                lblAusgabe.Visible = true;
                lblAusgabe.Text = "Bitte nach rechts!";
            }
        }

        private void timerR_Tick(object sender, EventArgs e)
        {
            int SizeAus = pnlAusleger.Size.Width;
            if (SizeAus > 70)
            {
                lblAusgabe.Visible = true;
                lblAusgabe.Text = "Ausleger einfahren!";
            }
            if (pnlFundament.Location.X >= 420)
            {
                lblAusgabe.Visible = true;
                lblAusgabe.Text = "Bitte nach links!";
            }

            if (SizeAus == 70 && (((pnlHaken.Location.X > 5 && pnlHaken.Location.X < 391) && (pnlHaken.Location.Y > 5 && pnlHaken.Location.Y < 420)) ||
               ((pnlHaken.Location.X >= 5 && pnlHaken.Location.X < 464) && (pnlHaken.Location.Y > 225 && pnlHaken.Location.Y < 420))))
            {
                lblAusgabe.Visible = false;
                pnlMast.Location = new Point(pnlMast.Location.X + 1, pnlMast.Location.Y);
                pnlHaken.Location = new Point(pnlHaken.Location.X + 1, pnlHaken.Location.Y);
                pnlFundament.Location = new Point(pnlFundament.Location.X + 1, pnlFundament.Location.Y);
                pnlAusleger.Location = new Point(pnlAusleger.Location.X + 1, pnlAusleger.Location.Y);
                lblHaken.Location = new Point(lblHaken.Location.X + 1, lblHaken.Location.Y);

                if (box)
                {
                    pnlBox.Location = new Point(pnlBox.Location.X + 1, pnlBox.Location.Y);
                    lblO.Location = new Point(lblO.Location.X + 1, lblO.Location.Y);
                }
            }
        }

        private void btGreif_Click(object sender, EventArgs e)
        {
            if (lblO.Bounds.IntersectsWith(lblHaken.Bounds))
            {
                lblAusgabe.Visible = true;
                lblAusgabe.Text = "Angekoppelt!";
                box = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            box = false;
            if (pnlBox.Location.Y < 424)
            {
                timerBox.Enabled = true;
            }
        }

        private void timerBox_Tick(object sender, EventArgs e)
        {
            if (pnlBox.Location.Y < 424)
            {
                pnlBox.Location = new Point(pnlBox.Location.X, pnlBox.Location.Y + 1);
                lblO.Location = new Point(lblO.Location.X, lblO.Location.Y + 1);
            }
            if (pnlBox.Location.Y >= 424)
            {
                timerBox.Enabled = false;
            }
        }
    }
}