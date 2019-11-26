using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.StudentManagement
{
    public partial class UpdateForm : Form
    {
        private LogicLayer Business;
        private int StudentId;
        private int p;
        public UpdateForm(int id)
        {
            InitializeComponent();
            this.Business = new LogicLayer();
            StudentId = id;
            this.Load += UpdateForm_Load;
        }

     

        void UpdateForm_Load(object sender, EventArgs e)
        {
            var student = this.Business.GetStudent(StudentId);

            this.cbClass.DataSource = this.Business.GetClasses();
            this.cbClass.DisplayMember = "name";
            this.cbClass.ValueMember = "id";

            cbClass.SelectedValue = student.Class_id;


        }
    }
}
