using System;
using System.Windows.Forms;

namespace WFAFibonacciOdev_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            lbsonuc.Items.Clear();
            int dizi = 0;
            int sayi = Convert.ToInt32(txtsayi.Text);
            int ilkDeger = 0;
            int ikinciDeger = 1;
            lblsonuc.Text = $"{ilkDeger}-";
            lbsonuc.Items.Add(ilkDeger);
            for (int i =1; i< sayi;i++)
            {
               
                dizi = ilkDeger + ikinciDeger;
                ikinciDeger = ilkDeger;
                ilkDeger = dizi;
                lblsonuc.Text += $"{ilkDeger}-";
                lbsonuc.Items.Add(ilkDeger);
                
            }
            MessageBox.Show(dizi.ToString());
        }
        
    }
}
