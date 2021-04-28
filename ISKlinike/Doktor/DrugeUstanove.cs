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
    public partial class DrugeUstanove : Form
    {
        private Pacijenti Pacijent;
        private DBContext db = Baza.baza;
        public DrugeUstanove()
        {
            InitializeComponent();
            dgvDrugeUstanove.AutoGenerateColumns = false;
        }

        public DrugeUstanove(Pacijenti pacijent):this()
        {
            Pacijent = pacijent;
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            dgvDrugeUstanove.DataSource = null;
            dgvDrugeUstanove.DataSource = db.KartonDrugeUstanove.Where(karton => karton.Pacijenti.Id == Pacijent.Id).ToList();
        }
        private void btnUredi_Click(object sender, EventArgs e)
        {
            DrugeUstanoveUredi ustanove = new DrugeUstanoveUredi(Pacijent);
            ustanove.Show();

            UcitajPodatke();
        }

        private void dgvDrugeUstanove_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            KartonDrugeUstanove ustanove = dgvDrugeUstanove.SelectedRows[0].DataBoundItem as KartonDrugeUstanove;

            if (ustanove != null)
            {
                if (e.ColumnIndex == 4)
                {
                    rtbUputstvoZaTretman.Text = ustanove.Uputstvo;
                }
            }
        }

        private void DrugeUstanove_Load(object sender, EventArgs e)
        {

        }
    }
}
