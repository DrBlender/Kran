﻿namespace WindowsFormKran
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlFundament = new System.Windows.Forms.Panel();
            this.pnlMast = new System.Windows.Forms.Panel();
            this.pnlAusleger = new System.Windows.Forms.Panel();
            this.pnlHaken = new System.Windows.Forms.Panel();
            this.btnHakenaus = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btLinks = new System.Windows.Forms.Button();
            this.btRechts = new System.Windows.Forms.Button();
            this.lblAusgabe = new System.Windows.Forms.Label();
            this.btAN = new System.Windows.Forms.Button();
            this.btOFF = new System.Windows.Forms.Button();
            this.txtEingabe = new System.Windows.Forms.TextBox();
            this.pnlBox = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFundament
            // 
            this.pnlFundament.BackColor = System.Drawing.Color.Red;
            this.pnlFundament.Location = new System.Drawing.Point(177, 419);
            this.pnlFundament.Name = "pnlFundament";
            this.pnlFundament.Size = new System.Drawing.Size(125, 30);
            this.pnlFundament.TabIndex = 0;
            // 
            // pnlMast
            // 
            this.pnlMast.BackColor = System.Drawing.Color.Yellow;
            this.pnlMast.Location = new System.Drawing.Point(225, 119);
            this.pnlMast.Name = "pnlMast";
            this.pnlMast.Size = new System.Drawing.Size(30, 300);
            this.pnlMast.TabIndex = 1;
            // 
            // pnlAusleger
            // 
            this.pnlAusleger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pnlAusleger.Location = new System.Drawing.Point(255, 119);
            this.pnlAusleger.Name = "pnlAusleger";
            this.pnlAusleger.Size = new System.Drawing.Size(100, 20);
            this.pnlAusleger.TabIndex = 2;
            // 
            // pnlHaken
            // 
            this.pnlHaken.BackColor = System.Drawing.Color.Red;
            this.pnlHaken.Location = new System.Drawing.Point(335, 139);
            this.pnlHaken.Name = "pnlHaken";
            this.pnlHaken.Size = new System.Drawing.Size(20, 50);
            this.pnlHaken.TabIndex = 3;
            this.pnlHaken.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHaken_Paint);
            // 
            // btnHakenaus
            // 
            this.btnHakenaus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHakenaus.Location = new System.Drawing.Point(597, 48);
            this.btnHakenaus.Name = "btnHakenaus";
            this.btnHakenaus.Size = new System.Drawing.Size(191, 30);
            this.btnHakenaus.TabIndex = 4;
            this.btnHakenaus.Text = "Haken ausfahren";
            this.btnHakenaus.UseVisualStyleBackColor = true;
            this.btnHakenaus.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(597, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "Haken einfahren";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(597, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 30);
            this.button3.TabIndex = 6;
            this.button3.Text = "Ausleger ausfahren";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(597, 120);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(191, 30);
            this.button4.TabIndex = 7;
            this.button4.Text = "Ausleger einfahren";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(13, 163);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(191, 30);
            this.button5.TabIndex = 8;
            this.button5.Text = "Kran rechte Seite";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(13, 199);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(191, 30);
            this.button6.TabIndex = 9;
            this.button6.Text = "Kran linke Seite";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(597, 228);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(191, 30);
            this.button7.TabIndex = 10;
            this.button7.Text = "Kran ausfahren";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(597, 264);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(191, 30);
            this.button8.TabIndex = 11;
            this.button8.Text = "Kran einfahren";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Red;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btExit.Location = new System.Drawing.Point(61, 400);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(92, 30);
            this.btExit.TabIndex = 12;
            this.btExit.Text = "Beenden";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.txtEingabe);
            this.panel1.Controls.Add(this.btOFF);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.btAN);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.lblAusgabe);
            this.panel1.Controls.Add(this.btRechts);
            this.panel1.Controls.Add(this.btLinks);
            this.panel1.Controls.Add(this.btExit);
            this.panel1.Location = new System.Drawing.Point(584, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 453);
            this.panel1.TabIndex = 13;
            // 
            // btLinks
            // 
            this.btLinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLinks.Location = new System.Drawing.Point(13, 304);
            this.btLinks.Name = "btLinks";
            this.btLinks.Size = new System.Drawing.Size(60, 60);
            this.btLinks.TabIndex = 14;
            this.btLinks.Text = "←";
            this.btLinks.UseVisualStyleBackColor = true;
            this.btLinks.Click += new System.EventHandler(this.btLinks_Click);
            // 
            // btRechts
            // 
            this.btRechts.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRechts.Location = new System.Drawing.Point(144, 304);
            this.btRechts.Name = "btRechts";
            this.btRechts.Size = new System.Drawing.Size(60, 60);
            this.btRechts.TabIndex = 15;
            this.btRechts.Text = "→";
            this.btRechts.UseVisualStyleBackColor = true;
            this.btRechts.Click += new System.EventHandler(this.btRechts_Click);
            // 
            // lblAusgabe
            // 
            this.lblAusgabe.AutoSize = true;
            this.lblAusgabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAusgabe.ForeColor = System.Drawing.Color.Red;
            this.lblAusgabe.Location = new System.Drawing.Point(13, 364);
            this.lblAusgabe.Name = "lblAusgabe";
            this.lblAusgabe.Size = new System.Drawing.Size(194, 24);
            this.lblAusgabe.TabIndex = 16;
            this.lblAusgabe.Text = "Ausleger einfahren!";
            this.lblAusgabe.Visible = false;
            // 
            // btAN
            // 
            this.btAN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btAN.Location = new System.Drawing.Point(6, 400);
            this.btAN.Name = "btAN";
            this.btAN.Size = new System.Drawing.Size(50, 42);
            this.btAN.TabIndex = 17;
            this.btAN.UseVisualStyleBackColor = false;
            this.btAN.Click += new System.EventHandler(this.btAN_Click);
            // 
            // btOFF
            // 
            this.btOFF.BackColor = System.Drawing.Color.Red;
            this.btOFF.Location = new System.Drawing.Point(155, 400);
            this.btOFF.Name = "btOFF";
            this.btOFF.Size = new System.Drawing.Size(50, 42);
            this.btOFF.TabIndex = 18;
            this.btOFF.UseVisualStyleBackColor = false;
            this.btOFF.Click += new System.EventHandler(this.btOFF_Click);
            // 
            // txtEingabe
            // 
            this.txtEingabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEingabe.Location = new System.Drawing.Point(79, 305);
            this.txtEingabe.Name = "txtEingabe";
            this.txtEingabe.Size = new System.Drawing.Size(60, 58);
            this.txtEingabe.TabIndex = 14;
            this.txtEingabe.TextChanged += new System.EventHandler(this.txtEingabe_TextChanged);
            // 
            // pnlBox
            // 
            this.pnlBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pnlBox.Location = new System.Drawing.Point(12, 424);
            this.pnlBox.Name = "pnlBox";
            this.pnlBox.Size = new System.Drawing.Size(25, 25);
            this.pnlBox.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(481, 424);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(81, 24);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(410, -4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(173, 229);
            this.panel3.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnHakenaus);
            this.Controls.Add(this.pnlHaken);
            this.Controls.Add(this.pnlAusleger);
            this.Controls.Add(this.pnlMast);
            this.Controls.Add(this.pnlFundament);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBox);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Kran";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFundament;
        private System.Windows.Forms.Panel pnlMast;
        private System.Windows.Forms.Panel pnlAusleger;
        private System.Windows.Forms.Panel pnlHaken;
        private System.Windows.Forms.Button btnHakenaus;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAusgabe;
        private System.Windows.Forms.Button btRechts;
        private System.Windows.Forms.Button btLinks;
        private System.Windows.Forms.Button btOFF;
        private System.Windows.Forms.Button btAN;
        private System.Windows.Forms.TextBox txtEingabe;
        private System.Windows.Forms.Panel pnlBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

