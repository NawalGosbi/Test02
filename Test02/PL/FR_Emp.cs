using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test02.PL
{
    public partial class FR_Emp : Form
    {
        public FR_Emp()
        {
            InitializeComponent();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FR_Emp_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("First Name", typeof(string));
            table.Columns.Add("Last Name", typeof(string));
            table.Columns.Add("Age", typeof(int));

            table.Rows.Add(1, "First A", "Last A", 10);

            dataGridView1.DataSource = table;
                        
            DataGridViewImageColumn dimg = new DataGridViewImageColumn();
            dimg.Image = Properties.Resources.edit1;
            dimg.HeaderText = "Image";

            DataGridViewImageColumn dgvArchives = new DataGridViewImageColumn();
            dgvArchives.Image = Properties.Resources._71059677_371867253758256_8064410691538255872_n;
            dgvArchives.HeaderText = "ارشفة";

            dataGridView1.AllowUserToAddRows = false;
      
            dataGridView1.Columns.Add(dimg);
            dataGridView1.Columns.Add(dgvArchives);
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }
    }
}
