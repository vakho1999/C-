using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace davaleba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Tvitmfrinavi georgianAirway = new Tvitmfrinavi();
           
            georgianAirway.mgzavrebi = int.Parse(textBox1.Text);
            mgzavrebi.Text = "მგზავრები: " + georgianAirway.mgzavrebi.ToString();
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Tvitmfrinavi georgianAirway = new Tvitmfrinavi();
            georgianAirway.biletebi = int.Parse(textBox2.Text);
            biletebi.Text = "ბილეთები: " + georgianAirway.biletebi.ToString();
        }

        private void biletebisFasi_TextChanged(object sender, EventArgs e)
        {
            Matarebeli Raizen = new Matarebeli();
            Raizen.biletebisFasi = int.Parse(biletebisFasi.Text);
            label4.Text = "ბილეთების ფასი: " + Raizen.biletebisFasi.ToString();
        }

        private void biletebisRaodenoba_TextChanged(object sender, EventArgs e)
        {
            Matarebeli Raizen = new Matarebeli();
            Raizen.biletebisRaodenoba = int.Parse(biletebisRaodenoba.Text);
            label5.Text = "ბილეთების რაოდენობა: " + Raizen.biletebisRaodenoba.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vagonisRaodenoba, mgzavrisRaodenoba, biletisFasi, gayiduliBileti;
            MatarebeliMethodebit Yeger = new MatarebeliMethodebit();
            vagonisRaodenoba =  int.Parse(textBox4.Text);
            mgzavrisRaodenoba = int.Parse(textBox3.Text);
            biletisFasi = int.Parse(textBox5.Text);
            gayiduliBileti =  int.Parse(textBox6.Text);
            Yeger.Initialize(
               vagonisRaodenoba,
               mgzavrisRaodenoba,
                biletisFasi,
               gayiduliBileti
                );
            Yeger.Gamotana(
                label7,
                label8,
                label9,
                label10,
                label11
                );
        }
    }
}
