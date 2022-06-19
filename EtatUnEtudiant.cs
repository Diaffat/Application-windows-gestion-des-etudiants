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
    public partial class EtatUnEtudiant : Form
    {
        public EtatUnEtudiant()
        {
            InitializeComponent();
        }

        private void EtatUnEtudiant_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Global.dt;
            comboBox1.DisplayMember = "Numero";
            comboBox1.ValueMember = "Numero";           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter EtudiantsDataAdapter = new SqlDataAdapter();

            DataTable dt2;
            EtudiantsDataAdapter = new SqlDataAdapter("select * from Etudiants where Numero=" + comboBox1.Text, Global.maConnexion);

            
            EtudiantsDataAdapter.Fill(Global.données, "Un_etud");
            CrystalUnEtudiant rpt = new CrystalUnEtudiant();

            dt2 = Global.données.Tables["Un_etud"];
            rpt.SetDataSource(dt2);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
            Global.données.Tables.Remove("Un_etud");
        }
    }
}
