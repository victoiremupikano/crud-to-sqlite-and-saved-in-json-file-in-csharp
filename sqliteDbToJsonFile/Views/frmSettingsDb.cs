using sqliteDbToJsonFile.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqliteDbToJsonFile.Views
{
    public partial class frmSettingsDb : Form
    {
        public frmSettingsDb()
        {
            InitializeComponent();
        }

        private void btnTry_Click(object sender, EventArgs e)
        {
            Services.MsgFRM msg = new Services.MsgFRM();
            if (string.IsNullOrEmpty(txtIp.Text))
            {
                msg.getAttention("Il y a des champs obligatoire à remplir avant modification ?");
            }
            else
            {
                //on passent les valeurs en tester
                Apps.Query.ip_ = txtIp.Text;
                Apps.Query.try_connexion();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Services.MsgFRM msg = new Services.MsgFRM();
            if (msg.getDialog("Voulez-vous vraiment modifier les paramètres ?"))
            {
                if (string.IsNullOrEmpty(txtIp.Text))
                {
                    msg.getAttention("Il y a des champs obligatoire à remplir avant modification ?");
                }
                else
                {
                    Settings.Default.ip = txtIp.Text;

                    //enregistrement 
                    Settings.Default.Save();
                    msg.getInfo("Successfull, l'application va rédemarrer");
                    Application.Restart();
                }
            }
        }

        private void frmSettingsDb_Load(object sender, EventArgs e)
        {
            // instaciation des valeurs par defaut du bd
            txtIp.Text = Settings.Default.ip;
        }
    }
}
