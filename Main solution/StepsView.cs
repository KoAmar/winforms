﻿using System;
using System.Windows.Forms;

namespace Main_solution
{
    public partial class StepsView : Form
    {
        public StepsView(DataBox dataBox)
        {
            InitializeComponent();
            dataBox.CopyToDataGrid(dataBox1);
            dataBox1.ConnectLog(ref textBox1);
        }

        private void Step_Button_Click(object sender, EventArgs e)
        {
            if (dataBox1 == null) return;
            dataBox1.NextStep();
        }
    }
}
