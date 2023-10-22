using Microsoft.Graph;
using MiNET;
using System;
using System.Media;
using System.Windows.Media;

namespace RacingGame
{
	public partial class Form1 : Form
	{

		private Point pos; // точка, в которую нажали мышкой
		private bool dragging, gameOver = false; // передвигаеться ли окно
		private int countCoins = 0;
		public Form1()
		{
			InitializeComponent();

			// обработчики событий:
			bg1.MouseDown += MouseClickDown;
			bg1.MouseUp += MouseClickUp;
			bg1.MouseMove += MouseClickMove;
			bg2.MouseDown += MouseClickDown;
			bg2.MouseUp += MouseClickUp;
			bg2.MouseMove += MouseClickMove;


			babkaGO.Visible = false;
			namasteGO.Visible = false;
			coin.Visible = true;
			btnRestart.Visible = false;
			KeyPreview = true;



		}

		private void MouseClickMove(object? sender, MouseEventArgs e)
		{
			if (dragging)
			{
				Point currentPoint = PointToScreen(new Point(e.X, e.Y));
				this.Location = new Point(currentPoint.X - pos.X, currentPoint.Y - pos.Y + bg1.Top);
			}
		}

		private void MouseClickUp(object? sender, MouseEventArgs e)
		{
			dragging = false;
		}

		private void MouseClickDown(object? sender, MouseEventArgs e)
		{
			dragging = true;
			pos.X = e.X;
			pos.Y = e.Y;
		}

		private void Form1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Escape)
			{
				this.Close();
			}
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			int speed = 5;
			bg1.Top += speed;
			bg2.Top += speed;

			int unitSpeed = 5;
			babka.Top += unitSpeed;
			namaste.Top += unitSpeed;

			coin.Top += speed;

			if (bg1.Top >= 640)
			{
				bg1.Top = 0;
				bg2.Top = -640;
			}

			if (babka.Top >= 650)
			{
				babka.Top = -120;
				Random random = new Random();
				babka.Left = random.Next(150, 300);
			}
			if (namaste.Top >= 650)
			{
				namaste.Top = -400;
				Random random = new Random();
				namaste.Left = random.Next(300, 560);
			}

			if (coin.Top >= 650)
			{
				coin.Top = -50;
				Random random = new Random();
				coin.Left = random.Next(150, 560);
			}

			if (player.Bounds.IntersectsWith(babka.Bounds))
			{
				timer.Enabled = false;
				babkaGO.Visible = true;
				btnRestart.Visible = true;
				gameOver = true;
				coin.Visible = false;

			}

			if (player.Bounds.IntersectsWith(namaste.Bounds))
			{
				timer.Enabled = false;
				namasteGO.Visible = true;
				btnRestart.Visible = true;
				coin.Visible = false;

			}

			if (player.Bounds.IntersectsWith(coin.Bounds))
			{
				countCoins ++;
				coins.Text = "Монеты: " + countCoins.ToString();
				coin.Top = -50;
				Random random = new Random();
				coin.Left = random.Next(150, 560);
			}

		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (gameOver) return;

			int speed = 10;
			if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A && player.Left > 150)
			{
				player.Left -= speed;
			}
			else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D && player.Right < 700)
			{
				player.Left += speed;
			}
		}

		private void btnRestart_Click(object sender, EventArgs e)
		{
			babka.Top = -130;
			namaste.Top = -400;
			babkaGO.Visible = false;
			namasteGO.Visible = false;
			btnRestart.Visible = false;
			timer.Enabled = true;
			gameOver = false;
			countCoins = 0;
			coins.Text = "Монеты: 0";
			coin.Visible = true;
			coin.Top = -500;
		}
	}
}