using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Connexion_BD_SQL_Server
{
    public partial class MiseAJour : Form
    {
        string Mise_a_jour;
        public MiseAJour()
        {
            InitializeComponent();
        }

        private void MiseAJour_Load(object sender, EventArgs e)
        {
            EtudiantsDataGridView.Dock = DockStyle.Fill;

            EtudiantsDataGridView.DataSource = Global.EtudiantsBindingSource;

            EtudiantsDataGridView.AutoResizeColumns();
            EtudiantsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

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

        private void cmdFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }       

        private void cmdNouveau_Click(object sender, EventArgs e)
        {
            Global.EtudiantsBindingSource.AddNew();
            Dérouiller_Zones_de_Texte();

            RemplirComboBoxVilles();
            CPcomboBox.DataBindings.Clear();
            CPcomboBox.DataBindings.Add("SelectedValue", Global.EtudiantsBindingSource, "CP", true);

            NumeroTextBox.Focus();
            Mise_a_jour = "nouveau";
        }

        private void cmdEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {                                
                Global.EtudiantsBindingSource.EndEdit();
                SqlCommandBuilder cb = new SqlCommandBuilder(Global.EtudiantDataAdapter);
                cb.GetInsertCommand();
                cb.GetDeleteCommand();
                cb.GetUpdateCommand();          

                Global.EtudiantDataAdapter.Update(Global.données.Tables["Mes_etudiants"]);
                lbl_Valeur_Total.Text = Global.EtudiantsBindingSource.Count.ToString();
                
                if (Mise_a_jour == "nouveau")
                    MessageBox.Show("Etudiant ajouté");
                else if (Mise_a_jour == "supp")
                    MessageBox.Show("Etudiant supprimé");
                else
                    MessageBox.Show("Etudiant modifié");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }            
        }       

        private void cmdSupprimer_Click(object sender, EventArgs e)
        {
            Global.EtudiantsBindingSource.RemoveCurrent();
            Mise_a_jour = "supp";
        }

        private void cmdModifier_Click(object sender, EventArgs e)
        {
            Dérouiller_Zones_de_Texte();
            NumeroTextBox.Focus();
            RemplirComboBoxVilles();
            Mise_a_jour = "modif";
            CPcomboBox.DataBindings.Clear();

            CPcomboBox.DataBindings.Add("SelectedValue", Global.EtudiantsBindingSource, "CP", true);

        }
        private void Vérouiller_Zones_de_Texte()
        {
            NumeroTextBox.Enabled = false;
            NomTextBox.Enabled = false;
            PrénomTextBox.Enabled = false;
            DateNaissTextBox.Enabled = false;
            grbSexe.Enabled = false;
            CPcomboBox.Enabled = false;
        }
        private void Dérouiller_Zones_de_Texte()
        {
            NumeroTextBox.Enabled = true;
            NomTextBox.Enabled = true;
            PrénomTextBox.Enabled = true;
            DateNaissTextBox.Enabled = true;
            grbSexe.Enabled = true;
            CPcomboBox.Enabled = true;
        }
        private void RemplirComboBoxVilles()
        {
            CPcomboBox.DataSource = Global.données.Tables["Mes_villes"];
            CPcomboBox.DisplayMember = "Ville";
            CPcomboBox.ValueMember = "CP";
        }

        private void cmdRechercher_Click(object sender, EventArgs e)
        {
            string critère = "CP >=0";
            if (txtNumRech.Text != "")
                critère = critère + " AND Numero=" + txtNumRech.Text;
            if (txtNomRech.Text != "")
                critère = critère + " AND Nom LIKE '%" + txtNomRech.Text + "%'";
            if (txtPrénomRech.Text != "")
                critère = critère + " AND Prenom LIKE '%" + txtPrénomRech.Text + "%'";
            Global.EtudiantsBindingSource.Filter = critère;
            lbl_Valeur_Total.Text = Global.EtudiantsBindingSource.Count.ToString();

        }

        private void cmdAnnuler_Click(object sender, EventArgs e)
        {
            Global.EtudiantsBindingSource.Filter = "";
            lbl_Valeur_Total.Text = Global.EtudiantsBindingSource.Count.ToString();

        }

        private void rdbHomme_CheckedChanged(object sender, EventArgs e)
        {
            rdbFemme.Checked = !rdbHomme.Checked;
        }
    }
}
