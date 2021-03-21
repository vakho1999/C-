using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace davaleba1
{
    class MatarebeliMethodebit
    {
        private int vagonisRaodenoba, mgzavrisRaodenoba;
        public int biletisFasi, gayiduliBileti;
        public void Initialize(int vagonisRaodenoba, int mgzavrisRaodenoba, int biletisFasi, int gayiduliBileti)
        {
            this.vagonisRaodenoba = vagonisRaodenoba;
            this.mgzavrisRaodenoba = mgzavrisRaodenoba * this.vagonisRaodenoba;
            this.biletisFasi = biletisFasi;
            this.gayiduliBileti = gayiduliBileti;
        }
        public String TicketProfit()
        {
            return (this.biletisFasi * this.gayiduliBileti).ToString();
        }

        public void Gamotana(Label vagonisRaodenoba, Label mgzavrisRaodenoba, Label biletisFasi, Label gayiduliBileti, Label jami)
        {
            jami.Text ="ჯამი: " +this.TicketProfit();
            vagonisRaodenoba.Text = "ვაგონის რაოდენობა: " + this.vagonisRaodenoba.ToString();
            mgzavrisRaodenoba.Text = "მგზავრის რაოდენობა: "+this.mgzavrisRaodenoba.ToString();
            biletisFasi.Text = "ბილეთის ფასი: "+this.biletisFasi.ToString();
            gayiduliBileti.Text = "გაყიდული ბილეთები: "+this.gayiduliBileti.ToString();

        }
        
    }
   
}
