using proba_projekt.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proba_projekt
{
    public partial class UserControl3 : UserControl
    {
        WebshopContext context = new WebshopContext();

        public UserControl3()
        {
            InitializeComponent();

            listTermékek.DisplayMember = "Terméknév";
            GetTermék();

            listVevők.DisplayMember = "Név";
            GetVevő();

            vevőkBindingSource.DataSource = context.Vevők.ToList();
        }

        private void GetVevő()
        {
            var vevok = from x in context.Vevők
                        where x.Név.Contains(txtVevők.Text)
                        select x;
            listVevők.DataSource = vevok.ToList();
        }

        private void GetTermék()
        {
            var termek = from x in context.Termékek
                         where x.Terméknév.Contains(txtTermékek.Text)
                         select x;
            listTermékek.DataSource = termek.ToList();
        }

        private void txtTermékek_TextChanged(object sender, EventArgs e)
        {
            GetTermék();
        }

        private void txtVevők_TextChanged(object sender, EventArgs e)
        {
            GetVevő();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();

            if (f2.ShowDialog() == DialogResult.OK)
            {
                Models.Vevők vevo = new Models.Vevők();
                vevo.VevőSk = f2.txtSK.Text;
                vevo.Név = f2.txtNév.Text;
                vevo.Login = f2.txtLogin.Text;
                vevo.Email = f2.txtEmail.Text;

                context.Vevők.Add(vevo);

                try
                {
                    context.SaveChanges();
                }
                catch (Exception err)
                {

                    MessageBox.Show($"Nem lehet menteni mert: {err.InnerException}");
                }

                vevőkBindingSource.DataSource = context.Vevők.ToList();
            }
        }
    }
}
