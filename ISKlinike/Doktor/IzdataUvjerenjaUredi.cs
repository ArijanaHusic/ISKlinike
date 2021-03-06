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
    public partial class IzdataUvjerenjaUredi : Form
    {
        private Pacijenti Pacijent;
        private DBContext db = Baza.baza;
        public IzdataUvjerenjaUredi()
        {
            InitializeComponent();
        }

        public IzdataUvjerenjaUredi(Pacijenti pacijent):this()
        {
            Pacijent = pacijent;
        }

        private void IzdataUvjerenjaUredi_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimiye_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            KartonIzdataUvjerenja uvjerenje = new KartonIzdataUvjerenja
            {
                DatumIzmjene = dtpDatumUvjerenja.Value,
                Invaliditet = txtInvaliditet.Text,
                RadnaSposobnost = txtRadnaSposobnost.Text
            };
            db.KartonIzdataUvjerenja.Add(uvjerenje);
            db.SaveChanges();
            Close();
        }
    }
}
