using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drustvo
{
    public partial class Pregled : Form
    {
        List<Darovi> spremembe = new List<Darovi>();
        string pot = Resource1.pot;
        int stevecSprememb = 0;
        public Pregled()
        {
            InitializeComponent();
            
        }

        private void Pregled_Load(object sender, EventArgs e)
        {
            try {
                FileStream fs = new FileStream(pot, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                Darovi d;
                try {
                    while (true) {
                        d = (Darovi)bf.Deserialize(fs);
                        spremembe.Add(d);
                    }
                }
                catch (SerializationException) { }//konec datoteke
                fs.Close();
                dgwPodatki.DataSource = spremembe;
            }
            catch (Exception) { }//vse ostale napake
        }

        private void Pregled_Shown(object sender, EventArgs e)
        {
            DataGridViewCellStyle dcs = new DataGridViewCellStyle();
            dcs.Format = "##0.00 €";
            dgwPodatki.Columns[3].DefaultCellStyle = dcs;
            dgwPodatki.Columns[4].Width = 175;
            foreach (DataGridViewRow r in dgwPodatki.Rows) {
                double tip = double.Parse(r.Cells[3].Value.ToString()); //vrednost zneska
                if (tip < 0)
                {
                    r.DefaultCellStyle.BackColor = Color.LightPink;
                }
                else { r.DefaultCellStyle.BackColor = Color.LightGray; }

            }
        }

        private void dgwPodatki_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int vrstica = e.RowIndex;
            int stolpec = e.ColumnIndex;
            Darovi d = new Darovi();
            d.ZapSt = int.Parse(dgwPodatki.Rows[vrstica].Cells["Zapst"].Value.ToString());
            d.Datum = DateTime.Parse(dgwPodatki.Rows[vrstica].Cells["Datum"].Value.ToString());
            d.Namen = dgwPodatki.Rows[vrstica].Cells["Namen"].Value.ToString();
            //d.Opombe = dgwPodatki.Rows[vrstica].Cells["Opombe"].Value.ToString();
            d.Znesek = decimal.Parse(dgwPodatki.Rows[vrstica].Cells["Znesek"].Value.ToString());
            spremembe[vrstica] = d;
            PopraviObliko();
            stevecSprememb++;
        }
        private void PopraviObliko() {
            DataGridViewCellStyle dcs = new DataGridViewCellStyle();
            dcs.Format = "##0.00 €";
            dgwPodatki.Columns[3].DefaultCellStyle = dcs;
            dgwPodatki.Columns[4].Width = 175;
            foreach (DataGridViewRow r in dgwPodatki.Rows)
            {
                double tip = double.Parse(r.Cells[3].Value.ToString()); //vrednost zneska
                if (tip < 0)
                {
                    r.DefaultCellStyle.BackColor = Color.LightPink;
                }
                else { r.DefaultCellStyle.BackColor = Color.LightGray; }

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(pot, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            foreach (Darovi d in spremembe) {
                bf.Serialize(fs, d);
            }
            fs.Close();
        }

        private void Pregled_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (stevecSprememb != 0) {
                DialogResult x = MessageBox.Show("Ostajajo neshranjene spremembe. \n Ali želite shraniti?", "Shranjevanje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("alires želite zbrisativrstico?", "Brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (a == DialogResult.Yes) {
                DataGridViewRow vrstica = dgwPodatki.CurrentRow;
                int index = vrstica.Index;
                spremembe.RemoveAt(index);
                dgwPodatki.Rows.RemoveAt(index);
                dgwPodatki.DataSource = null;
                dgwPodatki.Rows.Clear();
                dgwPodatki.DataSource = spremembe;
                PopraviObliko();

                stevecSprememb++;
            }
        }
    }
}
