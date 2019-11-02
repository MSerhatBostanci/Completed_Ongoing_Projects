using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eksin_EczaneOtomasyonProject
{
    public partial class frmAnaForm : Form
    {
        EksinPharmaDatabaseEntitiesCodex _context;
        int formSayac = 0;

        public frmAnaForm()
        {
            frmPersonelGiris frm = new frmPersonelGiris();
            frm.ShowDialog();
            formSayac = formSayac + 1;
            InitializeComponent();
            _context = new EksinPharmaDatabaseEntitiesCodex();
        }

        public frmAnaForm(int a)
        {
            formSayac = a;
            if (formSayac == 0)
            {
                frmPersonelGiris frm = new frmPersonelGiris();
                frm.ShowDialog();
            }
            InitializeComponent();
            _context = new EksinPharmaDatabaseEntitiesCodex();
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            this.satışToolStripMenuItem.Enabled = false;
        }

        private void SatışToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmAnaForm frm = new frmAnaForm(formSayac);
            frm.Show();

        }
    }
}
