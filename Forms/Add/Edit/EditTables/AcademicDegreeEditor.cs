﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafedralDB.Forms.Add.Edit.EditTables
{
	public partial class AcademicDegreeEditor : Form
	{
		public AcademicDegreeEditor()
		{
			InitializeComponent();
		}

		private void AcademicDegreeEditor_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'mainDBDataSet.AcademicDegree' table. You can move, or remove it, as needed.
			this.academicDegreeTableAdapter.Fill(this.mainDBDataSet.AcademicDegree);

		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			academicDegreeTableAdapter.Update(this.mainDBDataSet.AcademicDegree);
		}
	}
}
