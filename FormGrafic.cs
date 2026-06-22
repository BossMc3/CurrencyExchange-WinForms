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
    public partial class FormGrafic : Form
    {
        List<Modele.Tranzacite> tranzactiiGrafic; 

        
        public FormGrafic(List<Modele.Tranzacite> listaDinForm1)
        {
            InitializeComponent();
            tranzactiiGrafic = listaDinForm1;

            
            panelGrafic.Paint += panelGrafic_Paint;
        }

        
        private void panelGrafic_Paint(object sender, PaintEventArgs e)
        {
            
            if (tranzactiiGrafic == null || tranzactiiGrafic.Count == 0) return;

            Graphics g = e.Graphics;
            Rectangle zonaDesenare = panelGrafic.ClientRectangle;

            
            Brush pensulaBare = new SolidBrush(Color.DodgerBlue); 
            Pen creionMargine = new Pen(Color.Black, 2);          
            Font fontText = new Font("Arial", 10, FontStyle.Bold);

            
            double maxSuma = 0;
            foreach (var t in tranzactiiGrafic)
            {
                if (t.SumaIncasata > maxSuma) maxSuma = t.SumaIncasata;
            }

            
            int latimeBara = zonaDesenare.Width / tranzactiiGrafic.Count / 2;
            int distanta = (zonaDesenare.Width - (latimeBara * tranzactiiGrafic.Count)) / (tranzactiiGrafic.Count + 1);

           
            for (int i = 0; i < tranzactiiGrafic.Count; i++)
            {
                
                double inaltimeBara = (tranzactiiGrafic[i].SumaIncasata / maxSuma) * (zonaDesenare.Height - 40);

                int x = distanta + i * (latimeBara + distanta);
                int y = zonaDesenare.Height - (int)inaltimeBara - 20; 

                
                Rectangle rectBara = new Rectangle(x, y, latimeBara, (int)inaltimeBara);
                g.FillRectangle(pensulaBare, rectBara); 
                g.DrawRectangle(creionMargine, rectBara); 

                
                string textDeAfisat = tranzactiiGrafic[i].SumaIncasata.ToString();
                g.DrawString(textDeAfisat, fontText, Brushes.Black, x, y - 20);
            }
        }
    }
}
