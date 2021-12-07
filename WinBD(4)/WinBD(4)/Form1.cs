﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinBD_4_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private BindingSource sotrBindingSourse;
        private void Form1_Load(object sender, EventArgs e)
        {
            сотрудникиTableAdapter1.Fill(productDataSet1.Сотрудники);
            sotrBindingSourse = new
           BindingSource(productDataSet1, "Сотрудники");
            FamtextBox.DataBindings.Add("Text", sotrBindingSourse,
            "Фамилия");
            NametextBox.DataBindings.Add("Text",
           sotrBindingSourse, "Имя");
            SectiontextBox.DataBindings.Add("Text",
           sotrBindingSourse, "Отдел");
        }

        private void Previousbutton_Click(object sender, EventArgs e)
        {
            sotrBindingSourse.MovePrevious();
        }

        private void Nextbutton_Click(object sender, EventArgs e)
        {
            sotrBindingSourse.MoveNext();
        }

        private void oleDbDataAdapter2_RowUpdated(object sender, System.Data.OleDb.OleDbRowUpdatedEventArgs e)
        {

        }
    }
}
