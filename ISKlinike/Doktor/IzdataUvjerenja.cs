using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISKlinike
{
    public partial class IzdataUvjerenja : Form
    {
        private Pacijenti pacijent;
        private DBContext db = Baza.baza;

        public IzdataUvjerenja()
        {
            InitializeComponent();
            dgvIzdataSposobnost.AutoGenerateColumns = false;
            dgvIzdataSposobnost.DataSource = null;
            dgvIzdataSposobnost.DataSource = db.KartonIzdataUvjerenja.ToList();
        }

        public IzdataUvjerenja(Pacijenti pacijent):this()
        {
            this.pacijent = pacijent;
        }

        private void KartonIzdataUvjerenja_Load(object sender, EventArgs e)
        {
            dgvIzdataSposobnost.DataSource =null;
            dgvIzdataSposobnost.DataSource = db.KartonIzdataUvjerenja.ToList();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            IzdataUvjerenjaUredi uvjerenje = new IzdataUvjerenjaUredi(pacijent);
            uvjerenje.Show();
        }
    }
}
