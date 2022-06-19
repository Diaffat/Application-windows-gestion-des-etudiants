
namespace Connexion_BD_SQL_Server
{
    partial class MiseAJour
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label Label3;
            System.Windows.Forms.Label PrénomLabel;
            System.Windows.Forms.Label NomLabel;
            System.Windows.Forms.Label NumeroLabel;
            System.Windows.Forms.Label label1;
            this.cmdFermer = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdNouveau = new System.Windows.Forms.Button();
            this.cmdModifier = new System.Windows.Forms.Button();
            this.cmdSupprimer = new System.Windows.Forms.Button();
            this.cmdEnregistrer = new System.Windows.Forms.Button();
            this.lbl_Valeur_Total = new System.Windows.Forms.Label();
            this.EtudiantsDataGridView = new System.Windows.Forms.DataGridView();
            this.SexeGroupBoxe = new System.Windows.Forms.GroupBox();
            this.grbSexe = new System.Windows.Forms.GroupBox();
            this.rdbHomme = new System.Windows.Forms.RadioButton();
            this.rdbFemme = new System.Windows.Forms.RadioButton();
            this.CPcomboBox = new System.Windows.Forms.ComboBox();
            this.DateNaissTextBox = new System.Windows.Forms.TextBox();
            this.cmdDernier = new System.Windows.Forms.Button();
            this.cmdPremier = new System.Windows.Forms.Button();
            this.cmdPrécédent = new System.Windows.Forms.Button();
            this.cmdSuivant = new System.Windows.Forms.Button();
            this.NumeroTextBox = new System.Windows.Forms.TextBox();
            this.NomTextBox = new System.Windows.Forms.TextBox();
            this.PrénomTextBox = new System.Windows.Forms.TextBox();
            this.lbl_Titre_Total = new System.Windows.Forms.Label();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPrénomRech = new System.Windows.Forms.TextBox();
            this.txtNomRech = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtNumRech = new System.Windows.Forms.TextBox();
            this.cmdRechercher = new System.Windows.Forms.Button();
            this.cmdAnnuler = new System.Windows.Forms.Button();
            Label3 = new System.Windows.Forms.Label();
            PrénomLabel = new System.Windows.Forms.Label();
            NomLabel = new System.Windows.Forms.Label();
            NumeroLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EtudiantsDataGridView)).BeginInit();
            this.SexeGroupBoxe.SuspendLayout();
            this.grbSexe.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new System.Drawing.Point(13, 213);
            Label3.Name = "Label3";
            Label3.Size = new System.Drawing.Size(63, 13);
            Label3.TabIndex = 48;
            Label3.Text = "Code postal";
            // 
            // PrénomLabel
            // 
            PrénomLabel.AutoSize = true;
            PrénomLabel.Location = new System.Drawing.Point(13, 92);
            PrénomLabel.Name = "PrénomLabel";
            PrénomLabel.Size = new System.Drawing.Size(46, 13);
            PrénomLabel.TabIndex = 41;
            PrénomLabel.Text = "Prénom:";
            // 
            // NomLabel
            // 
            NomLabel.AutoSize = true;
            NomLabel.Location = new System.Drawing.Point(13, 60);
            NomLabel.Name = "NomLabel";
            NomLabel.Size = new System.Drawing.Size(32, 13);
            NomLabel.TabIndex = 39;
            NomLabel.Text = "Nom:";
            // 
            // NumeroLabel
            // 
            NumeroLabel.AutoSize = true;
            NumeroLabel.Location = new System.Drawing.Point(13, 26);
            NumeroLabel.Name = "NumeroLabel";
            NumeroLabel.Size = new System.Drawing.Size(47, 13);
            NumeroLabel.TabIndex = 37;
            NumeroLabel.Text = "Numero:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 125);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(83, 13);
            label1.TabIndex = 50;
            label1.Text = "Date Naissance";
            // 
            // cmdFermer
            // 
            this.cmdFermer.BackColor = System.Drawing.Color.SkyBlue;
            this.cmdFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFermer.Location = new System.Drawing.Point(907, 453);
            this.cmdFermer.Name = "cmdFermer";
            this.cmdFermer.Size = new System.Drawing.Size(88, 27);
            this.cmdFermer.TabIndex = 68;
            this.cmdFermer.Text = "Fermer";
            this.cmdFermer.UseVisualStyleBackColor = false;
            this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.Color.SkyBlue;
            this.GroupBox2.Controls.Add(this.cmdNouveau);
            this.GroupBox2.Controls.Add(this.cmdModifier);
            this.GroupBox2.Controls.Add(this.cmdSupprimer);
            this.GroupBox2.Controls.Add(this.cmdEnregistrer);
            this.GroupBox2.Location = new System.Drawing.Point(13, 332);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(271, 100);
            this.GroupBox2.TabIndex = 65;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Mise à jour";
            // 
            // cmdNouveau
            // 
            this.cmdNouveau.Location = new System.Drawing.Point(14, 23);
            this.cmdNouveau.Name = "cmdNouveau";
            this.cmdNouveau.Size = new System.Drawing.Size(75, 27);
            this.cmdNouveau.TabIndex = 34;
            this.cmdNouveau.Text = "Nouveau";
            this.cmdNouveau.UseVisualStyleBackColor = true;
            this.cmdNouveau.Click += new System.EventHandler(this.cmdNouveau_Click);
            // 
            // cmdModifier
            // 
            this.cmdModifier.Location = new System.Drawing.Point(13, 62);
            this.cmdModifier.Name = "cmdModifier";
            this.cmdModifier.Size = new System.Drawing.Size(75, 27);
            this.cmdModifier.TabIndex = 40;
            this.cmdModifier.Text = "Modifier";
            this.cmdModifier.UseVisualStyleBackColor = true;
            this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
            // 
            // cmdSupprimer
            // 
            this.cmdSupprimer.Location = new System.Drawing.Point(128, 23);
            this.cmdSupprimer.Name = "cmdSupprimer";
            this.cmdSupprimer.Size = new System.Drawing.Size(75, 27);
            this.cmdSupprimer.TabIndex = 41;
            this.cmdSupprimer.Text = "Supprimer";
            this.cmdSupprimer.UseVisualStyleBackColor = true;
            this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
            // 
            // cmdEnregistrer
            // 
            this.cmdEnregistrer.Location = new System.Drawing.Point(128, 61);
            this.cmdEnregistrer.Name = "cmdEnregistrer";
            this.cmdEnregistrer.Size = new System.Drawing.Size(75, 27);
            this.cmdEnregistrer.TabIndex = 33;
            this.cmdEnregistrer.Text = "Enregistrer";
            this.cmdEnregistrer.UseVisualStyleBackColor = true;
            this.cmdEnregistrer.Click += new System.EventHandler(this.cmdEnregistrer_Click);
            // 
            // lbl_Valeur_Total
            // 
            this.lbl_Valeur_Total.AutoSize = true;
            this.lbl_Valeur_Total.Location = new System.Drawing.Point(329, 302);
            this.lbl_Valeur_Total.Name = "lbl_Valeur_Total";
            this.lbl_Valeur_Total.Size = new System.Drawing.Size(39, 13);
            this.lbl_Valeur_Total.TabIndex = 63;
            this.lbl_Valeur_Total.Text = "Label2";
            // 
            // EtudiantsDataGridView
            // 
            this.EtudiantsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EtudiantsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EtudiantsDataGridView.Location = new System.Drawing.Point(3, 16);
            this.EtudiantsDataGridView.Name = "EtudiantsDataGridView";
            this.EtudiantsDataGridView.ReadOnly = true;
            this.EtudiantsDataGridView.RowHeadersWidth = 51;
            this.EtudiantsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EtudiantsDataGridView.Size = new System.Drawing.Size(689, 259);
            this.EtudiantsDataGridView.TabIndex = 40;
            // 
            // SexeGroupBoxe
            // 
            this.SexeGroupBoxe.BackColor = System.Drawing.Color.SkyBlue;
            this.SexeGroupBoxe.Controls.Add(this.grbSexe);
            this.SexeGroupBoxe.Controls.Add(this.CPcomboBox);
            this.SexeGroupBoxe.Controls.Add(label1);
            this.SexeGroupBoxe.Controls.Add(this.DateNaissTextBox);
            this.SexeGroupBoxe.Controls.Add(Label3);
            this.SexeGroupBoxe.Controls.Add(this.cmdDernier);
            this.SexeGroupBoxe.Controls.Add(this.cmdPremier);
            this.SexeGroupBoxe.Controls.Add(this.cmdPrécédent);
            this.SexeGroupBoxe.Controls.Add(this.cmdSuivant);
            this.SexeGroupBoxe.Controls.Add(NumeroLabel);
            this.SexeGroupBoxe.Controls.Add(this.NumeroTextBox);
            this.SexeGroupBoxe.Controls.Add(NomLabel);
            this.SexeGroupBoxe.Controls.Add(this.NomTextBox);
            this.SexeGroupBoxe.Controls.Add(PrénomLabel);
            this.SexeGroupBoxe.Controls.Add(this.PrénomTextBox);
            this.SexeGroupBoxe.Location = new System.Drawing.Point(14, 15);
            this.SexeGroupBoxe.Name = "SexeGroupBoxe";
            this.SexeGroupBoxe.Size = new System.Drawing.Size(270, 278);
            this.SexeGroupBoxe.TabIndex = 64;
            this.SexeGroupBoxe.TabStop = false;
            this.SexeGroupBoxe.Text = "Navigation";
            // 
            // grbSexe
            // 
            this.grbSexe.Controls.Add(this.rdbHomme);
            this.grbSexe.Controls.Add(this.rdbFemme);
            this.grbSexe.Enabled = false;
            this.grbSexe.Location = new System.Drawing.Point(15, 153);
            this.grbSexe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbSexe.Name = "grbSexe";
            this.grbSexe.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbSexe.Size = new System.Drawing.Size(213, 49);
            this.grbSexe.TabIndex = 57;
            this.grbSexe.TabStop = false;
            this.grbSexe.Text = "Sexe";
            // 
            // rdbHomme
            // 
            this.rdbHomme.AutoSize = true;
            this.rdbHomme.Checked = true;
            this.rdbHomme.Location = new System.Drawing.Point(23, 18);
            this.rdbHomme.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbHomme.Name = "rdbHomme";
            this.rdbHomme.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbHomme.Size = new System.Drawing.Size(61, 17);
            this.rdbHomme.TabIndex = 55;
            this.rdbHomme.TabStop = true;
            this.rdbHomme.Text = "Homme";
            this.rdbHomme.UseVisualStyleBackColor = true;
            this.rdbHomme.CheckedChanged += new System.EventHandler(this.rdbHomme_CheckedChanged);
            // 
            // rdbFemme
            // 
            this.rdbFemme.AutoSize = true;
            this.rdbFemme.Location = new System.Drawing.Point(136, 18);
            this.rdbFemme.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbFemme.Name = "rdbFemme";
            this.rdbFemme.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbFemme.Size = new System.Drawing.Size(59, 17);
            this.rdbFemme.TabIndex = 56;
            this.rdbFemme.TabStop = true;
            this.rdbFemme.Text = "Femme";
            this.rdbFemme.UseVisualStyleBackColor = true;
            // 
            // CPcomboBox
            // 
            this.CPcomboBox.Enabled = false;
            this.CPcomboBox.FormattingEnabled = true;
            this.CPcomboBox.Location = new System.Drawing.Point(100, 210);
            this.CPcomboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CPcomboBox.Name = "CPcomboBox";
            this.CPcomboBox.Size = new System.Drawing.Size(129, 21);
            this.CPcomboBox.TabIndex = 55;
            // 
            // DateNaissTextBox
            // 
            this.DateNaissTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.DateNaissTextBox.Enabled = false;
            this.DateNaissTextBox.Location = new System.Drawing.Point(103, 122);
            this.DateNaissTextBox.Name = "DateNaissTextBox";
            this.DateNaissTextBox.Size = new System.Drawing.Size(127, 20);
            this.DateNaissTextBox.TabIndex = 49;
            // 
            // cmdDernier
            // 
            this.cmdDernier.Location = new System.Drawing.Point(186, 245);
            this.cmdDernier.Name = "cmdDernier";
            this.cmdDernier.Size = new System.Drawing.Size(43, 25);
            this.cmdDernier.TabIndex = 46;
            this.cmdDernier.Text = ">|";
            this.cmdDernier.UseVisualStyleBackColor = true;
            this.cmdDernier.Click += new System.EventHandler(this.cmdDernier_Click);
            // 
            // cmdPremier
            // 
            this.cmdPremier.Location = new System.Drawing.Point(18, 244);
            this.cmdPremier.Name = "cmdPremier";
            this.cmdPremier.Size = new System.Drawing.Size(43, 25);
            this.cmdPremier.TabIndex = 45;
            this.cmdPremier.Text = "|<";
            this.cmdPremier.UseVisualStyleBackColor = true;
            this.cmdPremier.Click += new System.EventHandler(this.cmdPremier_Click);
            // 
            // cmdPrécédent
            // 
            this.cmdPrécédent.Location = new System.Drawing.Point(74, 244);
            this.cmdPrécédent.Name = "cmdPrécédent";
            this.cmdPrécédent.Size = new System.Drawing.Size(43, 25);
            this.cmdPrécédent.TabIndex = 44;
            this.cmdPrécédent.Text = "<";
            this.cmdPrécédent.UseVisualStyleBackColor = true;
            this.cmdPrécédent.Click += new System.EventHandler(this.cmdPrécédent_Click);
            // 
            // cmdSuivant
            // 
            this.cmdSuivant.Location = new System.Drawing.Point(129, 245);
            this.cmdSuivant.Name = "cmdSuivant";
            this.cmdSuivant.Size = new System.Drawing.Size(43, 25);
            this.cmdSuivant.TabIndex = 43;
            this.cmdSuivant.Text = ">";
            this.cmdSuivant.UseVisualStyleBackColor = true;
            this.cmdSuivant.Click += new System.EventHandler(this.cmdSuivant_Click);
            // 
            // NumeroTextBox
            // 
            this.NumeroTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NumeroTextBox.Enabled = false;
            this.NumeroTextBox.Location = new System.Drawing.Point(103, 22);
            this.NumeroTextBox.Name = "NumeroTextBox";
            this.NumeroTextBox.Size = new System.Drawing.Size(127, 20);
            this.NumeroTextBox.TabIndex = 38;
            // 
            // NomTextBox
            // 
            this.NomTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.NomTextBox.Enabled = false;
            this.NomTextBox.Location = new System.Drawing.Point(103, 56);
            this.NomTextBox.Name = "NomTextBox";
            this.NomTextBox.Size = new System.Drawing.Size(127, 20);
            this.NomTextBox.TabIndex = 40;
            // 
            // PrénomTextBox
            // 
            this.PrénomTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.PrénomTextBox.Enabled = false;
            this.PrénomTextBox.Location = new System.Drawing.Point(103, 88);
            this.PrénomTextBox.Name = "PrénomTextBox";
            this.PrénomTextBox.Size = new System.Drawing.Size(127, 20);
            this.PrénomTextBox.TabIndex = 42;
            // 
            // lbl_Titre_Total
            // 
            this.lbl_Titre_Total.AutoSize = true;
            this.lbl_Titre_Total.Location = new System.Drawing.Point(295, 302);
            this.lbl_Titre_Total.Name = "lbl_Titre_Total";
            this.lbl_Titre_Total.Size = new System.Drawing.Size(37, 13);
            this.lbl_Titre_Total.TabIndex = 62;
            this.lbl_Titre_Total.Text = "Total :";
            // 
            // GroupBox4
            // 
            this.GroupBox4.BackColor = System.Drawing.Color.SkyBlue;
            this.GroupBox4.Controls.Add(this.EtudiantsDataGridView);
            this.GroupBox4.Location = new System.Drawing.Point(298, 14);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(695, 278);
            this.GroupBox4.TabIndex = 67;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Liste des étudiants";
            // 
            // GroupBox3
            // 
            this.GroupBox3.BackColor = System.Drawing.Color.SkyBlue;
            this.GroupBox3.Controls.Add(this.txtPrénomRech);
            this.GroupBox3.Controls.Add(this.txtNomRech);
            this.GroupBox3.Controls.Add(this.Label6);
            this.GroupBox3.Controls.Add(this.Label5);
            this.GroupBox3.Controls.Add(this.Label4);
            this.GroupBox3.Controls.Add(this.txtNumRech);
            this.GroupBox3.Controls.Add(this.cmdRechercher);
            this.GroupBox3.Controls.Add(this.cmdAnnuler);
            this.GroupBox3.Location = new System.Drawing.Point(301, 332);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(694, 100);
            this.GroupBox3.TabIndex = 69;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Recherche";
            // 
            // txtPrénomRech
            // 
            this.txtPrénomRech.Location = new System.Drawing.Point(427, 34);
            this.txtPrénomRech.Name = "txtPrénomRech";
            this.txtPrénomRech.Size = new System.Drawing.Size(115, 20);
            this.txtPrénomRech.TabIndex = 51;
            // 
            // txtNomRech
            // 
            this.txtNomRech.Location = new System.Drawing.Point(235, 34);
            this.txtNomRech.Name = "txtNomRech";
            this.txtNomRech.Size = new System.Drawing.Size(116, 20);
            this.txtNomRech.TabIndex = 50;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(23, 39);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(44, 13);
            this.Label6.TabIndex = 49;
            this.Label6.Text = "Numéro";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(205, 37);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(29, 13);
            this.Label5.TabIndex = 48;
            this.Label5.Text = "Nom";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(383, 38);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(43, 13);
            this.Label4.TabIndex = 47;
            this.Label4.Text = "Prénom";
            // 
            // txtNumRech
            // 
            this.txtNumRech.Location = new System.Drawing.Point(68, 34);
            this.txtNumRech.Name = "txtNumRech";
            this.txtNumRech.Size = new System.Drawing.Size(104, 20);
            this.txtNumRech.TabIndex = 46;
            // 
            // cmdRechercher
            // 
            this.cmdRechercher.Location = new System.Drawing.Point(606, 10);
            this.cmdRechercher.Name = "cmdRechercher";
            this.cmdRechercher.Size = new System.Drawing.Size(75, 27);
            this.cmdRechercher.TabIndex = 44;
            this.cmdRechercher.Text = "Rechercher";
            this.cmdRechercher.UseVisualStyleBackColor = true;
            this.cmdRechercher.Click += new System.EventHandler(this.cmdRechercher_Click);
            // 
            // cmdAnnuler
            // 
            this.cmdAnnuler.Location = new System.Drawing.Point(606, 44);
            this.cmdAnnuler.Name = "cmdAnnuler";
            this.cmdAnnuler.Size = new System.Drawing.Size(75, 27);
            this.cmdAnnuler.TabIndex = 45;
            this.cmdAnnuler.Text = "Annuler";
            this.cmdAnnuler.UseVisualStyleBackColor = true;
            this.cmdAnnuler.Click += new System.EventHandler(this.cmdAnnuler_Click);
            // 
            // MiseAJour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1012, 487);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.cmdFermer);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.lbl_Valeur_Total);
            this.Controls.Add(this.SexeGroupBoxe);
            this.Controls.Add(this.lbl_Titre_Total);
            this.Controls.Add(this.GroupBox4);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MiseAJour";
            this.Text = "Mise à jour des étudiants";
            this.Load += new System.EventHandler(this.MiseAJour_Load);
            this.GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EtudiantsDataGridView)).EndInit();
            this.SexeGroupBoxe.ResumeLayout(false);
            this.SexeGroupBoxe.PerformLayout();
            this.grbSexe.ResumeLayout(false);
            this.grbSexe.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button cmdFermer;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button cmdNouveau;
        internal System.Windows.Forms.Button cmdModifier;
        internal System.Windows.Forms.Button cmdSupprimer;
        internal System.Windows.Forms.Button cmdEnregistrer;
        internal System.Windows.Forms.Label lbl_Valeur_Total;
        internal System.Windows.Forms.DataGridView EtudiantsDataGridView;
        internal System.Windows.Forms.GroupBox SexeGroupBoxe;
        internal System.Windows.Forms.Button cmdDernier;
        internal System.Windows.Forms.Button cmdPremier;
        internal System.Windows.Forms.Button cmdPrécédent;
        internal System.Windows.Forms.Button cmdSuivant;
        internal System.Windows.Forms.Label lbl_Titre_Total;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.TextBox DateNaissTextBox;
        internal System.Windows.Forms.TextBox NumeroTextBox;
        internal System.Windows.Forms.TextBox NomTextBox;
        internal System.Windows.Forms.TextBox PrénomTextBox;
        private System.Windows.Forms.ComboBox CPcomboBox;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.TextBox txtPrénomRech;
        internal System.Windows.Forms.TextBox txtNomRech;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtNumRech;
        internal System.Windows.Forms.Button cmdRechercher;
        internal System.Windows.Forms.Button cmdAnnuler;
        private System.Windows.Forms.GroupBox grbSexe;
        private System.Windows.Forms.RadioButton rdbHomme;
        private System.Windows.Forms.RadioButton rdbFemme;
    }
}