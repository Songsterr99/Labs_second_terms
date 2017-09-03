namespace LastTarget
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.bNewGame = new System.Windows.Forms.Button();
			this.tbRadius = new System.Windows.Forms.TextBox();
			this.lR = new System.Windows.Forms.Label();
			this.lAlpha = new System.Windows.Forms.Label();
			this.tbAlpha = new System.Windows.Forms.TextBox();
			this.lPatrons = new System.Windows.Forms.Label();
			this.tbPatrons = new System.Windows.Forms.TextBox();
			this.bFire = new System.Windows.Forms.Button();
			this.lX = new System.Windows.Forms.Label();
			this.lY = new System.Windows.Forms.Label();
			this.tbX = new System.Windows.Forms.TextBox();
			this.tbY = new System.Windows.Forms.TextBox();
			this.pNewGame = new System.Windows.Forms.Panel();
			this.pFire = new System.Windows.Forms.Panel();
			this.lHits = new System.Windows.Forms.Label();
			this.lPat = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pNewGame.SuspendLayout();
			this.pFire.SuspendLayout();
			this.SuspendLayout();
			// 
			// bNewGame
			// 
			this.bNewGame.Location = new System.Drawing.Point(13, 13);
			this.bNewGame.Name = "bNewGame";
			this.bNewGame.Size = new System.Drawing.Size(95, 27);
			this.bNewGame.TabIndex = 0;
			this.bNewGame.Text = "New Game";
			this.bNewGame.UseVisualStyleBackColor = true;
			this.bNewGame.Click += new System.EventHandler(this.bNewGame_Click);
			// 
			// tbRadius
			// 
			this.tbRadius.Location = new System.Drawing.Point(69, 4);
			this.tbRadius.Name = "tbRadius";
			this.tbRadius.Size = new System.Drawing.Size(106, 20);
			this.tbRadius.TabIndex = 1;
			// 
			// lR
			// 
			this.lR.AutoSize = true;
			this.lR.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lR.Location = new System.Drawing.Point(3, 3);
			this.lR.Name = "lR";
			this.lR.Size = new System.Drawing.Size(57, 21);
			this.lR.TabIndex = 2;
			this.lR.Text = "Radius:";
			// 
			// lAlpha
			// 
			this.lAlpha.AutoSize = true;
			this.lAlpha.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lAlpha.Location = new System.Drawing.Point(3, 29);
			this.lAlpha.Name = "lAlpha";
			this.lAlpha.Size = new System.Drawing.Size(54, 21);
			this.lAlpha.TabIndex = 4;
			this.lAlpha.Text = "Alpha:";
			// 
			// tbAlpha
			// 
			this.tbAlpha.Location = new System.Drawing.Point(69, 30);
			this.tbAlpha.Name = "tbAlpha";
			this.tbAlpha.Size = new System.Drawing.Size(106, 20);
			this.tbAlpha.TabIndex = 3;
			// 
			// lPatrons
			// 
			this.lPatrons.AutoSize = true;
			this.lPatrons.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lPatrons.Location = new System.Drawing.Point(3, 55);
			this.lPatrons.Name = "lPatrons";
			this.lPatrons.Size = new System.Drawing.Size(62, 21);
			this.lPatrons.TabIndex = 6;
			this.lPatrons.Text = "Patrons:";
			// 
			// tbPatrons
			// 
			this.tbPatrons.Location = new System.Drawing.Point(69, 56);
			this.tbPatrons.Name = "tbPatrons";
			this.tbPatrons.Size = new System.Drawing.Size(106, 20);
			this.tbPatrons.TabIndex = 5;
			// 
			// bFire
			// 
			this.bFire.Location = new System.Drawing.Point(12, 46);
			this.bFire.Name = "bFire";
			this.bFire.Size = new System.Drawing.Size(95, 27);
			this.bFire.TabIndex = 7;
			this.bFire.Text = "Fire";
			this.bFire.UseVisualStyleBackColor = true;
			this.bFire.Visible = false;
			this.bFire.Click += new System.EventHandler(this.bFire_Click);
			// 
			// lX
			// 
			this.lX.AutoSize = true;
			this.lX.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lX.Location = new System.Drawing.Point(3, 5);
			this.lX.Name = "lX";
			this.lX.Size = new System.Drawing.Size(25, 21);
			this.lX.TabIndex = 8;
			this.lX.Text = "X:";
			// 
			// lY
			// 
			this.lY.AutoSize = true;
			this.lY.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lY.Location = new System.Drawing.Point(3, 31);
			this.lY.Name = "lY";
			this.lY.Size = new System.Drawing.Size(24, 21);
			this.lY.TabIndex = 9;
			this.lY.Text = "Y:";
			// 
			// tbX
			// 
			this.tbX.Location = new System.Drawing.Point(34, 8);
			this.tbX.Name = "tbX";
			this.tbX.Size = new System.Drawing.Size(100, 20);
			this.tbX.TabIndex = 10;
			// 
			// tbY
			// 
			this.tbY.Location = new System.Drawing.Point(34, 34);
			this.tbY.Name = "tbY";
			this.tbY.Size = new System.Drawing.Size(100, 20);
			this.tbY.TabIndex = 11;
			// 
			// pNewGame
			// 
			this.pNewGame.Controls.Add(this.lR);
			this.pNewGame.Controls.Add(this.tbRadius);
			this.pNewGame.Controls.Add(this.tbAlpha);
			this.pNewGame.Controls.Add(this.lAlpha);
			this.pNewGame.Controls.Add(this.tbPatrons);
			this.pNewGame.Controls.Add(this.lPatrons);
			this.pNewGame.Location = new System.Drawing.Point(124, 16);
			this.pNewGame.Name = "pNewGame";
			this.pNewGame.Size = new System.Drawing.Size(175, 81);
			this.pNewGame.TabIndex = 12;
			// 
			// pFire
			// 
			this.pFire.Controls.Add(this.lHits);
			this.pFire.Controls.Add(this.lPat);
			this.pFire.Controls.Add(this.label2);
			this.pFire.Controls.Add(this.label1);
			this.pFire.Controls.Add(this.tbY);
			this.pFire.Controls.Add(this.lX);
			this.pFire.Controls.Add(this.lY);
			this.pFire.Controls.Add(this.tbX);
			this.pFire.Location = new System.Drawing.Point(153, 120);
			this.pFire.Name = "pFire";
			this.pFire.Size = new System.Drawing.Size(299, 68);
			this.pFire.TabIndex = 13;
			this.pFire.Visible = false;
			// 
			// lHits
			// 
			this.lHits.AutoSize = true;
			this.lHits.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lHits.Location = new System.Drawing.Point(200, 32);
			this.lHits.Name = "lHits";
			this.lHits.Size = new System.Drawing.Size(18, 21);
			this.lHits.TabIndex = 15;
			this.lHits.Text = "0";
			// 
			// lPat
			// 
			this.lPat.AutoSize = true;
			this.lPat.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lPat.Location = new System.Drawing.Point(200, 8);
			this.lPat.Name = "lPat";
			this.lPat.Size = new System.Drawing.Size(18, 21);
			this.lPat.TabIndex = 14;
			this.lPat.Text = "0";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(141, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 21);
			this.label2.TabIndex = 13;
			this.label2.Text = "Hits:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(141, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 21);
			this.label1.TabIndex = 12;
			this.label1.Text = "Patrons:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(510, 357);
			this.Controls.Add(this.pFire);
			this.Controls.Add(this.pNewGame);
			this.Controls.Add(this.bFire);
			this.Controls.Add(this.bNewGame);
			this.Name = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Resize += new System.EventHandler(this.Form1_Resize);
			this.pNewGame.ResumeLayout(false);
			this.pNewGame.PerformLayout();
			this.pFire.ResumeLayout(false);
			this.pFire.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button bNewGame;
		private System.Windows.Forms.TextBox tbRadius;
		private System.Windows.Forms.Label lR;
		private System.Windows.Forms.Label lAlpha;
		private System.Windows.Forms.TextBox tbAlpha;
		private System.Windows.Forms.Label lPatrons;
		private System.Windows.Forms.TextBox tbPatrons;
		private System.Windows.Forms.Button bFire;
		private System.Windows.Forms.Label lX;
		private System.Windows.Forms.Label lY;
		private System.Windows.Forms.TextBox tbX;
		private System.Windows.Forms.TextBox tbY;
		private System.Windows.Forms.Panel pNewGame;
		private System.Windows.Forms.Panel pFire;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lHits;
		private System.Windows.Forms.Label lPat;
	}
}

