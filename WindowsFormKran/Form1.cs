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
            txtEingabe.Enabled = false;
            lblAusgabe.Visible = false;
        }


        public void button1_Click_1(object sender, EventArgs e)
        {
            int zahl;

            if (!int.TryParse(txtEingabe.Text, out zahl))
            {
                MessageBox.Show("Zahl max. 10!");
                txtEingabe.Focus();
                txtEingabe.SelectAll();
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) //Haken ausfahren
        {
            int zahl = 0;
            if (!int.TryParse(txtEingabe.Text, out zahl))
            {
                if ((zahl > 10) || (zahl < 0 ))
                {
                    MessageBox.Show("Eingabe max. 10!");
                    txtEingabe.Focus();
                    txtEingabe.SelectAll();
                } 
            }
            if (pnlHaken.Height < 415  && pnlHaken.Height <= pnlMast.Height-5)
            {

                pnlHaken.Height += zahl;
            }
            
        }

        private void button2_Click(object sender, EventArgs e) //haken einfahren
        {
            int zahl = 0;
            if (!int.TryParse(txtEingabe.Text, out zahl))
            {
                if ((zahl > 10) || (zahl < 0))
                {
                    MessageBox.Show("Eingabe max. 10!");
                    txtEingabe.Focus();
                    txtEingabe.SelectAll();
                }
            }
            pnlHaken.Height -= zahl;
        }

        private void button3_Click(object sender, EventArgs e) //Ausleger rausfahren
        {
            int zahl = 0;
            if (!int.TryParse(txtEingabe.Text, out zahl))
            {
                if ((zahl > 10) || (zahl < 0))
                {
                    MessageBox.Show("Eingabe max. 10!");
                    txtEingabe.Focus();
                    txtEingabe.SelectAll();
                }
            }
            if (pnlAusleger.Location.X > pnlMast.Location.X && pnlHaken.Location.X < 550) //rechte Seite
            {
                pnlAusleger.Width += zahl;
                pnlHaken.Location = new Point(pnlHaken.Location.X + zahl, pnlHaken.Location.Y);
            }


            if (pnlAusleger.Location.X < pnlMast.Location.X && pnlHaken.Location.X > 5) //linke Seite
            {
                int SizeX = pnlAusleger.Size.Width;
                if (SizeX > 30)
                    {
                        pnlAusleger.Width += zahl;
                        pnlAusleger.Location = new Point(pnlAusleger.Location.X - zahl, pnlAusleger.Location.Y);
                        pnlHaken.Location = new Point(pnlHaken.Location.X - zahl, pnlHaken.Location.Y);
                    }
                }   
        }
        private void button4_Click(object sender, EventArgs e) //Ausleger einfahren
        {
            int zahl = 0;
            if (!int.TryParse(txtEingabe.Text, out zahl))
            {
                if ((zahl > 10) || (zahl < 0))
                {
                    MessageBox.Show("Eingabe max. 10!");
                    txtEingabe.Focus();
                    txtEingabe.SelectAll();
                }
            }
            if (pnlAusleger.Location.X > pnlMast.Location.X) //rechte Seite
            {
                lblAusgabe.Visible = false;
                int SizeX = pnlAusleger.Size.Width;
                if (SizeX > 70)
                {
                    pnlAusleger.Width -= zahl;
                    pnlHaken.Location = new Point(pnlHaken.Location.X - zahl, pnlHaken.Location.Y);
                }
            }


            if (pnlAusleger.Location.X < pnlMast.Location.X) //linke Seite
            {
                int SizeX = pnlAusleger.Size.Width;
                if (SizeX > 70)
                {
                    pnlAusleger.Width -= zahl;
                    pnlAusleger.Location = new Point(pnlAusleger.Location.X + zahl, pnlAusleger.Location.Y);
                    pnlHaken.Location = new Point(pnlHaken.Location.X + zahl, pnlHaken.Location.Y);
                }
            }
        }
        private void button5_Click(object sender, EventArgs e) //Kran rechte Seite
        {
            if (pnlAusleger.Location.X < pnlMast.Location.X)
            {
                int XR = pnlAusleger.Width;
                int WechselR = XR + 30;
                pnlAusleger.Location = new Point(pnlAusleger.Location.X + WechselR, pnlAusleger.Location.Y);
                pnlHaken.Location = new Point(pnlHaken.Location.X + WechselR + XR - 20, pnlHaken.Location.Y);
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
            }
        }

        private void button7_Click(object sender, EventArgs e) //Kran ausfahren
        {
            int zahl = 0;
            if (!int.TryParse(txtEingabe.Text, out zahl))
            {
                if ((zahl > 10) || (zahl < 0))
                {
                    MessageBox.Show("Eingabe max. 10!");
                    txtEingabe.Focus();
                    txtEingabe.SelectAll();
                }
            }
            if (pnlMast.Height < 407)
            {
                pnlMast.Height += zahl;
                pnlMast.Location = new Point(pnlMast.Location.X, pnlMast.Location.Y - zahl);
                pnlHaken.Location = new Point(pnlHaken.Location.X, pnlHaken.Location.Y - zahl);
                pnlAusleger.Location = new Point(pnlAusleger.Location.X, pnlAusleger.Location.Y - zahl);
            }
            if (pnlMast.Height >= 407)
            {
                lblAusgabe.Visible = true;
                lblAusgabe.Text = "Kran zu groß!";
            }
        }

        private void button8_Click(object sender, EventArgs e) //Kran einfahren
        {
            int zahl = 0;
            if (!int.TryParse(txtEingabe.Text, out zahl))
            {
                if ((zahl > 10) || (zahl < 0))
                {
                    MessageBox.Show("Eingabe max. 10!");
                    txtEingabe.Focus();
                    txtEingabe.SelectAll();
                }
            }
            if (pnlAusleger.Location.Y < 394)
            {
                lblAusgabe.Visible = false;
                pnlMast.Height -= zahl;
                pnlMast.Location = new Point(pnlMast.Location.X, pnlMast.Location.Y + zahl);
                pnlHaken.Location = new Point(pnlHaken.Location.X, pnlHaken.Location.Y + zahl);
                pnlAusleger.Location = new Point(pnlAusleger.Location.X, pnlAusleger.Location.Y + zahl);
            }
            
        }

        private void pnlHaken_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btLinks_Click(object sender, EventArgs e)
        {
            int zahl = 0;
            if (!int.TryParse(txtEingabe.Text, out zahl))
            {
                if ((zahl > 10) || (zahl < 0))
                {
                    MessageBox.Show("Eingabe max. 10!");
                    txtEingabe.Focus();
                    txtEingabe.SelectAll();
                }
            }
            int SizeAus = pnlAusleger.Size.Width;
            if (SizeAus == 70 && pnlFundament.Location.X > 50)
            {
                lblAusgabe.Visible = false;
                pnlMast.Location = new Point(pnlMast.Location.X - zahl, pnlMast.Location.Y);
                pnlHaken.Location = new Point(pnlHaken.Location.X - zahl, pnlHaken.Location.Y);
                pnlFundament.Location = new Point(pnlFundament.Location.X - zahl, pnlFundament.Location.Y);
                pnlAusleger.Location = new Point(pnlAusleger.Location.X - zahl, pnlAusleger.Location.Y);
            }
            if(SizeAus > 70)
            {
                lblAusgabe.Visible = true;
                lblAusgabe.Text = "Ausleger einfahren!";
            }
            if(pnlFundament.Location.X <= 50)
            {
                lblAusgabe.Visible = true;
                lblAusgabe.Text = "Bitte nach rechts!";
            }
        }

        private void btRechts_Click(object sender, EventArgs e)
        {
            int zahl = 0;
            if (!int.TryParse(txtEingabe.Text, out zahl))
            {
                if ((zahl > 10) || (zahl < 0))
                {
                    MessageBox.Show("Eingabe max. 10!");
                    txtEingabe.Focus();
                    txtEingabe.SelectAll();
                }
            }
            int SizeAus = pnlAusleger.Size.Width;
            //if (SizeAus == 70 && ((pnlFundament.Location.X < 420 && pnlHaken.Location.X < 391)))
            //{
            //    lblAusgabe.Visible = false;
            //    pnlMast.Location = new Point(pnlMast.Location.X + zahl, pnlMast.Location.Y);
            //    pnlHaken.Location = new Point(pnlHaken.Location.X + zahl, pnlHaken.Location.Y);
            //    pnlFundament.Location = new Point(pnlFundament.Location.X + zahl, pnlFundament.Location.Y);
            //    pnlAusleger.Location = new Point(pnlAusleger.Location.X + zahl, pnlAusleger.Location.Y);
            //}
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
                pnlMast.Location = new Point(pnlMast.Location.X + zahl, pnlMast.Location.Y);
                pnlHaken.Location = new Point(pnlHaken.Location.X + zahl, pnlHaken.Location.Y);
                pnlFundament.Location = new Point(pnlFundament.Location.X + zahl, pnlFundament.Location.Y);
                pnlAusleger.Location = new Point(pnlAusleger.Location.X + zahl, pnlAusleger.Location.Y);
            }
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
            txtEingabe.Enabled = true;
            btExit.Enabled = false;
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
            txtEingabe.Enabled = false;
            btExit.Enabled = true;
        }

        private void txtEingabe_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
