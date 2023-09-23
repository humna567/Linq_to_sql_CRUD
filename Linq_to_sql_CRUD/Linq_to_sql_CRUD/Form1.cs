using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq_to_sql_CRUD
{
    public partial class Form1 : Form
    {
        StudentDBDataContext db;
        public Form1()
        {
            InitializeComponent();
        }

        private void BindGridView()
        {
            db = new StudentDBDataContext();
            dataGridView1.DataSource = db.students;
        }
        private void ClearTextBoxes ()
        {
            foreach(Control ctr in this.Controls )
            {
                if( ctr is TextBox)
                {
                    TextBox txt = ctr as TextBox;

                    txt.Clear();
                }
            }
            NAMEtextBox.Focus ();
        }
        private void INSERTbutton_Click(object sender, EventArgs e)
        {
            db = new StudentDBDataContext();
            student std = new student ();
            std.name = NAMEtextBox.Text;
            std.gender = GENDERtextBox.Text;
            std.age = int.Parse( AGEtextBox.Text);
            std.standard = int.Parse(CLASStextBox.Text);
            db.students.InsertOnSubmit(std);
            db.SubmitChanges();
            MessageBox.Show("Data has been inserted Successfully " , "Success" , MessageBoxButtons.OK,MessageBoxIcon.Information);
            ClearTextBoxes ();
            BindGridView();
        }

        private void CLEARbutton_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindGridView();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            NAMEtextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            GENDERtextBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            AGEtextBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            CLASStextBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            
        }

        private void UPDATEbutton_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count>0)
            {
                db = new StudentDBDataContext();
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                student std = db.students.FirstOrDefault(s => s.Id == id);
                std.name = NAMEtextBox.Text;
                std.gender = GENDERtextBox.Text;
                std.age = int.Parse(AGEtextBox.Text);
                std.standard = int.Parse(CLASStextBox.Text);
                db.SubmitChanges();

                MessageBox.Show("Data has been Update Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBoxes();
                BindGridView();


            }
            else
            {
                 MessageBox.Show("Please select a row", "warning",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

           
        }

        private void DELETEbutton_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult confirm = MessageBox.Show("Are You Sure to Delete Data??", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {

                    db = new StudentDBDataContext();
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    student std = db.students.FirstOrDefault(s => s.Id == id);

                    db.students.DeleteOnSubmit(std);
                    db.SubmitChanges();

                    MessageBox.Show("Data has been Delete  Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxes();
                    BindGridView();

                }
            }
                else
                {

                    MessageBox.Show("Please select a row", "warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
          


            }
        }

    
}
