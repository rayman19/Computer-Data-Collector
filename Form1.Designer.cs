namespace ComputerInfo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.groupBoxName = new System.Windows.Forms.GroupBox();
			this.labelName = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.labelProc = new System.Windows.Forms.Label();
			this.groupBoxProc = new System.Windows.Forms.GroupBox();
			this.labelVideoName = new System.Windows.Forms.Label();
			this.groupBoxVideo = new System.Windows.Forms.GroupBox();
			this.labelMemory = new System.Windows.Forms.Label();
			this.groupBoxMemory = new System.Windows.Forms.GroupBox();
			this.labelDisk1 = new System.Windows.Forms.Label();
			this.groupBoxDisc = new System.Windows.Forms.GroupBox();
			this.labelDisk3 = new System.Windows.Forms.Label();
			this.labelDisk4 = new System.Windows.Forms.Label();
			this.labelDisk2 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBoxInvent = new System.Windows.Forms.GroupBox();
			this.textBoxInvent = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.textBoxStamp = new System.Windows.Forms.TextBox();
			this.groupBoxStamp = new System.Windows.Forms.GroupBox();
			this.textBoxSticker = new System.Windows.Forms.TextBox();
			this.groupBoxSticker = new System.Windows.Forms.GroupBox();
			this.textBoxRoom = new System.Windows.Forms.TextBox();
			this.groupBoxRoom = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.labelOperatingSystem = new System.Windows.Forms.Label();
			this.groupBoxOperatingSystem = new System.Windows.Forms.GroupBox();
			this.labelStatus = new System.Windows.Forms.Label();
			this.labelAnswerServer = new System.Windows.Forms.Label();
			this.groupBoxName.SuspendLayout();
			this.groupBoxProc.SuspendLayout();
			this.groupBoxVideo.SuspendLayout();
			this.groupBoxMemory.SuspendLayout();
			this.groupBoxDisc.SuspendLayout();
			this.groupBoxInvent.SuspendLayout();
			this.groupBoxStamp.SuspendLayout();
			this.groupBoxSticker.SuspendLayout();
			this.groupBoxRoom.SuspendLayout();
			this.groupBoxOperatingSystem.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(230, 106);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(362, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Сбор информации о системе";
			// 
			// groupBoxName
			// 
			this.groupBoxName.Controls.Add(this.labelName);
			this.groupBoxName.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.groupBoxName.Location = new System.Drawing.Point(59, 177);
			this.groupBoxName.Name = "groupBoxName";
			this.groupBoxName.Size = new System.Drawing.Size(363, 82);
			this.groupBoxName.TabIndex = 1;
			this.groupBoxName.TabStop = false;
			this.groupBoxName.Text = "Имя компьютера";
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelName.Location = new System.Drawing.Point(24, 37);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(16, 20);
			this.labelName.TabIndex = 2;
			this.labelName.Text = "?";
			this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.SlateGray;
			this.button1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.button1.Location = new System.Drawing.Point(946, 561);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(285, 48);
			this.button1.TabIndex = 3;
			this.button1.Text = "Отправить данные";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.buttonSend_Click);
			// 
			// labelProc
			// 
			this.labelProc.AutoSize = true;
			this.labelProc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelProc.Location = new System.Drawing.Point(24, 37);
			this.labelProc.Name = "labelProc";
			this.labelProc.Size = new System.Drawing.Size(16, 20);
			this.labelProc.TabIndex = 2;
			this.labelProc.Text = "?";
			// 
			// groupBoxProc
			// 
			this.groupBoxProc.Controls.Add(this.labelProc);
			this.groupBoxProc.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.groupBoxProc.Location = new System.Drawing.Point(60, 268);
			this.groupBoxProc.Name = "groupBoxProc";
			this.groupBoxProc.Size = new System.Drawing.Size(363, 82);
			this.groupBoxProc.TabIndex = 1;
			this.groupBoxProc.TabStop = false;
			this.groupBoxProc.Text = "Процессор";
			// 
			// labelVideoName
			// 
			this.labelVideoName.AutoSize = true;
			this.labelVideoName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelVideoName.Location = new System.Drawing.Point(24, 37);
			this.labelVideoName.Name = "labelVideoName";
			this.labelVideoName.Size = new System.Drawing.Size(16, 20);
			this.labelVideoName.TabIndex = 2;
			this.labelVideoName.Text = "?";
			// 
			// groupBoxVideo
			// 
			this.groupBoxVideo.Controls.Add(this.labelVideoName);
			this.groupBoxVideo.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.groupBoxVideo.Location = new System.Drawing.Point(434, 268);
			this.groupBoxVideo.Name = "groupBoxVideo";
			this.groupBoxVideo.Size = new System.Drawing.Size(363, 82);
			this.groupBoxVideo.TabIndex = 1;
			this.groupBoxVideo.TabStop = false;
			this.groupBoxVideo.Text = "Видеокарта";
			// 
			// labelMemory
			// 
			this.labelMemory.AutoSize = true;
			this.labelMemory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelMemory.Location = new System.Drawing.Point(24, 37);
			this.labelMemory.Name = "labelMemory";
			this.labelMemory.Size = new System.Drawing.Size(16, 20);
			this.labelMemory.TabIndex = 2;
			this.labelMemory.Text = "?";
			// 
			// groupBoxMemory
			// 
			this.groupBoxMemory.Controls.Add(this.labelMemory);
			this.groupBoxMemory.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.groupBoxMemory.Location = new System.Drawing.Point(60, 358);
			this.groupBoxMemory.Name = "groupBoxMemory";
			this.groupBoxMemory.Size = new System.Drawing.Size(363, 82);
			this.groupBoxMemory.TabIndex = 1;
			this.groupBoxMemory.TabStop = false;
			this.groupBoxMemory.Text = "Оперативная память";
			// 
			// labelDisk1
			// 
			this.labelDisk1.AutoSize = true;
			this.labelDisk1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelDisk1.Location = new System.Drawing.Point(23, 34);
			this.labelDisk1.Name = "labelDisk1";
			this.labelDisk1.Size = new System.Drawing.Size(31, 20);
			this.labelDisk1.TabIndex = 2;
			this.labelDisk1.Text = "1. ?";
			this.labelDisk1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBoxDisc
			// 
			this.groupBoxDisc.Controls.Add(this.labelDisk3);
			this.groupBoxDisc.Controls.Add(this.labelDisk4);
			this.groupBoxDisc.Controls.Add(this.labelDisk2);
			this.groupBoxDisc.Controls.Add(this.labelDisk1);
			this.groupBoxDisc.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.groupBoxDisc.Location = new System.Drawing.Point(434, 358);
			this.groupBoxDisc.Name = "groupBoxDisc";
			this.groupBoxDisc.Size = new System.Drawing.Size(363, 170);
			this.groupBoxDisc.TabIndex = 1;
			this.groupBoxDisc.TabStop = false;
			this.groupBoxDisc.Text = "Жесткий диск";
			// 
			// labelDisk3
			// 
			this.labelDisk3.AutoSize = true;
			this.labelDisk3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelDisk3.Location = new System.Drawing.Point(23, 101);
			this.labelDisk3.Name = "labelDisk3";
			this.labelDisk3.Size = new System.Drawing.Size(31, 20);
			this.labelDisk3.TabIndex = 2;
			this.labelDisk3.Text = "3. ?";
			this.labelDisk3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelDisk4
			// 
			this.labelDisk4.AutoSize = true;
			this.labelDisk4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelDisk4.Location = new System.Drawing.Point(23, 134);
			this.labelDisk4.Name = "labelDisk4";
			this.labelDisk4.Size = new System.Drawing.Size(31, 20);
			this.labelDisk4.TabIndex = 2;
			this.labelDisk4.Text = "4. ?";
			this.labelDisk4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelDisk2
			// 
			this.labelDisk2.AutoSize = true;
			this.labelDisk2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelDisk2.Location = new System.Drawing.Point(23, 67);
			this.labelDisk2.Name = "labelDisk2";
			this.labelDisk2.Size = new System.Drawing.Size(31, 20);
			this.labelDisk2.TabIndex = 2;
			this.labelDisk2.Text = "2. ?";
			this.labelDisk2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label7.Location = new System.Drawing.Point(24, 37);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(16, 20);
			this.label7.TabIndex = 2;
			this.label7.Text = "?";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label8.Location = new System.Drawing.Point(24, 37);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(16, 20);
			this.label8.TabIndex = 2;
			this.label8.Text = "?";
			// 
			// groupBoxInvent
			// 
			this.groupBoxInvent.Controls.Add(this.textBoxInvent);
			this.groupBoxInvent.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.groupBoxInvent.Location = new System.Drawing.Point(850, 177);
			this.groupBoxInvent.Name = "groupBoxInvent";
			this.groupBoxInvent.Size = new System.Drawing.Size(381, 82);
			this.groupBoxInvent.TabIndex = 1;
			this.groupBoxInvent.TabStop = false;
			this.groupBoxInvent.Text = "Инвентарный номер";
			// 
			// textBoxInvent
			// 
			this.textBoxInvent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBoxInvent.Location = new System.Drawing.Point(25, 34);
			this.textBoxInvent.Name = "textBoxInvent";
			this.textBoxInvent.Size = new System.Drawing.Size(336, 30);
			this.textBoxInvent.TabIndex = 0;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label11.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label11.Location = new System.Drawing.Point(987, 106);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(105, 32);
			this.label11.TabIndex = 0;
			this.label11.Text = "Мануал";
			// 
			// textBoxStamp
			// 
			this.textBoxStamp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBoxStamp.Location = new System.Drawing.Point(25, 34);
			this.textBoxStamp.Name = "textBoxStamp";
			this.textBoxStamp.Size = new System.Drawing.Size(336, 30);
			this.textBoxStamp.TabIndex = 0;
			// 
			// groupBoxStamp
			// 
			this.groupBoxStamp.Controls.Add(this.textBoxStamp);
			this.groupBoxStamp.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.groupBoxStamp.Location = new System.Drawing.Point(850, 268);
			this.groupBoxStamp.Name = "groupBoxStamp";
			this.groupBoxStamp.Size = new System.Drawing.Size(381, 82);
			this.groupBoxStamp.TabIndex = 1;
			this.groupBoxStamp.TabStop = false;
			this.groupBoxStamp.Text = "Наклейка НЛМК";
			// 
			// textBoxSticker
			// 
			this.textBoxSticker.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBoxSticker.Location = new System.Drawing.Point(25, 34);
			this.textBoxSticker.Name = "textBoxSticker";
			this.textBoxSticker.Size = new System.Drawing.Size(336, 30);
			this.textBoxSticker.TabIndex = 0;
			// 
			// groupBoxSticker
			// 
			this.groupBoxSticker.Controls.Add(this.textBoxSticker);
			this.groupBoxSticker.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.groupBoxSticker.Location = new System.Drawing.Point(850, 357);
			this.groupBoxSticker.Name = "groupBoxSticker";
			this.groupBoxSticker.Size = new System.Drawing.Size(381, 82);
			this.groupBoxSticker.TabIndex = 1;
			this.groupBoxSticker.TabStop = false;
			this.groupBoxSticker.Text = "Пломба";
			// 
			// textBoxRoom
			// 
			this.textBoxRoom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBoxRoom.Location = new System.Drawing.Point(25, 34);
			this.textBoxRoom.Name = "textBoxRoom";
			this.textBoxRoom.Size = new System.Drawing.Size(336, 30);
			this.textBoxRoom.TabIndex = 0;
			// 
			// groupBoxRoom
			// 
			this.groupBoxRoom.Controls.Add(this.textBoxRoom);
			this.groupBoxRoom.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.groupBoxRoom.Location = new System.Drawing.Point(850, 446);
			this.groupBoxRoom.Name = "groupBoxRoom";
			this.groupBoxRoom.Size = new System.Drawing.Size(381, 82);
			this.groupBoxRoom.TabIndex = 1;
			this.groupBoxRoom.TabStop = false;
			this.groupBoxRoom.Text = "Кабинет";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.SlateGray;
			this.button2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.button2.Location = new System.Drawing.Point(59, 561);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(199, 48);
			this.button2.TabIndex = 4;
			this.button2.Text = "О программе";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// labelOperatingSystem
			// 
			this.labelOperatingSystem.AutoSize = true;
			this.labelOperatingSystem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelOperatingSystem.Location = new System.Drawing.Point(24, 37);
			this.labelOperatingSystem.Name = "labelOperatingSystem";
			this.labelOperatingSystem.Size = new System.Drawing.Size(16, 20);
			this.labelOperatingSystem.TabIndex = 2;
			this.labelOperatingSystem.Text = "?";
			this.labelOperatingSystem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBoxOperatingSystem
			// 
			this.groupBoxOperatingSystem.Controls.Add(this.labelOperatingSystem);
			this.groupBoxOperatingSystem.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.groupBoxOperatingSystem.Location = new System.Drawing.Point(433, 177);
			this.groupBoxOperatingSystem.Name = "groupBoxOperatingSystem";
			this.groupBoxOperatingSystem.Size = new System.Drawing.Size(363, 82);
			this.groupBoxOperatingSystem.TabIndex = 1;
			this.groupBoxOperatingSystem.TabStop = false;
			this.groupBoxOperatingSystem.Text = "Операционная система";
			// 
			// labelStatus
			// 
			this.labelStatus.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.labelStatus.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.labelStatus.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.labelStatus.Location = new System.Drawing.Point(397, 561);
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new System.Drawing.Size(400, 48);
			this.labelStatus.TabIndex = 5;
			this.labelStatus.Text = "Статус: Ожидание отправки";
			this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelAnswerServer
			// 
			this.labelAnswerServer.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.labelAnswerServer.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.labelAnswerServer.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.labelAnswerServer.Location = new System.Drawing.Point(300, 609);
			this.labelAnswerServer.Name = "labelAnswerServer";
			this.labelAnswerServer.Size = new System.Drawing.Size(496, 48);
			this.labelAnswerServer.TabIndex = 5;
			this.labelAnswerServer.Text = "Ответ сервера:";
			this.labelAnswerServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1305, 674);
			this.Controls.Add(this.labelAnswerServer);
			this.Controls.Add(this.labelStatus);
			this.Controls.Add(this.groupBoxOperatingSystem);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.groupBoxRoom);
			this.Controls.Add(this.groupBoxSticker);
			this.Controls.Add(this.groupBoxStamp);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.groupBoxInvent);
			this.Controls.Add(this.groupBoxDisc);
			this.Controls.Add(this.groupBoxMemory);
			this.Controls.Add(this.groupBoxVideo);
			this.Controls.Add(this.groupBoxProc);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBoxName);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "НЛМК Инжиниринг | Сборщик данных";
			this.groupBoxName.ResumeLayout(false);
			this.groupBoxName.PerformLayout();
			this.groupBoxProc.ResumeLayout(false);
			this.groupBoxProc.PerformLayout();
			this.groupBoxVideo.ResumeLayout(false);
			this.groupBoxVideo.PerformLayout();
			this.groupBoxMemory.ResumeLayout(false);
			this.groupBoxMemory.PerformLayout();
			this.groupBoxDisc.ResumeLayout(false);
			this.groupBoxDisc.PerformLayout();
			this.groupBoxInvent.ResumeLayout(false);
			this.groupBoxInvent.PerformLayout();
			this.groupBoxStamp.ResumeLayout(false);
			this.groupBoxStamp.PerformLayout();
			this.groupBoxSticker.ResumeLayout(false);
			this.groupBoxSticker.PerformLayout();
			this.groupBoxRoom.ResumeLayout(false);
			this.groupBoxRoom.PerformLayout();
			this.groupBoxOperatingSystem.ResumeLayout(false);
			this.groupBoxOperatingSystem.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBoxName;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label labelProc;
		private System.Windows.Forms.GroupBox groupBoxProc;
		private System.Windows.Forms.Label labelVideoName;
		private System.Windows.Forms.GroupBox groupBoxVideo;
		private System.Windows.Forms.Label labelMemory;
		private System.Windows.Forms.GroupBox groupBoxMemory;
		private System.Windows.Forms.Label labelDisk1;
		private System.Windows.Forms.GroupBox groupBoxDisc;
		private System.Windows.Forms.Label labelDisk2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox groupBoxInvent;
		private System.Windows.Forms.TextBox textBoxInvent;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBoxStamp;
		private System.Windows.Forms.GroupBox groupBoxStamp;
		private System.Windows.Forms.TextBox textBoxSticker;
		private System.Windows.Forms.GroupBox groupBoxSticker;
		private System.Windows.Forms.TextBox textBoxRoom;
		private System.Windows.Forms.GroupBox groupBoxRoom;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label labelOperatingSystem;
		private System.Windows.Forms.GroupBox groupBoxOperatingSystem;
		private System.Windows.Forms.Label labelDisk3;
		private System.Windows.Forms.Label labelDisk4;
		private System.Windows.Forms.Label labelStatus;
		private System.Windows.Forms.Label labelAnswerServer;
	}
}

