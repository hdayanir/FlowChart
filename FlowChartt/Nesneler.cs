using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowChartt
{
    class Nesneler
    {

        public int index = 0;

        public List<PictureBox> nesneListesi = new List<PictureBox>();

        

        public Nesneler()
        {

            

        }
        
        public PictureBox EkleBasla(Point knm)
        {
            Form1 frmKntrl = new Form1();
                PictureBox baslamaKontrolu = new PictureBox
                {
                    Location = knm,
                    Size = new Size(100, 35),
                    Image = Image.FromFile("Resources/baslangic.png"),
                    Tag = "Baslangic_" + index

                };
                index++;
                nesneListesi.Add(baslamaKontrolu);
                return baslamaKontrolu;
            
            
            
        }

        public PictureBox EkleCikti(Point knm)
        {

            PictureBox ciktiKontrolu = new PictureBox
            {
                Location = knm,
                Size = new Size(100, 35),
                Image = Image.FromFile("Resources/cikti.png"),
                Tag = "Cikti_" + index

            };
            index++;
            nesneListesi.Add(ciktiKontrolu);
            return ciktiKontrolu;
        }


    }
}
