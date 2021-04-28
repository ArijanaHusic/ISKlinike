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
    public partial class OboljenjaPacijenta : Form
    {
        private DBContext db = Baza.baza;
        private Pacijenti Pacijent;

        public OboljenjaPacijenta()
        {
            InitializeComponent();
            
            dgvOboljenja.AutoGenerateColumns = false;
            dgvOboljenja.DataSource = null;
            
        }
        

        public OboljenjaPacijenta(Pacijenti pacijent) : this()
        {
            Pacijent = pacijent;
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            var podaci = db.KartonOboljenja
                   .Where(o => o.Pacijenti.Id == Pacijent.Id)
                   .ToList();

            if (podaci.Count > 0)
            {
                dgvOboljenja.DataSource = null;
                dgvOboljenja.DataSource = podaci;

            }
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            OboljenjaUredi urediOboljenja = new OboljenjaUredi(Pacijent);
            urediOboljenja.Show();

            UcitajPodatke();
        }

        private void OboljenjaPacijenta_Load(object sender, EventArgs e)
        {
            
        }

        private void btnNesposobnostiZaRad_Click(object sender, EventArgs e)
        {
            NesposobnostZaRadOdDo NesposobnostOdDo = new NesposobnostZaRadOdDo(Pacijent);
            NesposobnostOdDo.Show();
        }

        private void btnDatumiPosjeta_Click(object sender, EventArgs e)
        {
            DatumiDolazaka posjete = new DatumiDolazaka(Pacijent);
            posjete.Show();
        }
    }
}
