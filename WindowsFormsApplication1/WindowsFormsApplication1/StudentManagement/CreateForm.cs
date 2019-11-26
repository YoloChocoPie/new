﻿using System;
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
    public partial class CreateForm : Form
    {
        private LogicLayer Business;
        public CreateForm()
        {
            InitializeComponent();
            this.Business = new LogicLayer();

            this.Load += CreateForm_Load;

            this.btnSave.Click += btnSave_Click;

            this.btnCancel.Click += btnCancel_Click;
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void btnSave_Click(object sender, EventArgs e)
        {

            var code = this.txtCode.Text;

            var name = this.txtName.Text;

            var birthday = this.dtpBirthday.Value;

            var class_id = (int)this.cbClass.SelectedValue;

            this.Business.CreateStudent(code, name, birthday, class_id);

            MessageBox.Show("done");
            this.Close();
        }

        void CreateForm_Load(object sender, EventArgs e)
        {
            this.cbClass.DataSource = this.Business.GetClasses();
            this.cbClass.DisplayMember = "Name";
            this.cbClass.ValueMember = "id";
        }

        private void CreateForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
