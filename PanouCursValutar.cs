using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPaw_CasaDeSchimbValutar
{
    public partial class PanouCursValutar : UserControl
    {
        public PanouCursValutar()
        {
            InitializeComponent();
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            
            listaCursuri.Items.Clear();

            
            listaCursuri.Items.Add("Data: " + DateTime.Now.ToString("dd/MM/yyyy"));
            listaCursuri.Items.Add("------------------------");
            listaCursuri.Items.Add("🇪🇺 EUR: 4.97 RON");
            listaCursuri.Items.Add("🇺🇸 USD: 4.62 RON");
            listaCursuri.Items.Add("🇬🇧 GBP: 5.80 RON");
            listaCursuri.Items.Add("🇨🇭 CHF: 5.10 RON");
        }
    }
}
