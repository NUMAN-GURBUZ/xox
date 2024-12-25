using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace xox
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void Bt9Click(object sender, EventArgs e)
		{
			Button button = sender as Button;
			if (labelX.Text == "X")
			{
				button.Text = "X";
				button.Enabled = false;
				labelX.Text = "O";
			}
			
			else if (labelX.Text == "O")
			{
				button.Text = "O";
				button.Enabled = false;
				labelX.Text = "X";
			}
			
			kontrol();
		}
		
		private void kontrol()
		{				
			if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
			{
				MessageBox.Show("X OYUNCUSU KAZANDI");
				yeniOyun();
			}
			
			if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
			{
				MessageBox.Show("X OYUNCUSU KAZANDI");
				yeniOyun();
			}
			
			if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
			{
				MessageBox.Show("X OYUNCUSU KAZANDI");
				yeniOyun();
			}
			
			if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
			{
				MessageBox.Show("X OYUNCUSU KAZANDI");
				yeniOyun();
			}
			
			if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
			{
				MessageBox.Show("X OYUNCUSU KAZANDI");
				yeniOyun();
			}
			
			if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
			{
				MessageBox.Show("X OYUNCUSU KAZANDI");
				yeniOyun();
			}
			
			if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
			{
				MessageBox.Show("X OYUNCUSU KAZANDI");
				yeniOyun();
			}
			
			if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
			{
				MessageBox.Show("O OYUNCUSU KAZANDI");
				yeniOyun();
			}
			
			if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
			{
				MessageBox.Show("O OYUNCUSU KAZANDI");
				yeniOyun();
			}
			
			if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
			{
				MessageBox.Show("O OYUNCUSU KAZANDI");
				yeniOyun();
			}
			
			if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
			{
				MessageBox.Show("O OYUNCUSU KAZANDI");
				yeniOyun();
			}
			
			if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
			{
				MessageBox.Show("O OYUNCUSU KAZANDI");
				yeniOyun();
			}
			
			if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
			{
				MessageBox.Show("O OYUNCUSU KAZANDI");
				yeniOyun();
			}
			
			if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
			{
				MessageBox.Show("O OYUNCUSU KAZANDI");
				yeniOyun();
			}
			
			if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
			{
				MessageBox.Show("O OYUNCUSU KAZANDI");
				yeniOyun();
			}
			
			if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
			{
				MessageBox.Show("O OYUNCUSU KAZANDI");
				yeniOyun();
			}
			
			else if (button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "")
			{
				MessageBox.Show("KAZANAN YOK");
				yeniOyun();
			}
		}
		
		private void yeniOyun()
		{
			labelX.Text = "X";
			button1.Text = "";
			button2.Text = "";
			button3.Text = "";
			button4.Text = "";
			button5.Text = "";
			button6.Text = "";
			button7.Text = "";
			button8.Text = "";
			button9.Text = "";
			button1.Enabled = true;
			button2.Enabled = true;
			button3.Enabled = true;
			button4.Enabled = true;
			button5.Enabled = true;
			button6.Enabled = true;
			button7.Enabled = true;
			button8.Enabled = true;
			button9.Enabled = true;
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			yeniOyun();
		}
	}
}
