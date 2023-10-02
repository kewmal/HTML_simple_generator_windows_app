/*
 * Created by SharpDevelop.
 * User: Paweł Malicki
 * Date: 02.10.2023
 * Time: 16:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace projekt
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void Button1Click(object sender, EventArgs e)
		{
			textBox1.Text="<html><head></head><body><h1>Wygenerowana strona internetowa</h1></body></html>";
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void Button2Click(object sender, EventArgs e)
		{
			MessageBox.Show("Zrobione przez:\nPaweł Kewin Malicki");
		}
	}
}
