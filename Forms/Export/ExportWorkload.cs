﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafedralDB.SourceCode.Model.Exporter;

namespace CafedralDB.Forms.Export
{
    public partial class ExportWorkload : Form
    {
        public ExportWorkload()
        {
            InitializeComponent();
        }

        private void ExportWorkload_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDBDataSet.StudyYear' table. You can move, or remove it, as needed.
            this.studyYearTableAdapter.Fill(this.mainDBDataSet.StudyYear);
			comboBoxYear.SelectedIndex = 0;
		}

		private void buttonExport_Click(object sender, EventArgs e)
		{
            SourceCode.Model.Exporter.ExportWorkload.Export(comboBoxYear.SelectedValue.ToString());
			//Workload.ExportWorkload(comboBoxYear.SelectedValue.ToString());
		}
	}
}