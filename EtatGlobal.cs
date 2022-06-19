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
    public partial class EtatGlobal : Form
    {
        public EtatGlobal()
        {
            InitializeComponent();
        }

        private void EtatGlobal_Load(object sender, EventArgs e)
        {
            SqlDataAdapter EtudVillesDataAdapter = new SqlDataAdapter();
            DataTable dt1;
            EtudVillesDataAdapter = new SqlDataAdapter("select * from Etudiants order by Numero", Global.maConnexion);

            EtudVillesDataAdapter.Fill(Global.données, "Mes_etud");
            CrystalGlobal rpt = new CrystalGlobal();

            dt1 = Global.données.Tables["Mes_etud"];
            rpt.SetDataSource(dt1);
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
