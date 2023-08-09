using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqliteDbToJsonFile.Views
{
    public partial class frmMain : Form
    {
        Services.convertDate valid = new Services.convertDate();
        public frmMain()
        {
            InitializeComponent();
        }

        #region controllers
        private void modify()
        {
            Services.MsgFRM msg = new Services.MsgFRM();
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtNom.Text) || string.IsNullOrEmpty(txtPostNom.Text) || string.IsNullOrEmpty(txtAdresse.Text) || string.IsNullOrEmpty(txtLieuNais.Text) || string.IsNullOrEmpty(txtNumCarte.Text) || string.IsNullOrEmpty(txtOrigine.Text))
            {
                msg.getAttention("Erreur, veiller remplir tous les champs ?");
            }
            else
            {
                if (msg.getDialog("Etes-vous sûr de vouloir modifier ?"))
                {
                    Dictionary<string, string> fields = new Dictionary<string, string>{
                        {"id", txtId.Text},
                        {"nom", txtNom.Text},
                        {"postnom", txtPostNom.Text},
                        {"dteNais", dteNaiss.Value.ToString()},
                        {"lieuNais", txtLieuNais.Text},
                        {"genre", cboGenre.Text},
                        {"adresse", txtAdresse.Text},
                        {"numCarte", txtNumCarte.Text},
                        {"origine", txtOrigine.Text},
                    };

                    //on passe les donnees dans le controllers
                    Controllers.CIndividus obj = new Controllers.CIndividus(fields);
                    obj.update(obj);

                    if (obj.message["type"] == "success")
                    {
                        msg.getInfo(obj.message["message"]);

                        loard();
                    }
                    else if (obj.message["type"] == "failure")
                    {
                        msg.getError(obj.message["message"]);
                    }
                    else
                    {
                        msg.getError(obj.message["message"]);
                    }
                    btnDelete.Enabled = true;
                    btnToModify.Enabled = true;
                    btnSaved.Enabled = false;
                }
            }
        }

        private void delete()
        {
            Services.MsgFRM msg = new Services.MsgFRM();
            if (msg.getDialog("Etes-vous sûr de vouloir supprimer ?"))
            {
                Dictionary<string, string> fields = new Dictionary<string, string>{
                    {"id", txtId.Text},
                };
                //on passe les donnees dans le controllers
                Controllers.CIndividus obj = new Controllers.CIndividus(fields);
                obj.delete(obj);

                if (obj.message["type"] == "success")
                {
                    msg.getInfo(obj.message["message"]);

                    loard();
                }
                else if (obj.message["type"] == "failure")
                {
                    msg.getError(obj.message["message"]);
                }
                else
                {
                    msg.getError(obj.message["message"]);
                }
                btnDelete.Enabled = true;
                btnToModify.Enabled = true;
                btnSaved.Enabled = false;
            }
        }

        private void loard()
        {
            Models.MIndividus obj = new Models.MIndividus();
            obj.get();
            if (obj.callback["type"] == "success")
            {
                //on vide la dgv
                dgvData.Rows.Clear();
                SQLiteDataReader dr = Apps.Query.DR;

                while (dr.Read())
                {
                    //on separe les data
                    dgvData.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());
                }
                Apps.Query.DR.Close();
            }
            else if (obj.callback["type"] == "failure")
            {
                Services.MsgFRM msg = new Services.MsgFRM();
                msg.getError(obj.callback["message"]);
            }
            else
            {
                Services.MsgFRM msg = new Services.MsgFRM();
                msg.getError(obj.callback["message"]);
            }
            btnSaved.Enabled = false;
            btnDelete.Enabled = true;
            btnToModify.Enabled = true;
        }

        private void migrate()
        {
            if (dgvData.Rows.Count > 0 && dgvData.SelectedRows.Count > 0)
            {
                txtId.Text = dgvData.CurrentRow.Cells[0].Value.ToString();
                txtNom.Text = dgvData.CurrentRow.Cells[1].Value.ToString();
                txtPostNom.Text = dgvData.CurrentRow.Cells[2].Value.ToString();
                dteNaiss.Value = DateTime.Parse(dgvData.CurrentRow.Cells[3].Value.ToString());
                txtLieuNais.Text = dgvData.CurrentRow.Cells[4].Value.ToString();
                cboGenre.Text = dgvData.CurrentRow.Cells[5].Value.ToString();
                txtAdresse.Text = dgvData.CurrentRow.Cells[6].Value.ToString();
                txtNumCarte.Text = dgvData.CurrentRow.Cells[7].Value.ToString();
                txtOrigine.Text = dgvData.CurrentRow.Cells[8].Value.ToString();
            }
        }

        private void save()
        {
            Services.MsgFRM msg = new Services.MsgFRM();
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtNom.Text) || string.IsNullOrEmpty(txtPostNom.Text) || string.IsNullOrEmpty(txtAdresse.Text) || string.IsNullOrEmpty(txtLieuNais.Text) || string.IsNullOrEmpty(txtNumCarte.Text) || string.IsNullOrEmpty(txtOrigine.Text))
            {
                msg.getAttention("Erreur, veiller remplir tous les champs ?");
            }
            else
            {
                Services.Crypto crypt = new Services.Crypto();

                Dictionary<string, string> fields = new Dictionary<string, string>{
                    {"id", txtId.Text},
                    {"nom", txtNom.Text},
                    {"postnom", txtPostNom.Text},
                    {"dteNais", dteNaiss.Value.ToString()},
                    {"lieuNais", txtLieuNais.Text},
                    {"genre", cboGenre.Text},
                    {"adresse", txtAdresse.Text},
                    {"numCarte", txtNumCarte.Text},
                    {"origine", txtOrigine.Text},
                };

                //on passe les donnees dans le controllers
                Controllers.CIndividus obj = new Controllers.CIndividus(fields);
                obj.add(obj);

                if (obj.message["type"] == "success")
                {
                    msg.getInfo(obj.message["message"]);

                    loard();
                }
                else if (obj.message["type"] == "failure")
                {
                    msg.getError(obj.message["message"]);
                }
                else
                {
                    msg.getError(obj.message["message"]);
                }
                btnDelete.Enabled = true;
                btnToModify.Enabled = true;
                btnSaved.Enabled = false;
            }
        }

        #endregion
        private void frmMain_Load(object sender, EventArgs e)
        {
            loard();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtAdresse.Text = txtId.Text = txtLieuNais.Text = txtNom.Text = txtNumCarte.Text = txtOrigine.Text = txtPostNom.Text = string.Empty;

            btnToModify.Enabled = false;
            btnDelete.Enabled = false;
            btnSaved.Enabled = true;
        }

        private void btnToModify_Click(object sender, EventArgs e)
        {
            save();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void btnLoard_Click(object sender, EventArgs e)
        {
            loard();
        }
    }
}
