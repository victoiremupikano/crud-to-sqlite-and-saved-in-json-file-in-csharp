using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace sqliteDbToJsonFile.Services
{
    class DtgvServices
    {
        //valeur en retourner
        public double tot_colonne { set; get; }
        public Int64 nbr_ligne { set; get; }
        private bool result = false;

        public bool DGV_only_rows_has_true(DataGridView dgv, int cell)
        {
            //entier comptant le nombre des true values
            int i = 0;

            foreach (DataGridViewRow dr in dgv.Rows)
            {
                if (dr.Cells[cell].Value != null && (bool)dr.Cells[cell].Value)
                { i = i + 1; }
                else if (dr.Cells[cell].Value == null) { }
                else { }
            }
            //on compte en vrai pour instancier le resultat
            if (i <= 1)
            { result = true; }
            else
            { result = false; }
            return result;
        }

        public double DGV_total(DataGridView dgv, int cell)
        {
            // on vide les var receptif
            tot_colonne = 0;
            double sum = 0;

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                sum += double.Parse(dgv.Rows[i].Cells[cell].Value.ToString());
            }
            tot_colonne = sum;
            return tot_colonne;
        }
        public Int64 DGV_number_line(DataGridView dgv)
        {
            //on vide les var
            nbr_ligne = 0;
            Int64 Nbr = 0;
            Nbr = dgv.RowCount;
            nbr_ligne = Nbr;
            return nbr_ligne;
        }
        public Int64 RADDGV_number_line(DataGridView dgv)
        {
            //on vide les var
            nbr_ligne = 0;
            Int64 Nbr = 0;
            Nbr = dgv.RowCount;
            nbr_ligne = Nbr;
            return nbr_ligne;
        }

        DataTable dt = new DataTable(); // pour les categories

        public DataGridView delete(DataGridView dgv)
        {
            dt.Clear();
            //on la charge
            dgv.DataSource = dt;
            return dgv;
        }

        public DataGridView empty(DataGridView dgv)
        {
            dgv.Rows.Clear();
            return dgv;
        }

        //fonction pour enlever une ligne dans un dgv
        public DataGridView cutRow(DataGridView dgv)
        {
            if (dgv.Rows.Count > 0)
            {
                foreach (DataGridViewRow dr in dgv.Rows)
                {
                    if (dr.Selected == true)
                    {
                        int index = dr.Index;
                        dgv.Rows.RemoveAt(index);
                    }                    
                }
            }
            else
            {
                // on fait rien
            }
            return dgv;
        }

        //fonction pour enlever une ligne dans un dgv
        public DataGridView cutRowRad(DataGridView dgv)
        {
            if (dgv.Rows.Count > 0)
            {
                int index = dgv.CurrentRow.Index;
                dgv.Rows.RemoveAt(index);
            }
            else
            {
                // on fait rien
            }
            return dgv;
        }
    }
}
