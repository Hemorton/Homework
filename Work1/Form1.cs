using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work1
{
	public partial class Form1 : Form
	{
		Random random = new Random();
		int answer, playerChose;

		public Form1()
		{			
			InitializeComponent();
			Title.Text = "剪刀 石頭 布";
			answer = RamdomAnswer();
			winTimer.Text = "";
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Console.WriteLine("Load");
		}

		private void label1_Click(object sender, EventArgs e)
		{
			Console.WriteLine("label1_Click");
		}

		private void PaperBut_Click_1(object sender, EventArgs e)
		{					
			playerChose = 2;
			ShowAnswer();
			Dule();
		}

		private void StoneBut_Click_1(object sender, EventArgs e)
		{
			playerChose = 1;
			ShowAnswer();
			Dule();
		}

		private void ScissorsBut_Click_1(object sender, EventArgs e)
		{			
			playerChose = 0;
			ScissorsBut.Location.Offset(100, 0);
			ShowAnswer();
			Dule();
		}

		private int RamdomAnswer() 
		{
			return random.Next(0, 3);
		}

		private void Dule() 
		{
			if (playerChose == answer) 
			{
				Title.Text = "平局";
				
			}
			else 
			{
				switch (playerChose)
				{
					case 0:
						if (answer == 1)
						{
							Title.Text = "You Lose!";
						}
						else if (answer == 2)
						{
							Title.Text = "You Win!";
						}
						break;
					case 1:
						if (answer == 2)
						{
							Title.Text = "You Lose!";
						}
						else if (answer == 0)
						{
							Title.Text = "You Win!";
						}
						break;
					case 2:
						if (answer == 0)
						{
							Title.Text = "You Lose!";
						}
						else if (answer == 1)
						{
							Title.Text = "You Win";
						}
						break;
				}
			}

			answer = RamdomAnswer();
		}

		private void ShowAnswer() 
		{
			switch (answer) 
			{
				case 0:
					winTimer.Text = "電腦出剪刀";
					answerImage.Image = Image.FromFile("C:\\Users\\user\\Desktop\\我的東東\\作業\\程式\\咖都.jpg");
					break;
				case 1:
					winTimer.Text = "電腦出石頭";
					answerImage.Image = Image.FromFile("C:\\Users\\user\\Desktop\\我的東東\\作業\\程式\\stone.jpg");
					break;
				case 2:
					winTimer.Text = "電腦出布";
					answerImage.Image = Image.FromFile("C:\\Users\\user\\Desktop\\我的東東\\作業\\程式\\布.jpg");
					break;
			}
		}
	}
}
