using System.Security.Cryptography;
using System.Text;

namespace Sifreleme
{
    public partial class Form1 : Form
    {
        UnicodeEncoding ByteConverter = new UnicodeEncoding();
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        byte[] plaintext;
        byte[] encryptedtext;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSifrele_Click(object sender, EventArgs e)
        {
            //txtSifreli.Text = Encrypt(txtNormal.Text);
            plaintext = ByteConverter.GetBytes(txtNormal.Text);
            encryptedtext = Encryption(plaintext, RSA.ExportParameters(false), false);
            txtSifreli.Text = ByteConverter.GetString(encryptedtext);
        }
        private void btnCozumle_Click(object sender, EventArgs e)
        {
            //txtCozunen.Text = Decrypt(txtSifreli.Text);
            byte[] decryptedtex = Decryption(encryptedtext, RSA.ExportParameters(true), false);
            txtCozunen.Text = ByteConverter.GetString(decryptedtex);
        }
        static public byte[] Encryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    encryptedData = RSA.Encrypt(Data, DoOAEPPadding);
                }
                return encryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        static public byte[] Decryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    decryptedData = RSA.Decrypt(Data, DoOAEPPadding);
                }
                return decryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
    }
}