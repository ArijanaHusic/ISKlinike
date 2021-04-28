using ISKlinike.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISKlinike.Doktor
{
    public partial class Termini : Form
    {
        private DBContext db = Baza.baza;
        private Korisnik _korisnik;

        public Termini(Korisnik korisnik)
        {
            _korisnik = korisnik;
            InitializeComponent();
            dgvTermini.AutoGenerateColumns = false;
        }

        private void Termini_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke(List<TerminPregleda> lista = null)
        {
            var podaci = db.TerminPregleda.Where(karton => karton.Doktor.Id == _korisnik.Id).ToList();

            dgvTermini.DataSource = null;
            dgvTermini.DataSource = lista ?? podaci;
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            var filter = txtPretraga.Text;
            var rezultat = db.TerminPregleda.Where(karton => (karton.Doktor.Id == _korisnik.Id) && (karton.Pacijent.Ime.ToLower().Contains(filter.ToLower()) || karton.Pacijent.Prezime.ToLower().Contains(filter.ToLower()))).ToList();
            UcitajPodatke(rezultat);
        }

        private void dtpPretraga_ValueChanged(object sender, EventArgs e)
        {
            //var filter = dtpPretraga.Value;
            //var rezultat = db.TerminPregleda.Where(karton => (karton.Doktor.Id == _korisnik.Id) && (karton.DatumVrijemePregleda.Date == filter)).ToList();
            //UcitajPodatke(rezultat);
        }

        private void btnMinimiye_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListaPacijenata lista = new ListaPacijenata();
            lista.ShowDialog();

        }

        private void btnNoviTermin_Click(object sender, EventArgs e)
        {
            this.Hide();
            NoviTermin noviTermin = new NoviTermin(_korisnik);
            noviTermin.ShowDialog();
        }
    }
}
