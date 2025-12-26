using System;
using System.Numerics;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace playfair_and_RSA
{
    public partial class Form1 : Form
    {
        RSA rsa = new RSA();
        public Form1()
        {
            InitializeComponent();
        }

        private void txtPlain_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPFEnc_Click(object sender, EventArgs e)
        {
            var pf = new PlayfairCipher(txtKey.Text);
            txtCipher.Text = pf.Encrypt(txtPlain.Text);
        }

        private void btnPFDec_Click(object sender, EventArgs e)
        {
            var pf = new PlayfairCipher(txtKey.Text);
            txtCipher.Text = pf.Decrypt(txtPlain.Text);
        }

        private void btnRSAEnc_Click(object sender, EventArgs e)
        {
            txtCipher.Text = rsa.EncryptString(txtPlain.Text);
        }

        private void btnRSADec_Click(object sender, EventArgs e)
        {
            txtCipher.Text = rsa.DecryptString(txtPlain.Text);
        }
    }
}
