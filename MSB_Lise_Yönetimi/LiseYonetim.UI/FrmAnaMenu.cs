using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiseYonetim.UI
{
    public partial class FrmAnaMenu : Form
    {
        public FrmAnaMenu()
        {
            InitializeComponent();
        }

        private void öğretmenListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgretmenListesi OgretmenListesiFormu = new FrmOgretmenListesi();
            OgretmenListesiFormu.MdiParent = this;

            OgretmenListesiFormu.Show();
        }
    }
}
