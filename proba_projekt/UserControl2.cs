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
    public partial class UserControl2 : UserControl
    {
        Models.WebshopContext context = new Models.WebshopContext();

        public UserControl2()
        {
            InitializeComponent();

            listTermék.DisplayMember = "Terméknév";
            GetTermék();

            listSzállító.DisplayMember = "Cégnév";
            GetSzallito();

            listIdőpontok.DisplayMember = "MegrendelésIdőpontja";

            //szállítókBindingSource.DataSource= context.Szállítók.ToList();
            //szállítóAdatokBindingSource.DataSource = context.SzállítóAdatok.ToList();
            //termékekBindingSource.DataSource = context.Termékek.ToList();
        }

        private void GetSzallito()
        {
            var szallito = from x in context.SzállítóAdatok
                           where x.Cégnév.Contains(txtSzállító.Text)
                           select x;
            listSzállító.DataSource = szallito.ToList();
        }

        private void GetTermék()
        {
            var termek = from x in context.Termékek
                         where x.Terméknév.Contains(txtTermék.Text)
                         select x;
            listTermék.DataSource = termek.ToList();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }

        private void txtTermék_TextChanged(object sender, EventArgs e)
        {
            GetTermék();
        }

        private void txtSzállító_TextChanged(object sender, EventArgs e)
        {
            GetSzallito();
        }

        private void listTermék_SelectedIndexChanged(object sender, EventArgs e)
        {
            Models.Termékek selectedtermék = (Models.Termékek)listTermék.SelectedItem;
            

            var szűr = from x in context.Szállítók
                       where x.TermékFk == selectedtermék.TermékSk
                       select x;
            //dataGridView2.DataSource = szűr.ToList();

            listIdőpontok.DataSource = szűr.ToList();

            

        }

        private void listSzállító_SelectedIndexChanged(object sender, EventArgs e)
        {
            Models.SzállítóAdatok selectedszállító = (Models.SzállítóAdatok)listSzállító.SelectedItem;

            var szűr = from x in context.Szállítók
                       where x.SzállítóFk == selectedszállító.SzállítóSk
                       select x;
            //dataGridView2.DataSource = szűr.ToList();

            listIdőpontok.DataSource = szűr.ToList();


        }

        private void listIdőpontok_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Models.Szállítók selectedidőpont = (Models.Szállítók)listIdőpontok.SelectedItem;

            //var mennyiség = from x in context.Szállítók
            //           where x.MegrendelésIdőpontja == selectedidőpont.MegrendelésIdőpontja
            //           select x.MennyiségSzállító;
            //var egységár = from x in context.Szállítók
            //               where x.MegrendelésIdőpontja == selectedidőpont.MegrendelésIdőpontja
            //               select x.EgységárSzállító;
            //mennyiség = double.Parse(mennyiség);


            //txtFizetés.Text = 
        }
    }
}
