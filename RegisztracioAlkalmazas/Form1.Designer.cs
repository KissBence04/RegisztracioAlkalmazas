namespace RegisztracioAlkalmazas
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lblNev = new System.Windows.Forms.Label();
            this.lblSzulDatum = new System.Windows.Forms.Label();
            this.lblNem = new System.Windows.Forms.Label();
            this.lblHobbi = new System.Windows.Forms.Label();
            this.lblUjHobbi = new System.Windows.Forms.Label();
            this.rBttnFerfi = new System.Windows.Forms.RadioButton();
            this.rBtnNo = new System.Windows.Forms.RadioButton();
            this.tBoxNev = new System.Windows.Forms.TextBox();
            this.tBoxSzulDatum = new System.Windows.Forms.TextBox();
            this.tBoxUjHobbi = new System.Windows.Forms.TextBox();
            this.LBoxHobbi = new System.Windows.Forms.ListBox();
            this.btnHozzad = new System.Windows.Forms.Button();
            this.btnMentes = new System.Windows.Forms.Button();
            this.btnBeltolt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk_1);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Szoveges Fajl (.txt)|*.txt|Minden Fajl|*";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk_1);
            // 
            // lblNev
            // 
            this.lblNev.AutoSize = true;
            this.lblNev.Location = new System.Drawing.Point(39, 41);
            this.lblNev.Name = "lblNev";
            this.lblNev.Size = new System.Drawing.Size(30, 13);
            this.lblNev.TabIndex = 0;
            this.lblNev.Text = "Név:";
            // 
            // lblSzulDatum
            // 
            this.lblSzulDatum.AutoSize = true;
            this.lblSzulDatum.Location = new System.Drawing.Point(39, 95);
            this.lblSzulDatum.Name = "lblSzulDatum";
            this.lblSzulDatum.Size = new System.Drawing.Size(65, 13);
            this.lblSzulDatum.TabIndex = 1;
            this.lblSzulDatum.Text = "Szül. dátum:";
            // 
            // lblNem
            // 
            this.lblNem.AutoSize = true;
            this.lblNem.Location = new System.Drawing.Point(39, 149);
            this.lblNem.Name = "lblNem";
            this.lblNem.Size = new System.Drawing.Size(32, 13);
            this.lblNem.TabIndex = 2;
            this.lblNem.Text = "Nem:";
            // 
            // lblHobbi
            // 
            this.lblHobbi.AutoSize = true;
            this.lblHobbi.Location = new System.Drawing.Point(478, 41);
            this.lblHobbi.Name = "lblHobbi";
            this.lblHobbi.Size = new System.Drawing.Size(82, 13);
            this.lblHobbi.TabIndex = 3;
            this.lblHobbi.Text = "Kedvenc hobbi:";
            // 
            // lblUjHobbi
            // 
            this.lblUjHobbi.AutoSize = true;
            this.lblUjHobbi.Location = new System.Drawing.Point(405, 196);
            this.lblUjHobbi.Name = "lblUjHobbi";
            this.lblUjHobbi.Size = new System.Drawing.Size(49, 13);
            this.lblUjHobbi.TabIndex = 4;
            this.lblUjHobbi.Text = "Új hobbi:";
            // 
            // rBttnFerfi
            // 
            this.rBttnFerfi.AutoSize = true;
            this.rBttnFerfi.Location = new System.Drawing.Point(141, 149);
            this.rBttnFerfi.Name = "rBttnFerfi";
            this.rBttnFerfi.Size = new System.Drawing.Size(31, 17);
            this.rBttnFerfi.TabIndex = 5;
            this.rBttnFerfi.TabStop = true;
            this.rBttnFerfi.Text = "F";
            this.rBttnFerfi.UseVisualStyleBackColor = true;
            // 
            // rBtnNo
            // 
            this.rBtnNo.AutoSize = true;
            this.rBtnNo.Location = new System.Drawing.Point(219, 149);
            this.rBtnNo.Name = "rBtnNo";
            this.rBtnNo.Size = new System.Drawing.Size(33, 17);
            this.rBtnNo.TabIndex = 6;
            this.rBtnNo.TabStop = true;
            this.rBtnNo.Text = "N";
            this.rBtnNo.UseVisualStyleBackColor = true;
            // 
            // tBoxNev
            // 
            this.tBoxNev.Location = new System.Drawing.Point(141, 38);
            this.tBoxNev.Name = "tBoxNev";
            this.tBoxNev.Size = new System.Drawing.Size(100, 20);
            this.tBoxNev.TabIndex = 7;
            this.tBoxNev.TextChanged += new System.EventHandler(this.tBoxNev_TextChanged);
            // 
            // tBoxSzulDatum
            // 
            this.tBoxSzulDatum.Location = new System.Drawing.Point(141, 92);
            this.tBoxSzulDatum.Name = "tBoxSzulDatum";
            this.tBoxSzulDatum.Size = new System.Drawing.Size(100, 20);
            this.tBoxSzulDatum.TabIndex = 8;
            this.tBoxSzulDatum.TextChanged += new System.EventHandler(this.tBoxSzulDatum_TextChanged);
            // 
            // tBoxUjHobbi
            // 
            this.tBoxUjHobbi.Location = new System.Drawing.Point(481, 193);
            this.tBoxUjHobbi.Name = "tBoxUjHobbi";
            this.tBoxUjHobbi.Size = new System.Drawing.Size(100, 20);
            this.tBoxUjHobbi.TabIndex = 9;
            // 
            // LBoxHobbi
            // 
            this.LBoxHobbi.FormattingEnabled = true;
            this.LBoxHobbi.Items.AddRange(new object[] {
            "foci",
            "bicikli",
            "röplabda"});
            this.LBoxHobbi.Location = new System.Drawing.Point(481, 67);
            this.LBoxHobbi.Name = "LBoxHobbi";
            this.LBoxHobbi.Size = new System.Drawing.Size(120, 95);
            this.LBoxHobbi.TabIndex = 10;
            // 
            // btnHozzad
            // 
            this.btnHozzad.Location = new System.Drawing.Point(481, 233);
            this.btnHozzad.Name = "btnHozzad";
            this.btnHozzad.Size = new System.Drawing.Size(75, 23);
            this.btnHozzad.TabIndex = 11;
            this.btnHozzad.Text = "Hozzáad";
            this.btnHozzad.UseVisualStyleBackColor = true;
            this.btnHozzad.Click += new System.EventHandler(this.btnHozzad_Click);
            // 
            // btnMentes
            // 
            this.btnMentes.Location = new System.Drawing.Point(481, 321);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(75, 23);
            this.btnMentes.TabIndex = 12;
            this.btnMentes.Text = "Mentés";
            this.btnMentes.UseVisualStyleBackColor = true;
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);
            // 
            // btnBeltolt
            // 
            this.btnBeltolt.Location = new System.Drawing.Point(581, 321);
            this.btnBeltolt.Name = "btnBeltolt";
            this.btnBeltolt.Size = new System.Drawing.Size(75, 23);
            this.btnBeltolt.TabIndex = 13;
            this.btnBeltolt.Text = "Betölt";
            this.btnBeltolt.UseVisualStyleBackColor = true;
            this.btnBeltolt.Click += new System.EventHandler(this.btnBeltolt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBeltolt);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.btnHozzad);
            this.Controls.Add(this.LBoxHobbi);
            this.Controls.Add(this.tBoxUjHobbi);
            this.Controls.Add(this.tBoxSzulDatum);
            this.Controls.Add(this.tBoxNev);
            this.Controls.Add(this.rBtnNo);
            this.Controls.Add(this.rBttnFerfi);
            this.Controls.Add(this.lblUjHobbi);
            this.Controls.Add(this.lblHobbi);
            this.Controls.Add(this.lblNem);
            this.Controls.Add(this.lblSzulDatum);
            this.Controls.Add(this.lblNev);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblNev;
        private System.Windows.Forms.Label lblSzulDatum;
        private System.Windows.Forms.Label lblNem;
        private System.Windows.Forms.Label lblHobbi;
        private System.Windows.Forms.Label lblUjHobbi;
        private System.Windows.Forms.RadioButton rBttnFerfi;
        private System.Windows.Forms.RadioButton rBtnNo;
        private System.Windows.Forms.TextBox tBoxNev;
        private System.Windows.Forms.TextBox tBoxSzulDatum;
        private System.Windows.Forms.TextBox tBoxUjHobbi;
        private System.Windows.Forms.ListBox LBoxHobbi;
        private System.Windows.Forms.Button btnHozzad;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.Button btnBeltolt;
    }
}

