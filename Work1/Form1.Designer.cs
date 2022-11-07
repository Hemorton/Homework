
namespace Work1
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.ScissorsBut = new System.Windows.Forms.Button();
			this.StoneBut = new System.Windows.Forms.Button();
			this.PaperBut = new System.Windows.Forms.Button();
			this.Title = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.winTimer = new System.Windows.Forms.Label();
			this.answerImage = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ScissorsBut
			// 
			this.ScissorsBut.Image = ((System.Drawing.Image)(resources.GetObject("ScissorsBut.Image")));
			this.ScissorsBut.Location = new System.Drawing.Point(41, 231);
			this.ScissorsBut.Name = "ScissorsBut";
			this.ScissorsBut.Size = new System.Drawing.Size(111, 99);
			this.ScissorsBut.TabIndex = 0;
			this.ScissorsBut.UseVisualStyleBackColor = true;
			this.ScissorsBut.Click += new System.EventHandler(this.ScissorsBut_Click_1);
			// 
			// StoneBut
			// 
			this.StoneBut.Image = ((System.Drawing.Image)(resources.GetObject("StoneBut.Image")));
			this.StoneBut.Location = new System.Drawing.Point(182, 231);
			this.StoneBut.Name = "StoneBut";
			this.StoneBut.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.StoneBut.Size = new System.Drawing.Size(109, 99);
			this.StoneBut.TabIndex = 1;
			this.StoneBut.UseVisualStyleBackColor = true;
			this.StoneBut.Click += new System.EventHandler(this.StoneBut_Click_1);
			// 
			// PaperBut
			// 
			this.PaperBut.Image = ((System.Drawing.Image)(resources.GetObject("PaperBut.Image")));
			this.PaperBut.Location = new System.Drawing.Point(329, 231);
			this.PaperBut.Name = "PaperBut";
			this.PaperBut.Size = new System.Drawing.Size(95, 99);
			this.PaperBut.TabIndex = 2;
			this.PaperBut.UseVisualStyleBackColor = true;
			this.PaperBut.Click += new System.EventHandler(this.PaperBut_Click_1);
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Title.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.Title.Location = new System.Drawing.Point(100, 12);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(284, 48);
			this.Title.TabIndex = 3;
			this.Title.Text = "剪刀 石頭 布";
			this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Title.Click += new System.EventHandler(this.label1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(169, 128);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 32);
			this.label1.TabIndex = 4;
			// 
			// winTimer
			// 
			this.winTimer.AutoSize = true;
			this.winTimer.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.winTimer.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.winTimer.Location = new System.Drawing.Point(12, 73);
			this.winTimer.Name = "winTimer";
			this.winTimer.Size = new System.Drawing.Size(155, 32);
			this.winTimer.TabIndex = 5;
			this.winTimer.Text = "TheAnswer";
			this.winTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// answerImage
			// 
			this.answerImage.Location = new System.Drawing.Point(189, 90);
			this.answerImage.Name = "answerImage";
			this.answerImage.Size = new System.Drawing.Size(102, 89);
			this.answerImage.TabIndex = 6;
			this.answerImage.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(472, 342);
			this.Controls.Add(this.answerImage);
			this.Controls.Add(this.winTimer);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Title);
			this.Controls.Add(this.PaperBut);
			this.Controls.Add(this.StoneBut);
			this.Controls.Add(this.ScissorsBut);
			this.Name = "Form1";
			this.Text = "剪刀石頭布";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ScissorsBut;
		private System.Windows.Forms.Button StoneBut;
		private System.Windows.Forms.Button PaperBut;
		private System.Windows.Forms.Label Title;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label winTimer;
		private System.Windows.Forms.Button answerImage;
	}
}

