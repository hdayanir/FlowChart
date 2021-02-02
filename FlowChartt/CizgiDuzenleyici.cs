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
    public partial class CizgiDuzenleyici : Form
    {
        public CizgiDuzenleyici()
        {
            InitializeComponent();
        }
        Nesneler nesneyeUlas = new Nesneler();

        public int selectedIndex1;
        public int selectedIndex2;

        private void button1_Click(object sender, EventArgs e)
        {
            
            int indexx = ilkLB.SelectedIndex;
            int indexx2 = ikinciLB.SelectedIndex;
            // If the item was not found in ListBox 2 display a message box, otherwise select it in ListBox2.
            if (indexx == -1 && indexx2 == -1)
                MessageBox.Show("Henüz yeterli nesne seçmediniz.");
            else
            {
                selectedIndex1 = ilkLB.SelectedIndex;
                selectedIndex2 = ikinciLB.SelectedIndex;


                this.Hide();
            }

            
        }

        private void CizgiDuzenleyici_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                //Hide();
                this.Close();
            }
        }

        
    }
}
