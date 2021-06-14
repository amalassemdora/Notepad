using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
	public partial class Notepad : Form
	{
		string path;
		public Notepad()
		{
			InitializeComponent();
		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			rtf_note.Clear();
			path = null;
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (opendialog.ShowDialog() == DialogResult.OK)
			{
				rtf_note.LoadFile(opendialog.FileName);
				path = opendialog.FileName;
			}
		}

		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (savedialog.ShowDialog() == DialogResult.OK)
			{
				rtf_note.SaveFile(savedialog.FileName);
				rtf_note.Clear();
			}
		}

		private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			if (path != null)
			{
				rtf_note.SaveFile(path);
				path = null;
			}
			else
			{
				if (savedialog.ShowDialog() == DialogResult.OK)
				{
					rtf_note.SaveFile(savedialog.FileName);
					rtf_note.Clear();
				}
			}
		}

		private void fontToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (fontdialog.ShowDialog() == DialogResult.OK)
			{
				if (rtf_note.SelectedText != "")
				{
					rtf_note.SelectionFont = fontdialog.Font;
				}
				else
				{
					rtf_note.Font = fontdialog.Font;
				}
			}
		}

		private void colorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (colordialog.ShowDialog() == DialogResult.OK)
			{
				if (rtf_note.SelectedText != "")
				{
					rtf_note.SelectionColor = colordialog.Color;
				}
				else
				{
					rtf_note.ForeColor = colordialog.Color;
				}
			}
		}
	}
}
