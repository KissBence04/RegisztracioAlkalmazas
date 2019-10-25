using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisztracioAlkalmazas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHozzad_Click(object sender, EventArgs e)
        {
            if(!tBoxUjHobbi.Text.Trim().Equals(" "))
            {
                LBoxHobbi.Items.Add(tBoxUjHobbi.Text);
                tBoxUjHobbi.Text = "";
            }
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }
        
       private void btnBeltolt_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void tBoxSzulDatum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!tBoxSzulDatum.Text.Trim().Equals(" "))
                {

                    tBoxSzulDatum.Text += Console.ReadLine();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hiba! Nem dátumot adott meg!"); ;
            }     
        }

        private void tBoxNev_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!tBoxNev.Text.Trim().Equals(" "))
                {
                    tBoxNev.Text += Console.ReadLine();
                }   
            }
            catch (Exception)
            {

                MessageBox.Show("Hiba! Nem nevet adott meg!"); ;
            }
            
        }

        private void saveFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {
            try
            {
                using (var sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    sw.WriteLine(tBoxNev.Text);
                    sw.WriteLine(tBoxSzulDatum.Text);
                    if(rBttnFerfi.Checked)
                    {
                        sw.WriteLine("Férfi");
                    }
                    else
                    {
                        sw.WriteLine("Nő");
                    }
                    foreach (var item in LBoxHobbi.Items)
                    {
                        sw.WriteLine(item);
                    }
                }
            }
            catch (IOException)
            {

                MessageBox.Show("Hiba! Sikertelen mentés!");
            }
        }

        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {
            try
            {
                using (var sr = new StreamReader(openFileDialog1.FileName))
                {
                    tBoxNev.Text=sr.ReadLine();
                    tBoxSzulDatum.Text = sr.ReadLine();
                    if (sr.ReadLine()=="Férfi")
                    {
                        rBttnFerfi.Checked=true;
                        rBtnNo.Checked = false;
                    }
                    else
                    {
                        rBttnFerfi.Checked = false;
                        rBtnNo.Checked = true;
                    }
                    LBoxHobbi.Items.Clear();
                    while (!sr.EndOfStream)
                    {
                        LBoxHobbi.Items.Add(sr.ReadLine());
                    }
                }
            }
            catch (IOException)
            {

                MessageBox.Show("Hiba! Nem sikerült a beltöltés!");
            }
        }
    }
}
