using DBBeadando.Models.Manager;
using DBBeadando.Models.Records;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBBeadando
{
    public partial class Form1 : Form
    {
        BackgroundWorker bgWorker;
        List<Jatekok> jatekokList;
        KaszinoJatekokTabla kaszinojatekoktabla;


        public Form1()
        {
            InitializeComponent();
            kaszinojatekoktabla = new KaszinoJatekokTabla();
            jatekokList = new List<Jatekok>();
            bgWorker = new BackgroundWorker();
        }


        private void dgv_Jatekok_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void button_delete_Click(object sender, EventArgs e)
        {
            int ToroltSorok = 0;
            foreach (DataGridView selectedRows in dgv_Jatekok.SelectedRows)
            {
                Jatekok TorlendoRecord = new Jatekok();
                TorlendoRecord.Asztalkod = selectedRows.Cells["asztalkod"].Value.ToString();

                ToroltSorok += kaszinojatekoktabla.Delete(TorlendoRecord);
            }

            MessageBox.Show(string.Format("{0} sor törölve lett", ToroltSorok));
            if (ToroltSorok != 0)
            {
                bgWorker.RunWorkerAsync();
            }
        }
        private void button_insert_Click(object sender, EventArgs e)
        {
            Jatekok jatek = new Jatekok()
            {
                Asztalkod = textBox_asztalkod.Text,
                Jatekasztalneve = textBox_gametable.Text,
                Krupie = textBox_krupie.Text,
                Jatektipusa = comboBox_gametype.SelectedItem.ToString(),
                Gyarto = textBox_gyarto.Text,
                Asztallimit = textBox_limit.Text,
                Asztal_datuma = dateTimePicker_kelt.Value

            };
            kaszinojatekoktabla.Insert(jatek);
            bgWorker.RunWorkerAsync();

            MessageBox.Show("Sikeres játék feltöltés!");
            textBox_asztalkod.Clear();
            textBox_gametable.Clear();
            textBox_krupie.Clear();
            textBox_gyarto.Clear();
            textBox_limit.Clear();

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            bgWorker.WorkerSupportsCancellation = true;

            dateTimePicker_kelt.CustomFormat = "yyyy";
            dateTimePicker_kelt.ShowUpDown = true;
            comboBox_gametype.DataSource = Enum.GetValues(typeof(Jatektipusa));

            InitDataGridView();

        }

        private void Form1_Show(object sender, EventArgs e)
        {
            bgWorker.RunWorkerAsync();
        }

        private void InitDataGridView()
        {
            dgv_Jatekok.Rows.Clear();
            dgv_Jatekok.Columns.Clear();

            DataGridViewColumn AsztalkodColumn = new DataGridViewColumn()
            {
                Name = "asztalkod",
                HeaderText = "Asztalkód",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            };
            dgv_Jatekok.Columns.Add(AsztalkodColumn);

            DataGridViewColumn JatekasztalneveColumn = new DataGridViewColumn()
            {
                Name = "Jatekasztalneve",
                HeaderText = "Játékasztalneve",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            };
            dgv_Jatekok.Columns.Add(JatekasztalneveColumn);

            DataGridViewColumn GyartoColumn = new DataGridViewColumn()
            {
                Name = "Gyarto",
                HeaderText = "Gyártó",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            };
            dgv_Jatekok.Columns.Add(GyartoColumn);

            DataGridViewColumn KrupieColumn = new DataGridViewColumn()
            {
                Name = "Krupie",
                HeaderText = "Krupié",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            };
            dgv_Jatekok.Columns.Add(KrupieColumn);

            DataGridViewColumn LimitColumn = new DataGridViewColumn()
            {
                Name = "asztallimit",
                HeaderText = "Asztallimit",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            };
            dgv_Jatekok.Columns.Add(LimitColumn);

            DataGridViewColumn TipusColumn = new DataGridViewColumn()
            {
                Name = "Jatektipus",
                HeaderText = "Játéktípusa",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            };
            dgv_Jatekok.Columns.Add(TipusColumn);

            DataGridViewColumn KeltColumn = new DataGridViewColumn()
            {
                Name = "Jatekkelido",
                HeaderText = "JátékKeletkezésénekIdeje",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            };
            dgv_Jatekok.Columns.Add(KeltColumn);

        }
        private void BgWorker_RunWorkerComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            FillDataGridView();
        }

        private void FillDataGridView()
        {
            DataGridViewRow[] dataGridViewRows = new DataGridViewRow[jatekokList.Count];

            for (int i = 0; i < jatekokList.Count; i++)
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();

                DataGridViewCell AsztalkodCell = new DataGridViewTextBoxCell();
                AsztalkodCell.Value = jatekokList[i].Asztalkod;
                dataGridViewRow.Cells.Add(AsztalkodCell);


                DataGridViewCell JatekanevCell = new DataGridViewTextBoxCell();
                JatekanevCell.Value = jatekokList[i].Jatekasztalneve;
                dataGridViewRow.Cells.Add(JatekanevCell);

                DataGridViewCell GyartoCell = new DataGridViewTextBoxCell();
                GyartoCell.Value = jatekokList[i].Gyarto;
                dataGridViewRow.Cells.Add(GyartoCell);

                DataGridViewCell KrupieCell = new DataGridViewTextBoxCell();
                KrupieCell.Value = jatekokList[i].Krupie;
                dataGridViewRow.Cells.Add(KrupieCell);

                DataGridViewCell LimitCell = new DataGridViewTextBoxCell();
                LimitCell.Value = jatekokList[i].Asztallimit;
                dataGridViewRow.Cells.Add(LimitCell);

                DataGridViewCell TipusCell = new DataGridViewTextBoxCell();
                TipusCell.Value = jatekokList[i].Jatektipusa;
                dataGridViewRow.Cells.Add(TipusCell);

                DataGridViewCell KeltCell = new DataGridViewTextBoxCell();
                KeltCell.Value = jatekokList[i].Asztal_datuma;
                dataGridViewRow.Cells.Add(KeltCell);



                dataGridViewRows[i] = dataGridViewRow;
            }
            dgv_Jatekok.Rows.Clear();
            dgv_Jatekok.Rows.AddRange(dataGridViewRows);
        }

        private void textBox_Asztalkod_Leave(object sender, EventArgs e)
        {
            string actual = textBox_asztalkod.Text;
            bool correct = kaszinojatekoktabla.CheckAsztalkod(actual);
            textBox_asztalkod.BackColor = correct ? Color.White : Color.Green;
        }


        


    }
}
