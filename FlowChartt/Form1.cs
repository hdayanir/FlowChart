using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowChartt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ciz = calismaAlani.CreateGraphics();
        }


        

        public Point Konum=new Point (250,33);
        Nesneler duzenleyici = new Nesneler();
        Pen kalem = new Pen(Color.Black);
        Graphics ciz = null;
        public int selectedIndex1;
        public int selectedIndex2;




        private void button1_Click(object sender, EventArgs e)
        {
            if (duzenleyici.index <= 0)
            {
                calismaAlani.Controls.Add(duzenleyici.EkleBasla(Konum));
                Konum.Y += 75;
                baslaLB.Items.Add(duzenleyici.nesneListesi[duzenleyici.index - 1].Tag.ToString());
                bitirLB.Items.Add(duzenleyici.nesneListesi[duzenleyici.index - 1].Tag.ToString());
            }
            else
                MessageBox.Show("Başlangıç operatörü en başta ve yalnız bir adet olmalıdır.");
            
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(duzenleyici.nesneListesi.Count.ToString());

            
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calismaAlani.Controls.Add(duzenleyici.EkleCikti(Konum));
            Konum.Y += 75;
            baslaLB.Items.Add(duzenleyici.nesneListesi[duzenleyici.index - 1].Tag.ToString());
            bitirLB.Items.Add(duzenleyici.nesneListesi[duzenleyici.index - 1].Tag.ToString());

        }

        private void button4_Click(object sender, EventArgs e)
        {
           

            int indexx = baslaLB.SelectedIndex;
            int indexx2 = bitirLB.SelectedIndex;
            // If the item was not found in ListBox 2 display a message box, otherwise select it in ListBox2.
            if (indexx == -1 && indexx2 == -1)
                MessageBox.Show("Henüz yeterli nesne seçmediniz.");
            else
            {
                selectedIndex1 = baslaLB.SelectedIndex;
                selectedIndex2 = bitirLB.SelectedIndex;


                
            }
            var X1 = duzenleyici.nesneListesi[this.selectedIndex1].Location.X + 50;
            var Y1 = duzenleyici.nesneListesi[this.selectedIndex1].Location.Y + 35;
            var X2 = duzenleyici.nesneListesi[this.selectedIndex2].Location.X + 50;
            var Y2 = duzenleyici.nesneListesi[this.selectedIndex2].Location.Y;
            if (X1 == X2 && (Y1 - Y2) == -40)
            {
                using (Pen pen = new Pen(Color.Black, 2))
                {

                    ciz.DrawLine(kalem, X1, Y1, X2, Y2);
                }
            }
            else
            {
                using(Pen pen = new Pen(Color.Black, 5))
                {
                    ciz.DrawLine(kalem, (X1 - 50), (Y1 - 13),(X1-100), (Y1-13));
                    ciz.DrawLine(kalem, (X1 - 100), (Y1 - 13), (X2 - 100), (Y2+13));
                    ciz.DrawLine(kalem, (X2 - 100), (Y2 + 13), (X2-50) , (Y2+13));
                }
            }



        }

        private void calismaAlani_Paint(object sender, PaintEventArgs e)
        {
           /* kalem.Width = 1;
            ciz = calismaAlani.CreateGraphics();
            cizgiCiz();
            */
        }
        private void cizgiCiz()
        {
           /* var X1 = duzenleyici.nesneListesi[cizgiDuzenleyici.selectedIndex1].Location.X + 50;
            var Y1 = duzenleyici.nesneListesi[cizgiDuzenleyici.selectedIndex1].Location.Y + 35;
            var X2 = duzenleyici.nesneListesi[cizgiDuzenleyici.selectedIndex2].Location.X + 50;
            var Y2 = duzenleyici.nesneListesi[cizgiDuzenleyici.selectedIndex2].Location.Y;
            Point[] konumlar =
            {
                new Point(X1,Y1),
                new Point(X2,Y2)
            };
            ciz.DrawLines(kalem,konumlar);
            */
        }
        private void button5_Click(object sender, EventArgs e)
        {


            calismaAlani.Invalidate();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
