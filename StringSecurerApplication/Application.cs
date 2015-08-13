using StringSecurer;
using System;
using System.Security;
using System.Windows.Forms;

namespace StringSecurerApplication
{
    public partial class Application : Form
    {

        private string unsafeDefault = "Enter a string to be encrypted";
        private string safeDefault = "Or enter a string to be decrypted";

        public Application()
        {
            InitializeComponent();

            unsafetext.Text = unsafeDefault;
            safetext.Text = safeDefault;
        }

        private void encrypt_Click(object sender, EventArgs e)
        {
            if (unsafetext.TextLength > 0)
            {
                try
                {
                    SecureString securedText = Securer.ToSecureString(unsafetext.Text);

                    safetext.Text = Securer.EncryptString(securedText);
                }
                catch (Exception ex)
                {
                    safetext.Text = ex.Message;
                }
            }
            else
            {
                safetext.Text = "Unable to encrypt an empty string";
            }
        }

        private void decrypt_Click(object sender, EventArgs e)
        {
            if (safetext.TextLength > 0)
            {
                try
                {
                    SecureString decryptedString = Securer.DecryptString(safetext.Text);

                    unsafetext.Text = Securer.ToInsecureString(decryptedString);
                }
                catch (Exception ex)
                {
                    unsafetext.Text = ex.Message;
                }
            }
            else
            {
                unsafetext.Text = "Unable to decrypt an empty string";
            }
        }

        private void unsafetext_Enter(object sender, EventArgs e)
        {
            if (unsafetext.Text == unsafeDefault)
            {
                unsafetext.Text = "";
            }
        }

        private void unsafetext_Leave(object sender, EventArgs e)
        {
            if (unsafetext.Text == "")
            {
                unsafetext.Text = unsafeDefault;
            }
        }

        private void safetext_Enter(object sender, EventArgs e)
        {
            if (safetext.Text == safeDefault)
            {
                safetext.Text = "";
            }
        }

        private void safetext_Leave(object sender, EventArgs e)
        {
            if (safetext.Text == "")
            {
                safetext.Text = safeDefault;
            }
        }
    }
}