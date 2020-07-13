using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDStudent_2
{
    public partial class frmStudentInfo : Form
    {
        // Esta un una propiedad de la clase frmStudentInfo. 
        //Devuelve el registro actual almacenado en el formulario como una
        // clase tipo Students.
        public Students StudentInfo
        {
            get
            {
                return studentsBindingSource.Current as Students;
            }
        }
        public frmStudentInfo(Students Obj)
        {
            InitializeComponent();
            studentsBindingSource.DataSource = Obj;
            if (chkGender.CheckState == CheckState.Checked)
                chkGender.Text = "Male";
            else if (chkGender.CheckState == CheckState.Unchecked)
                chkGender.Text = "Female";
        }

        private void frmStudentInfo_Load(object sender, EventArgs e)
        {

        }
        
        private  void btnSave_Click_1(object sender, EventArgs e)
        {
            StudentEntities db = new StudentEntities();
            
            Validate();
            studentsBindingSource.EndEdit();
            try
            {
                db.SaveChanges();
            }
            catch (DbEntityValidationException)
            {
                MessageBox.Show("Todos los campos deben ser llenados", "Entity Validation Exception");
            }
            DialogResult = DialogResult.OK;

        }

        private void chkGender_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGender.CheckState == CheckState.Checked)
                chkGender.Text = "Male";
            else if (chkGender.CheckState == CheckState.Unchecked)
                chkGender.Text = "Female";
        }
    }
}
