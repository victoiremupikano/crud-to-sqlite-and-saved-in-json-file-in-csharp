namespace sqliteDbToJsonFile.Views
{
    partial class frmSettingsDb
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
            this.txtIp = new System.Windows.Forms.TextBox();
            this.btnTry = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblIp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(12, 45);
            this.txtIp.Multiline = true;
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(249, 117);
            this.txtIp.TabIndex = 0;
            // 
            // btnTry
            // 
            this.btnTry.Location = new System.Drawing.Point(13, 169);
            this.btnTry.Name = "btnTry";
            this.btnTry.Size = new System.Drawing.Size(116, 23);
            this.btnTry.TabIndex = 1;
            this.btnTry.Text = "Tester";
            this.btnTry.UseVisualStyleBackColor = true;
            this.btnTry.Click += new System.EventHandler(this.btnTry_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(135, 169);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Sauvegarder";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(13, 26);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(35, 13);
            this.lblIp.TabIndex = 3;
            this.lblIp.Text = "Path :";
            // 
            // frmSettingsDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 363);
            this.Controls.Add(this.lblIp);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnTry);
            this.Controls.Add(this.txtIp);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettingsDb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Base de donnée";
            this.Load += new System.EventHandler(this.frmSettingsDb_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Button btnTry;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblIp;
    }
}

