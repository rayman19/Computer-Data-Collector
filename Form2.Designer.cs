namespace ComputerInfo
{
	partial class Form2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.button = new System.Windows.Forms.Button();
			this.label = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button.BackColor = System.Drawing.Color.SlateGray;
			this.button.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button.Location = new System.Drawing.Point(174, 353);
			this.button.Name = "button1";
			this.button.Size = new System.Drawing.Size(232, 47);
			this.button.TabIndex = 0;
			this.button.Text = "Закрыть справку";
			this.button.UseVisualStyleBackColor = false;
			this.button.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label.Location = new System.Drawing.Point(32, 102);
			this.label.Name = "label2";
			this.label.Size = new System.Drawing.Size(528, 250);
			this.label.TabIndex = 2;
			this.label.Text = "Программа предназначена для сбора информации о конфигурации системы. Пользователю" +
    " необходимо ввести дополнительные данные, после чего нажать на кнопку \'Отправить" +
    " данные\'.\r\n";
			this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(599, 446);
			this.Controls.Add(this.label);
			this.Controls.Add(this.button);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "О программе";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button;
		private System.Windows.Forms.Label label;
	}
}