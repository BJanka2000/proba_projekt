using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proba_projekt
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private bool CheckEmail(string email)
        {
            Regex regex = new Regex("^.*@[a-z]*(.hu|.com)$");
            return regex.IsMatch(email);
        }

        private bool NemÜres(string login)
        {
            return !string.IsNullOrEmpty(login);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txtSK_Validating(object sender, CancelEventArgs e)
        {
            if (!NemÜres(txtSK.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSK, "Nem lehet üres a VevőSK");
            }
        }

        private void txtSK_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtSK, "");
        }

        private void txtNév_Validating(object sender, CancelEventArgs e)
        {
            if (!NemÜres(txtNév.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNév, "Nem lehet üres a Vevő név");
            }
        }

        private void txtNév_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtNév, "");
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckEmail(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Hibás email címet adott meg!");
            }
        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtEmail, "");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren() == true)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
