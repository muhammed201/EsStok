using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EsStok
{
    public partial class AnaMenu : Form
    {
        
        public AnaMenu()
        {
            InitializeComponent();           
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            

        }
      

        private void AnaMenu_Load(object sender, EventArgs e)
        {
            CenterToParent();
            //Formu merkeze alıyoruz

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool donen = genel.acikFormKontrolEt("stok");
            if (donen == true)
            {
                MessageBox.Show("Açmak istediğiniz pencere zaten açık...", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                stok stokForm= new stok();
                stokForm.Show();
                this.Hide();
            }
        }
    }
}
