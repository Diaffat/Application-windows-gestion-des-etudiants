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
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }
       private void Connexion_Load(object sender, EventArgs e)
        {
            txtLogin.Text = "toto";
            txtPasswd.Text = "123";
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            String login, passwd;
            try
            {
                Global.récupérerDonnées();
                String requete = "SELECT * FROM Utilisateurs WHERE Login='"+txtLogin.Text+"' AND Passwd='"+txtPasswd.Text+"'";
                SqlDataAdapter da = new SqlDataAdapter(requete, Global.maConnexion);
                DataTable dt1 = new DataTable();
                da.Fill(Global.données,"users" );
                dt1 = Global.données.Tables["users"];
                if (dt1.Rows.Count != 0)
                {
                    login = txtLogin.Text;
                    passwd = txtPasswd.Text;
                    Accueil frm = new Accueil();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("login ou mot de passe incorrect !","Erreur de connexion",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtLogin.Clear();
                    txtPasswd.Clear();
                    txtLogin.Focus();
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                //Global.maConnexion.Close();
            }
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            txtLogin.Clear();
            txtPasswd.Clear();
            txtLogin.Focus();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            DialogResult reponse;
            reponse = MessageBox.Show("Voulez-vous quitter ?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reponse == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void chkAfficherPasswd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAfficherPasswd.Checked == true)
                txtPasswd.UseSystemPasswordChar=false;
            else
                txtPasswd.UseSystemPasswordChar = true;

        }
    }
}
