using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connexion_BD_SQL_Server
{
    public partial class Consultation : Form
    {
        public Consultation()
        {
            InitializeComponent();
        }

        private void cmdFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Consultation_Load(object sender, EventArgs e)
        {
            EtudiantsDataGridView.Dock = DockStyle.Fill;

            EtudiantsDataGridView.DataSource = Global.EtudiantsBindingSource;

            EtudiantsDataGridView.AutoResizeColumns();
            EtudiantsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

          // Liaison des zones de texte et combobox du formulaire avec les chanmps du bindingSource
            NumeroTextBox.DataBindings.Add("Text", Global.EtudiantsBindingSource, "Numero", true);
            NomTextBox.DataBindings.Add("Text", Global.EtudiantsBindingSource, "Nom", true);
            PrénomTextBox.DataBindings.Add("Text", Global.EtudiantsBindingSource, "Prenom", true);
            DateNaissTextBox.DataBindings.Add("Text", Global.EtudiantsBindingSource, "DateNaiss", true);
            rdbHomme.DataBindings.Add("Checked", Global.EtudiantsBindingSource, "Sexe", true);
            CPcomboBox.DataBindings.Add("Text", Global.EtudiantsBindingSource, "CP", true);
            // pictureBox1.DataBindings.Add("Image", Global.EtudiantsBindingSource, "Photo", true,
            //   DataSourceUpdateMode.Never, new Bitmap(typeof(Button), "Button.bmp"));

            lbl_Valeur_Total.Text = Global.EtudiantsBindingSource.Count.ToString();
        }

        private void cmdPremier_Click(object sender, EventArgs e)
        {
            Global.EtudiantsBindingSource.MoveFirst();            
        }

        private void cmdPrécédent_Click(object sender, EventArgs e)
        {
            Global.EtudiantsBindingSource.MovePrevious();            
        }

        private void cmdSuivant_Click(object sender, EventArgs e)
        {
            Global.EtudiantsBindingSource.MoveNext();            
        }

        private void cmdDernier_Click(object sender, EventArgs e)
        {
            Global.EtudiantsBindingSource.MoveLast();           
        }

        private void EtudiantsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void rdbHomme_CheckedChanged(object sender, EventArgs e)
        {
            rdbFemme.Checked = !rdbHomme.Checked;
        }

        private void lbl_Valeur_Total_Click(object sender, EventArgs e)
        {

        }
    }
}
