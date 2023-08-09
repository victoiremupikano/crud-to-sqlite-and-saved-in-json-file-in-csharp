namespace sqliteDbToJsonFile.Views
{
    partial class frmMain
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
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPostNom = new System.Windows.Forms.Label();
            this.txtPostNom = new System.Windows.Forms.TextBox();
            this.lblLieuNaiss = new System.Windows.Forms.Label();
            this.txtLieuNais = new System.Windows.Forms.TextBox();
            this.lblDteNaiss = new System.Windows.Forms.Label();
            this.lblOrigine = new System.Windows.Forms.Label();
            this.txtOrigine = new System.Windows.Forms.TextBox();
            this.lblNumCarte = new System.Windows.Forms.Label();
            this.txtNumCarte = new System.Windows.Forms.TextBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.dteNaiss = new System.Windows.Forms.DateTimePicker();
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.baseDeDonnéeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnToModify = new System.Windows.Forms.Button();
            this.btnSaveToJSON = new System.Windows.Forms.Button();
            this.btnLoard = new System.Windows.Forms.Button();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNom
            // 
            this.txtNom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNom.Location = new System.Drawing.Point(120, 43);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(298, 20);
            this.txtNom.TabIndex = 0;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(12, 47);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom :";
            // 
            // lblPostNom
            // 
            this.lblPostNom.AutoSize = true;
            this.lblPostNom.Location = new System.Drawing.Point(12, 73);
            this.lblPostNom.Name = "lblPostNom";
            this.lblPostNom.Size = new System.Drawing.Size(54, 13);
            this.lblPostNom.TabIndex = 3;
            this.lblPostNom.Text = "Postnom :";
            // 
            // txtPostNom
            // 
            this.txtPostNom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPostNom.Location = new System.Drawing.Point(120, 69);
            this.txtPostNom.Name = "txtPostNom";
            this.txtPostNom.Size = new System.Drawing.Size(298, 20);
            this.txtPostNom.TabIndex = 2;
            // 
            // lblLieuNaiss
            // 
            this.lblLieuNaiss.AutoSize = true;
            this.lblLieuNaiss.Location = new System.Drawing.Point(12, 125);
            this.lblLieuNaiss.Name = "lblLieuNaiss";
            this.lblLieuNaiss.Size = new System.Drawing.Size(99, 13);
            this.lblLieuNaiss.TabIndex = 7;
            this.lblLieuNaiss.Text = "Lieu de naissance :";
            // 
            // txtLieuNais
            // 
            this.txtLieuNais.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLieuNais.Location = new System.Drawing.Point(120, 121);
            this.txtLieuNais.Name = "txtLieuNais";
            this.txtLieuNais.Size = new System.Drawing.Size(298, 20);
            this.txtLieuNais.TabIndex = 6;
            // 
            // lblDteNaiss
            // 
            this.lblDteNaiss.AutoSize = true;
            this.lblDteNaiss.Location = new System.Drawing.Point(12, 99);
            this.lblDteNaiss.Name = "lblDteNaiss";
            this.lblDteNaiss.Size = new System.Drawing.Size(102, 13);
            this.lblDteNaiss.TabIndex = 5;
            this.lblDteNaiss.Text = "Date de naissance :";
            // 
            // lblOrigine
            // 
            this.lblOrigine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrigine.AutoSize = true;
            this.lblOrigine.Location = new System.Drawing.Point(424, 124);
            this.lblOrigine.Name = "lblOrigine";
            this.lblOrigine.Size = new System.Drawing.Size(46, 13);
            this.lblOrigine.TabIndex = 15;
            this.lblOrigine.Text = "Origine :";
            // 
            // txtOrigine
            // 
            this.txtOrigine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrigine.Location = new System.Drawing.Point(527, 121);
            this.txtOrigine.Name = "txtOrigine";
            this.txtOrigine.Size = new System.Drawing.Size(352, 20);
            this.txtOrigine.TabIndex = 14;
            // 
            // lblNumCarte
            // 
            this.lblNumCarte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumCarte.AutoSize = true;
            this.lblNumCarte.Location = new System.Drawing.Point(424, 98);
            this.lblNumCarte.Name = "lblNumCarte";
            this.lblNumCarte.Size = new System.Drawing.Size(97, 13);
            this.lblNumCarte.TabIndex = 13;
            this.lblNumCarte.Text = "Numéro de la carte";
            // 
            // txtNumCarte
            // 
            this.txtNumCarte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumCarte.Location = new System.Drawing.Point(527, 95);
            this.txtNumCarte.Name = "txtNumCarte";
            this.txtNumCarte.Size = new System.Drawing.Size(352, 20);
            this.txtNumCarte.TabIndex = 12;
            // 
            // lblAdresse
            // 
            this.lblAdresse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(424, 72);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(51, 13);
            this.lblAdresse.TabIndex = 11;
            this.lblAdresse.Text = "Adresse :";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdresse.Location = new System.Drawing.Point(527, 69);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(352, 20);
            this.txtAdresse.TabIndex = 10;
            // 
            // lblGenre
            // 
            this.lblGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(424, 46);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(42, 13);
            this.lblGenre.TabIndex = 9;
            this.lblGenre.Text = "Genre :";
            // 
            // dteNaiss
            // 
            this.dteNaiss.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dteNaiss.Location = new System.Drawing.Point(120, 96);
            this.dteNaiss.Name = "dteNaiss";
            this.dteNaiss.Size = new System.Drawing.Size(298, 20);
            this.dteNaiss.TabIndex = 16;
            // 
            // cboGenre
            // 
            this.cboGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Items.AddRange(new object[] {
            "Masculin",
            "Féminin",
            "Autres"});
            this.cboGenre.Location = new System.Drawing.Point(527, 41);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(352, 21);
            this.cboGenre.TabIndex = 17;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(15, 153);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(864, 191);
            this.dgvData.TabIndex = 18;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baseDeDonnéeToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(891, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStripMain";
            // 
            // baseDeDonnéeToolStripMenuItem
            // 
            this.baseDeDonnéeToolStripMenuItem.Name = "baseDeDonnéeToolStripMenuItem";
            this.baseDeDonnéeToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.baseDeDonnéeToolStripMenuItem.Text = "Base de donnée";
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNew.Location = new System.Drawing.Point(15, 350);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 20;
            this.btnNew.Text = "Nouveau";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(96, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Location = new System.Drawing.Point(258, 350);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnToModify
            // 
            this.btnToModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnToModify.Location = new System.Drawing.Point(177, 350);
            this.btnToModify.Name = "btnToModify";
            this.btnToModify.Size = new System.Drawing.Size(75, 23);
            this.btnToModify.TabIndex = 22;
            this.btnToModify.Text = "Modifier";
            this.btnToModify.UseVisualStyleBackColor = true;
            // 
            // btnSaveToJSON
            // 
            this.btnSaveToJSON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveToJSON.Location = new System.Drawing.Point(420, 350);
            this.btnSaveToJSON.Name = "btnSaveToJSON";
            this.btnSaveToJSON.Size = new System.Drawing.Size(169, 23);
            this.btnSaveToJSON.TabIndex = 25;
            this.btnSaveToJSON.Text = "Enregistrer dans le fichier JSON";
            this.btnSaveToJSON.UseVisualStyleBackColor = true;
            // 
            // btnLoard
            // 
            this.btnLoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoard.Location = new System.Drawing.Point(339, 350);
            this.btnLoard.Name = "btnLoard";
            this.btnLoard.Size = new System.Drawing.Size(75, 23);
            this.btnLoard.TabIndex = 24;
            this.btnLoard.Text = "Charger";
            this.btnLoard.UseVisualStyleBackColor = true;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 401);
            this.Controls.Add(this.btnSaveToJSON);
            this.Controls.Add(this.btnLoard);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnToModify);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.cboGenre);
            this.Controls.Add(this.dteNaiss);
            this.Controls.Add(this.lblOrigine);
            this.Controls.Add(this.txtOrigine);
            this.Controls.Add(this.lblNumCarte);
            this.Controls.Add(this.txtNumCarte);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblLieuNaiss);
            this.Controls.Add(this.txtLieuNais);
            this.Controls.Add(this.lblDteNaiss);
            this.Controls.Add(this.lblPostNom);
            this.Controls.Add(this.txtPostNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "CENI (Recessement)";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPostNom;
        private System.Windows.Forms.TextBox txtPostNom;
        private System.Windows.Forms.Label lblLieuNaiss;
        private System.Windows.Forms.TextBox txtLieuNais;
        private System.Windows.Forms.Label lblDteNaiss;
        private System.Windows.Forms.Label lblOrigine;
        private System.Windows.Forms.TextBox txtOrigine;
        private System.Windows.Forms.Label lblNumCarte;
        private System.Windows.Forms.TextBox txtNumCarte;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.DateTimePicker dteNaiss;
        private System.Windows.Forms.ComboBox cboGenre;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem baseDeDonnéeToolStripMenuItem;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnToModify;
        private System.Windows.Forms.Button btnSaveToJSON;
        private System.Windows.Forms.Button btnLoard;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

