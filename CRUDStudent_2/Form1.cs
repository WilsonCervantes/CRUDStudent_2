using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDStudents
{
    
    public partial class Form1 : Form
    {
        StudentEntities db;
        public Form1()
        {
            InitializeComponent();
        }

        private void tbRefresh2_Click(object sender, EventArgs e)
        {
            studentBindingSource.DataSource = db.Students.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new StudentEntities();
            studentBindingSource.DataSource = db.Students.ToList();

        }

        private async void tbAdd_Click(object sender, EventArgs e)
        {
            using (frmStudentInfo frm = new frmStudentInfo(new Student() { Gender = false }))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        studentBindingSource.Add(frm.StudentInfo);
                        db.Students.Add(frm.StudentInfo);
                        await db.SaveChangesAsync();

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Mesage", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }
    }
}
