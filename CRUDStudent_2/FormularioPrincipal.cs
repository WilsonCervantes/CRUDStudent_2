using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDStudent_2
{
    public partial class FormularioPrincipal : Form
    {
        StudentEntities db;
        // Constructor
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        // Carga el datagrid con los datos del estudiante
        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            db = new StudentEntities();
            studentsBindingSource.DataSource = db.Students.ToList();
        }

        private async void tbAdd_Click(object sender, EventArgs e)
        {
            using (frmStudentInfo frm = new frmStudentInfo(new Students() { Gender = false }))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        studentsBindingSource.Add(frm.StudentInfo);
                        db.Students.Add(frm.StudentInfo);
                        await db.SaveChangesAsync();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Mesage", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void tbRefresh_Click(object sender, EventArgs e)
        {
            studentsBindingSource.DataSource = db.Students.ToList();
            foreach(DbEntityEntry entry in db.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case System.Data.Entity.EntityState.Added:
                        entry.State = System.Data.Entity.EntityState.Detached;
                        break;
                    case System.Data.Entity.EntityState.Modified:
                        entry.State = System.Data.Entity.EntityState.Unchanged;
                        break;
                    case System.Data.Entity.EntityState.Deleted:
                        entry.Reload();
                        break;


                }
            }
        }

        private async void tbSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save the changes ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    studentsBindingSource.EndEdit();
                    await db.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        // Editar datos del estudiante en el formulario Stuedentinfo
        private async void tbEdit_Click(object sender, EventArgs e)
        {
            Students obj = studentsBindingSource.Current as Students;
            if (obj!=null)
            {
                using (frmStudentInfo frm = new frmStudentInfo(obj))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            studentsBindingSource.EndEdit();
                            await db.SaveChangesAsync();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Mesage", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }
            
        }

        private void tbDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sere want to delete this record?","Messaje",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                 /*for(int i =0; i < dataGridView.SelectedRows.Count; i++)
                {
                    db.Students.Remove(dataGridView.SelectedRows[i].DataBoundItem as Students);
                    studentsBindingSource.RemoveAt(dataGridView.SelectedRows[i].Index);
                }*/

                int count = dataGridView.RowCount;
                for (int i = count - 1; i >= 0; i--)
                {
                    if (dataGridView.Rows[i].Selected)
                    {
                        db.Students.Remove(dataGridView.Rows[i].DataBoundItem as Students);
                        studentsBindingSource.RemoveAt(dataGridView.Rows[i].Index);
                    }
                }

                studentsBindingSource.EndEdit();
                db.SaveChangesAsync();
            }
        }
    }
}
