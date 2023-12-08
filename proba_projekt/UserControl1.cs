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
    public partial class UserControl1 : UserControl
    {
        WebshopContext context = new WebshopContext();

        public UserControl1()
        {
            InitializeComponent();

            rendelésekBindingSource.DataSource = context.Rendelések.ToList();
            termékekBindingSource.DataSource = context.Termékek.ToList();
            vevőkBindingSource.DataSource = context.Vevők.ToList(); 
        }
    }
}
