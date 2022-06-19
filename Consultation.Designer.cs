
namespace Connexion_BD_SQL_Server
{
    partial class Consultation
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label Label3;
            System.Windows.Forms.Label NumeroLabel;
            System.Windows.Forms.Label NomLabel;
            System.Windows.Forms.Label PrénomLabel;
            this.lbl_Valeur_Total = new System.Windows.Forms.Label();
            this.cmdFermer = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdDernier = new System.Windows.Forms.Button();
            this.cmdPremier = new System.Windows.Forms.Button();
            this.cmdPrécédent = new System.Windows.Forms.Button();
            this.cmdSuivant = new System.Windows.Forms.Button();
            this.CPcomboBox = new System.Windows.Forms.ComboBox();
            this.rdbFemme = new System.Windows.Forms.RadioButton();
            this.rdbHomme = new System.Windows.Forms.RadioButton();
            this.DateNaissTextBox = new System.Windows.Forms.TextBox();
            this.NumeroTextBox = new System.Windows.Forms.TextBox();
            this.NomTextBox = new System.Windows.Forms.TextBox();
            this.PrénomTextBox = new System.Windows.Forms.TextBox();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.EtudiantsDataGridView = new System.Windows.Forms.DataGridView();
            this.lbl_Titre_Total = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            Label3 = new System.Windows.Forms.Label();
            NumeroLabel = new System.Windows.Forms.Label();
            NomLabel = new System.Windows.Forms.Label();
            PrénomLabel = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EtudiantsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(34, 165);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(31, 13);
            label2.TabIndex = 66;
            label2.Text = "Sexe";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(34, 132);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(83, 13);
            label1.TabIndex = 65;
            label1.Text = "Date Naissance";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new System.Drawing.Point(34, 194);
            Label3.Name = "Label3";
            Label3.Size = new System.Drawing.Size(63, 13);
            Label3.TabIndex = 63;
            Label3.Text = "Code postal";
            // 
            // NumeroLabel
            // 
            NumeroLabel.AutoSize = true;
            NumeroLabel.Location = new System.Drawing.Point(34, 32);
            NumeroLabel.Name = "NumeroLabel";
            NumeroLabel.Size = new System.Drawing.Size(47, 13);
            NumeroLabel.TabIndex = 57;
            NumeroLabel.Text = "Numero:";
            // 
            // NomLabel
            // 
            NomLabel.AutoSize = true;
            NomLabel.Location = new System.Drawing.Point(34, 67);
            NomLabel.Name = "NomLabel";
            NomLabel.Size = new System.Drawing.Size(32, 13);
            NomLabel.TabIndex = 59;
            NomLabel.Text = "Nom:";
            // 
            // PrénomLabel
            // 
            PrénomLabel.AutoSize = true;
            PrénomLabel.Location = new System.Drawing.Point(34, 99);
            PrénomLabel.Name = "PrénomLabel";
            PrénomLabel.Size = new System.Drawing.Size(46, 13);
            PrénomLabel.TabIndex = 61;
            PrénomLabel.Text = "Prénom:";
            // 
            // lbl_Valeur_Total
            // 
            this.lbl_Valeur_Total.AutoSize = true;
            this.lbl_Valeur_Total.Location = new System.Drawing.Point(385, 340);
            this.lbl_Valeur_Total.Name = "lbl_Valeur_Total";
            this.lbl_Valeur_Total.Size = new System.Drawing.Size(39, 13);
            this.lbl_Valeur_Total.TabIndex = 63;
            this.lbl_Valeur_Total.Text = "Label2";
            this.lbl_Valeur_Total.Click += new System.EventHandler(this.lbl_Valeur_Total_Click);
            // 
            // cmdFermer
            // 
            this.cmdFermer.BackColor = System.Drawing.Color.SkyBlue;
            this.cmdFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFermer.Location = new System.Drawing.Point(796, 358);
            this.cmdFermer.Name = "cmdFermer";
            this.cmdFermer.Size = new System.Drawing.Size(88, 28);
            this.cmdFermer.TabIndex = 68;
            this.cmdFermer.Text = "Fermer";
            this.cmdFermer.UseVisualStyleBackColor = false;
            this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.GroupBox1.Controls.Add(this.cmdDernier);
            this.GroupBox1.Controls.Add(this.cmdPremier);
            this.GroupBox1.Controls.Add(this.cmdPrécédent);
            this.GroupBox1.Controls.Add(this.cmdSuivant);
            this.GroupBox1.Controls.Add(this.CPcomboBox);
            this.GroupBox1.Controls.Add(this.rdbFemme);
            this.GroupBox1.Controls.Add(this.rdbHomme);
            this.GroupBox1.Controls.Add(label2);
            this.GroupBox1.Controls.Add(label1);
            this.GroupBox1.Controls.Add(this.DateNaissTextBox);
            this.GroupBox1.Controls.Add(Label3);
            this.GroupBox1.Controls.Add(NumeroLabel);
            this.GroupBox1.Controls.Add(this.NumeroTextBox);
            this.GroupBox1.Controls.Add(NomLabel);
            this.GroupBox1.Controls.Add(this.NomTextBox);
            this.GroupBox1.Controls.Add(PrénomLabel);
            this.GroupBox1.Controls.Add(this.PrénomTextBox);
            this.GroupBox1.Location = new System.Drawing.Point(28, 33);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(290, 297);
            this.GroupBox1.TabIndex = 64;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Navigation";
            // 
            // cmdDernier
            // 
            this.cmdDernier.Location = new System.Drawing.Point(207, 249);
            this.cmdDernier.Name = "cmdDernier";
            this.cmdDernier.Size = new System.Drawing.Size(43, 24);
            this.cmdDernier.TabIndex = 74;
            this.cmdDernier.Text = ">|";
            this.cmdDernier.UseVisualStyleBackColor = true;
            this.cmdDernier.Click += new System.EventHandler(this.cmdDernier_Click);
            // 
            // cmdPremier
            // 
            this.cmdPremier.Location = new System.Drawing.Point(39, 249);
            this.cmdPremier.Name = "cmdPremier";
            this.cmdPremier.Size = new System.Drawing.Size(43, 25);
            this.cmdPremier.TabIndex = 73;
            this.cmdPremier.Text = "|<";
            this.cmdPremier.UseVisualStyleBackColor = true;
            this.cmdPremier.Click += new System.EventHandler(this.cmdPremier_Click);
            // 
            // cmdPrécédent
            // 
            this.cmdPrécédent.Location = new System.Drawing.Point(95, 249);
            this.cmdPrécédent.Name = "cmdPrécédent";
            this.cmdPrécédent.Size = new System.Drawing.Size(43, 25);
            this.cmdPrécédent.TabIndex = 72;
            this.cmdPrécédent.Text = "<";
            this.cmdPrécédent.UseVisualStyleBackColor = true;
            this.cmdPrécédent.Click += new System.EventHandler(this.cmdPrécédent_Click);
            // 
            // cmdSuivant
            // 
            this.cmdSuivant.Location = new System.Drawing.Point(151, 249);
            this.cmdSuivant.Name = "cmdSuivant";
            this.cmdSuivant.Size = new System.Drawing.Size(43, 24);
            this.cmdSuivant.TabIndex = 71;
            this.cmdSuivant.Text = ">";
            this.cmdSuivant.UseVisualStyleBackColor = true;
            this.cmdSuivant.Click += new System.EventHandler(this.cmdSuivant_Click);
            // 
            // CPcomboBox
            // 
            this.CPcomboBox.Enabled = false;
            this.CPcomboBox.FormattingEnabled = true;
            this.CPcomboBox.Location = new System.Drawing.Point(122, 191);
            this.CPcomboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CPcomboBox.Name = "CPcomboBox";
            this.CPcomboBox.Size = new System.Drawing.Size(129, 21);
            this.CPcomboBox.TabIndex = 69;
            // 
            // rdbFemme
            // 
            this.rdbFemme.AutoSize = true;
            this.rdbFemme.Enabled = false;
            this.rdbFemme.Location = new System.Drawing.Point(191, 164);
            this.rdbFemme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbFemme.Name = "rdbFemme";
            this.rdbFemme.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbFemme.Size = new System.Drawing.Size(59, 17);
            this.rdbFemme.TabIndex = 68;
            this.rdbFemme.Text = "Femme";
            this.rdbFemme.UseVisualStyleBackColor = true;
            // 
            // rdbHomme
            // 
            this.rdbHomme.AutoSize = true;
            this.rdbHomme.Checked = true;
            this.rdbHomme.Enabled = false;
            this.rdbHomme.Location = new System.Drawing.Point(122, 163);
            this.rdbHomme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbHomme.Name = "rdbHomme";
            this.rdbHomme.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbHomme.Size = new System.Drawing.Size(61, 17);
            this.rdbHomme.TabIndex = 67;
            this.rdbHomme.TabStop = true;
            this.rdbHomme.Text = "Homme";
            this.rdbHomme.UseVisualStyleBackColor = true;
            this.rdbHomme.CheckedChanged += new System.EventHandler(this.rdbHomme_CheckedChanged);
            // 
            // DateNaissTextBox
            // 
            this.DateNaissTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.DateNaissTextBox.Enabled = false;
            this.DateNaissTextBox.Location = new System.Drawing.Point(125, 128);
            this.DateNaissTextBox.Name = "DateNaissTextBox";
            this.DateNaissTextBox.Size = new System.Drawing.Size(127, 20);
            this.DateNaissTextBox.TabIndex = 64;
            // 
            // NumeroTextBox
            // 
            this.NumeroTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NumeroTextBox.Enabled = false;
            this.NumeroTextBox.Location = new System.Drawing.Point(124, 28);
            this.NumeroTextBox.Name = "NumeroTextBox";
            this.NumeroTextBox.Size = new System.Drawing.Size(127, 20);
            this.NumeroTextBox.TabIndex = 58;
            // 
            // NomTextBox
            // 
            this.NomTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.NomTextBox.ForeColor = System.Drawing.Color.Black;
            this.NomTextBox.Location = new System.Drawing.Point(124, 63);
            this.NomTextBox.Name = "NomTextBox";
            this.NomTextBox.ReadOnly = true;
            this.NomTextBox.Size = new System.Drawing.Size(127, 20);
            this.NomTextBox.TabIndex = 60;
            // 
            // PrénomTextBox
            // 
            this.PrénomTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.PrénomTextBox.Enabled = false;
            this.PrénomTextBox.Location = new System.Drawing.Point(124, 95);
            this.PrénomTextBox.Name = "PrénomTextBox";
            this.PrénomTextBox.Size = new System.Drawing.Size(127, 20);
            this.PrénomTextBox.TabIndex = 62;
            // 
            // GroupBox4
            // 
            this.GroupBox4.BackColor = System.Drawing.Color.SkyBlue;
            this.GroupBox4.Controls.Add(this.EtudiantsDataGridView);
            this.GroupBox4.Location = new System.Drawing.Point(348, 33);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(536, 297);
            this.GroupBox4.TabIndex = 67;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Etudiants";
            // 
            // EtudiantsDataGridView
            // 
            this.EtudiantsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EtudiantsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EtudiantsDataGridView.Location = new System.Drawing.Point(3, 16);
            this.EtudiantsDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EtudiantsDataGridView.Name = "EtudiantsDataGridView";
            this.EtudiantsDataGridView.RowHeadersWidth = 62;
            this.EtudiantsDataGridView.RowTemplate.Height = 28;
            this.EtudiantsDataGridView.Size = new System.Drawing.Size(530, 278);
            this.EtudiantsDataGridView.TabIndex = 0;
            this.EtudiantsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EtudiantsDataGridView_CellContentClick);
            // 
            // lbl_Titre_Total
            // 
            this.lbl_Titre_Total.AutoSize = true;
            this.lbl_Titre_Total.Location = new System.Drawing.Point(348, 340);
            this.lbl_Titre_Total.Name = "lbl_Titre_Total";
            this.lbl_Titre_Total.Size = new System.Drawing.Size(31, 13);
            this.lbl_Titre_Total.TabIndex = 62;
            this.lbl_Titre_Total.Text = "Total";
            // 
            // Consultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1028, 413);
            this.Controls.Add(this.lbl_Valeur_Total);
            this.Controls.Add(this.cmdFermer);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.lbl_Titre_Total);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Consultation";
            this.Text = "Consultation";
            this.Load += new System.EventHandler(this.Consultation_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EtudiantsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lbl_Valeur_Total;
        internal System.Windows.Forms.Button cmdFermer;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.Label lbl_Titre_Total;
        private System.Windows.Forms.ComboBox CPcomboBox;
        private System.Windows.Forms.RadioButton rdbFemme;
        private System.Windows.Forms.RadioButton rdbHomme;
        internal System.Windows.Forms.TextBox DateNaissTextBox;
        internal System.Windows.Forms.TextBox NumeroTextBox;
        internal System.Windows.Forms.TextBox NomTextBox;
        internal System.Windows.Forms.TextBox PrénomTextBox;
        internal System.Windows.Forms.Button cmdDernier;
        internal System.Windows.Forms.Button cmdPremier;
        internal System.Windows.Forms.Button cmdPrécédent;
        internal System.Windows.Forms.Button cmdSuivant;
        private System.Windows.Forms.DataGridView EtudiantsDataGridView;
    }
}