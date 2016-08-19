using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CrazyButton
{
	public partial class MainForm : Form
	{
		int prevX = 0;
		int prevY = 0;
		bool prevSet = false;
				
		public MainForm()
		{
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			MessageBox.Show("Paspaudei");
		}
		
		void Button1MouseMove(object sender, MouseEventArgs e)
		{
			if (prevSet)
			{
				if (e.X < prevX)
				{
					button1.Left += 20;
				}
				else
				{
					button1.Left -= 20;
				}
				if (e.Y < prevY)
				{
					button1.Top += 20;
				}
				else
				{
					button1.Top -= 20;
				}
			}
			prevX = e.X;
			prevY = e.Y;
			prevSet = true;
		}
	}
}
