namespace ProcessEvents
{
	partial class Demonstrator
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
			this.lStirlingNumber = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lAnswer = new System.Windows.Forms.Label();
			this.bStart = new System.Windows.Forms.Button();
			this.bStop = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lStirlingNumber
			// 
			this.lStirlingNumber.AutoSize = true;
			this.lStirlingNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lStirlingNumber.Location = new System.Drawing.Point(94, 43);
			this.lStirlingNumber.Name = "lStirlingNumber";
			this.lStirlingNumber.Size = new System.Drawing.Size(53, 25);
			this.lStirlingNumber.TabIndex = 0;
			this.lStirlingNumber.Text = "(0, 0)";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(168, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(25, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "=";
			// 
			// lAnswer
			// 
			this.lAnswer.AutoSize = true;
			this.lAnswer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lAnswer.Location = new System.Drawing.Point(216, 43);
			this.lAnswer.Name = "lAnswer";
			this.lAnswer.Size = new System.Drawing.Size(22, 25);
			this.lAnswer.TabIndex = 3;
			this.lAnswer.Text = "0";
			// 
			// bStart
			// 
			this.bStart.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.bStart.Location = new System.Drawing.Point(68, 118);
			this.bStart.Name = "bStart";
			this.bStart.Size = new System.Drawing.Size(99, 32);
			this.bStart.TabIndex = 4;
			this.bStart.Text = "Start";
			this.bStart.UseVisualStyleBackColor = true;
			this.bStart.Click += new System.EventHandler(this.bStart_Click);
			// 
			// bStop
			// 
			this.bStop.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.bStop.Location = new System.Drawing.Point(193, 118);
			this.bStop.Name = "bStop";
			this.bStop.Size = new System.Drawing.Size(99, 32);
			this.bStop.TabIndex = 5;
			this.bStop.Text = "Stop";
			this.bStop.UseVisualStyleBackColor = true;
			this.bStop.Click += new System.EventHandler(this.bStop_Click);
			// 
			// Demonstrator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(372, 261);
			this.Controls.Add(this.bStop);
			this.Controls.Add(this.bStart);
			this.Controls.Add(this.lAnswer);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lStirlingNumber);
			this.Name = "Demonstrator";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Demonstrator_FormClosed);
			this.Load += new System.EventHandler(this.Demonstrator_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lStirlingNumber;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lAnswer;
		private System.Windows.Forms.Button bStart;
		private System.Windows.Forms.Button bStop;
	}
}

