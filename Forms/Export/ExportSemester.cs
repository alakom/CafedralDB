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
    public partial class ExportSemester : Form
    {
        public ExportSemester()
        {
            InitializeComponent();
        }

        private void ExportSemester_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDBDataSet.Semester' table. You can move, or remove it, as needed.
            this.semesterTableAdapter.Fill(this.mainDBDataSet.Semester);
            // TODO: This line of code loads data into the 'mainDBDataSet.StudyYear' table. You can move, or remove it, as needed.
            this.studyYearTableAdapter.Fill(this.mainDBDataSet.StudyYear);
			comboBoxSemester.SelectedIndex = 0;
            comboBoxSemester.DataSource = Enum.GetValues(typeof(SourceCode.Utilities.SemesterName));

		}

		private void buttonExport_Click(object sender, EventArgs e)
		{
            var selectedSemester=(SourceCode.Utilities.SemesterName)comboBoxSemester.SelectedItem;
            SourceCode.Model.Exporter.ExportSemester.Export(comboBoxYear.SelectedValue.ToString(), selectedSemester);
		}
	}
}
