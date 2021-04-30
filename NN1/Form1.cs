using NN1.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NN1
{
    public partial class Form1 : Form
    {
        private GUIMediator GUIMediator = new GUIMediator();
        public Form1()
        {
            InitializeComponent();
            GUIMediator.showInputVectors = ShowInputVectors;
            GUIMediator.changeRowColor = ChangeRowColor;
        }

        private void ShowInputVectors(int N, int M, List<int[]> data) {
           
            inputDataGridView.DataSource = CreateTable(N,M,data);
            //inputDataGridView.ColumnHeaders
        }

        private void ChangeRowColor(int i) {
            inputDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.Green;
        }

        private static DataTable CreateTable(int N, int M, List<int[]> data) 
        {
            DataTable dataTable = new DataTable("OrderDetail");
            for (int i = 0; i < M; i ++) {
                dataTable.Columns.Add($"abc{i+1}", System.Type.GetType("System.Boolean"));
            }
            DataRow dr;
            for (int j = 0; j < N; j++)

            {
                dr = dataTable.NewRow();
                int[] values=  data[j];
                for (int i = 0; i < M; i ++) {
                    dr[$"abc{i+1}"] = values[i]== 1 ? true : false;
                }
                dataTable.Rows.Add(dr);

            }

            return dataTable;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void createInputButton_Click(object sender, EventArgs e)
        {
            CreateInputDialog dialog = new CreateInputDialog(GUIMediator);
            dialog.ShowDialog();
        }

        private void BuildBtn_Click(object sender, EventArgs e)
        {
            inputDataGridView.EndEdit();
            List<int[]> inputVectors = new List<int[]>();
            foreach (DataGridViewRow row in inputDataGridView.Rows) {
                int[] intRows = new int[GUIMediator.M];
                for (int i = 0; i < GUIMediator.M; i ++)
                {
                    intRows[i] = (true.Equals(row.Cells[i].Value)) ? 1 : -1;
                }
                inputVectors.Add(intRows);

            }
            GUIMediator.InputVectors = inputVectors;
            GUIMediator.createModel();
            Console.WriteLine(inputVectors);
        }

        private void inputDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
