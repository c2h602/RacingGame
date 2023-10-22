namespace RacingGame
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			bg1 = new PictureBox();
			player = new PictureBox();
			timer = new System.Windows.Forms.Timer(components);
			bg2 = new PictureBox();
			babka = new PictureBox();
			namaste = new PictureBox();
			namasteGO = new PictureBox();
			babkaGO = new Label();
			btnRestart = new Button();
			coin = new PictureBox();
			coins = new Label();
			((System.ComponentModel.ISupportInitialize)bg1).BeginInit();
			((System.ComponentModel.ISupportInitialize)player).BeginInit();
			((System.ComponentModel.ISupportInitialize)bg2).BeginInit();
			((System.ComponentModel.ISupportInitialize)babka).BeginInit();
			((System.ComponentModel.ISupportInitialize)namaste).BeginInit();
			((System.ComponentModel.ISupportInitialize)namasteGO).BeginInit();
			((System.ComponentModel.ISupportInitialize)coin).BeginInit();
			SuspendLayout();
			// 
			// bg1
			// 
			bg1.BackgroundImage = (Image)resources.GetObject("bg1.BackgroundImage");
			bg1.BackgroundImageLayout = ImageLayout.None;
			bg1.Location = new Point(0, 0);
			bg1.Name = "bg1";
			bg1.Size = new Size(840, 650);
			bg1.TabIndex = 0;
			bg1.TabStop = false;
			// 
			// player
			// 
			player.BackColor = Color.Transparent;
			player.BackgroundImage = (Image)resources.GetObject("player.BackgroundImage");
			player.Image = (Image)resources.GetObject("player.Image");
			player.Location = new Point(447, 505);
			player.Name = "player";
			player.Size = new Size(82, 133);
			player.SizeMode = PictureBoxSizeMode.StretchImage;
			player.TabIndex = 1;
			player.TabStop = false;
			// 
			// timer
			// 
			timer.Enabled = true;
			timer.Interval = 15;
			timer.Tick += timer_Tick;
			// 
			// bg2
			// 
			bg2.BackgroundImage = (Image)resources.GetObject("bg2.BackgroundImage");
			bg2.Location = new Point(0, -650);
			bg2.Name = "bg2";
			bg2.Size = new Size(840, 650);
			bg2.TabIndex = 2;
			bg2.TabStop = false;
			// 
			// babka
			// 
			babka.Image = (Image)resources.GetObject("babka.Image");
			babka.Location = new Point(180, -120);
			babka.Name = "babka";
			babka.Size = new Size(100, 123);
			babka.SizeMode = PictureBoxSizeMode.StretchImage;
			babka.TabIndex = 3;
			babka.TabStop = false;
			// 
			// namaste
			// 
			namaste.Image = (Image)resources.GetObject("namaste.Image");
			namaste.Location = new Point(447, -400);
			namaste.Name = "namaste";
			namaste.Size = new Size(76, 95);
			namaste.SizeMode = PictureBoxSizeMode.StretchImage;
			namaste.TabIndex = 4;
			namaste.TabStop = false;
			// 
			// namasteGO
			// 
			namasteGO.Image = (Image)resources.GetObject("namasteGO.Image");
			namasteGO.Location = new Point(127, 82);
			namasteGO.Name = "namasteGO";
			namasteGO.Size = new Size(606, 456);
			namasteGO.SizeMode = PictureBoxSizeMode.StretchImage;
			namasteGO.TabIndex = 5;
			namasteGO.TabStop = false;
			// 
			// babkaGO
			// 
			babkaGO.AutoSize = true;
			babkaGO.BackColor = Color.Transparent;
			babkaGO.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Point);
			babkaGO.ForeColor = Color.Red;
			babkaGO.Location = new Point(194, 277);
			babkaGO.Name = "babkaGO";
			babkaGO.Size = new Size(517, 59);
			babkaGO.TabIndex = 6;
			babkaGO.Text = "Вы сбили бабку...";
			// 
			// btnRestart
			// 
			btnRestart.BackColor = SystemColors.AppWorkspace;
			btnRestart.FlatStyle = FlatStyle.Flat;
			btnRestart.Font = new Font("Impact", 48F, FontStyle.Bold, GraphicsUnit.Point);
			btnRestart.ForeColor = Color.MediumOrchid;
			btnRestart.ImageAlign = ContentAlignment.TopCenter;
			btnRestart.Location = new Point(240, 544);
			btnRestart.Name = "btnRestart";
			btnRestart.Size = new Size(428, 83);
			btnRestart.TabIndex = 7;
			btnRestart.Text = "Продолжить";
			btnRestart.UseVisualStyleBackColor = false;
			btnRestart.Click += btnRestart_Click;
			// 
			// coin
			// 
			coin.Image = (Image)resources.GetObject("coin.Image");
			coin.Location = new Point(317, -550);
			coin.Name = "coin";
			coin.Size = new Size(78, 69);
			coin.SizeMode = PictureBoxSizeMode.StretchImage;
			coin.TabIndex = 8;
			coin.TabStop = false;
			// 
			// coins
			// 
			coins.AutoSize = true;
			coins.BackColor = Color.Silver;
			coins.Font = new Font("Impact", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			coins.ForeColor = Color.MediumOrchid;
			coins.Location = new Point(22, 18);
			coins.Name = "coins";
			coins.Size = new Size(182, 43);
			coins.TabIndex = 9;
			coins.Text = "Монеты: 0";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(840, 650);
			Controls.Add(coins);
			Controls.Add(coin);
			Controls.Add(btnRestart);
			Controls.Add(babkaGO);
			Controls.Add(namasteGO);
			Controls.Add(namaste);
			Controls.Add(babka);
			Controls.Add(player);
			Controls.Add(bg1);
			Controls.Add(bg2);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(3, 2, 3, 2);
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Form1";
			KeyDown += Form1_KeyDown;
			KeyPress += Form1_KeyPress;
			((System.ComponentModel.ISupportInitialize)bg1).EndInit();
			((System.ComponentModel.ISupportInitialize)player).EndInit();
			((System.ComponentModel.ISupportInitialize)bg2).EndInit();
			((System.ComponentModel.ISupportInitialize)babka).EndInit();
			((System.ComponentModel.ISupportInitialize)namaste).EndInit();
			((System.ComponentModel.ISupportInitialize)namasteGO).EndInit();
			((System.ComponentModel.ISupportInitialize)coin).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox bg1;
		private PictureBox player;
		private System.Windows.Forms.Timer timer;
		private PictureBox bg2;
		private PictureBox babka;
		private PictureBox namaste;
		private PictureBox namasteGO;
		private Label babkaGO;
		private Button btnRestart;
		private PictureBox coin;
		private Label coins;
	}
}