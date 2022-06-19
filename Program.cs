using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Connexion_BD_SQL_Server
{
    public class Global
    {
        public static BindingSource EtudiantsBindingSource = new BindingSource();
        public static SqlDataAdapter EtudiantDataAdapter=new SqlDataAdapter() ;
        public static BindingSource VillesBindingSource = new BindingSource();
        public static SqlDataAdapter VillestDataAdapter = new SqlDataAdapter();
        public static DataSet données = new DataSet();
        public static SqlConnection maConnexion ;
        public static String chaineConnexion;
        public static DataTable dt = new DataTable();

        public static void récupérerDonnées()
        {
            try
            {
                chaineConnexion = @"Data Source=DESKTOP-PTQ7CTJ\SQLEXPRESS;Initial Catalog=MaBase;Integrated Security=True";
                maConnexion = new SqlConnection(chaineConnexion);
                maConnexion.Open();
                données.Locale = System.Globalization.CultureInfo.InvariantCulture;
                EtudiantDataAdapter = new SqlDataAdapter("select * from Etudiants order by Numero", maConnexion);
                EtudiantDataAdapter.Fill(données, "Mes_etudiants");

                VillestDataAdapter = new SqlDataAdapter("select * from Villes order by Ville", maConnexion);
                VillestDataAdapter.Fill(données, "Mes_villes");

                dt = données.Tables["Mes_etudiants"];
                EtudiantsBindingSource.DataSource = dt;
                maConnexion.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Connexion());
        }
    }
}
