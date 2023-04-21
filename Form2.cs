using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ComputerInfo
{
	public partial class Form2 : MaterialForm
	{
		public Form2()
		{
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
