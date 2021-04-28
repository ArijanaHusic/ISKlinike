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
    public partial class DatumiPosjeta : Form
    {
        private Pacijenti Pacijent;
        private DBContext db = Baza.baza;
        public DatumiPosjeta()
        {
            InitializeComponent();
            dgvDatumiDolazaka.AutoGenerateColumns = false;
        }

        public DatumiPosjeta(Pacijenti pacijent):this()
        {
            Pacijent = pacijent;
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            dgvDatumiDolazaka.DataSource = null;
            dgvDatumiDolazaka.DataSource = db.KartonDatumiPosjeta.Where(karton => karton.Pacijenti.Id == Pacijent.Id).ToList();
        }
        private void btnUredi_Click(object sender, EventArgs e)
        {
            DatumiPosjetaUredi posjeta = new DatumiPosjetaUredi(Pacijent);
            posjeta.Show();

            UcitajPodatke();
        }

        private void DatumiPosjeta_Load(object sender, EventArgs e)
        {

        }
    }
}
