using System.Windows.Forms;
using System.Management;
using System.Collections.Generic;
using System;
using System.IO;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Net;
using MaterialSkin.Controls;
using System.Drawing;
using System.Text;

namespace ComputerInfo
{
	public partial class Form1 : MaterialForm
	{
        private static List<string> GetHardwareInfo(string WIN32_Class, string ClassItemField)
        {
            List<string> result = new List<string>();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM " + WIN32_Class);

            try
            {
                foreach (ManagementObject obj in searcher.Get())
                    result.Add(obj[ClassItemField].ToString().Trim());
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Данные не удалось извлечь. Ошибка " + ex);
            }

            return result;
        }
        private static string OutputResult(List<string> result, int num, bool isByte, bool isRam)
        {
            if (num >= result.Count)
                return "";

            else if (isByte)
            {
                double temp = 0;

                if (isRam)
				{
                    for (int i = 0; i < result.Count; ++i)
                        temp += Math.Round(double.Parse(result[num]) / 1024 / 1024 / 1024);
                }
                else
				{
                    temp = Math.Round(double.Parse(result[num]) / 1024 / 1024 / 1024);
                }

                return Convert.ToString(temp) + " GB";
            }

            else
                return result[num];
        }
        public Form1()
		{
            MaterialForm loader = new MaterialForm();
            MaterialLabel label = new MaterialLabel();
            loader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            label.Text = "Идет сбор данных.\nПожалуйста подождите...";
            label.AutoSize = false;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Dock = DockStyle.Fill;
            label.Width = 250;
            label.Height = 50;
            loader.Controls.Add(label);
            loader.StartPosition = FormStartPosition.CenterScreen;
            loader.Text = "Загрузка";
            loader.Height = 150;
            loader.Width = 350;
            loader.Show();

            InitializeComponent();
            labelStatus.ForeColor = Color.Blue;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            labelName.Text = Environment.MachineName;
            labelProc.Text = OutputResult(GetHardwareInfo("Win32_Processor", "Name"), 0, false, false);
            labelVideoName.Text = OutputResult(GetHardwareInfo("Win32_VideoController", "Name"), 0, false, false) + " " + OutputResult(GetHardwareInfo("Win32_VideoController", "AdapterRAM"), 0, true, false);
            labelMemory.Text = OutputResult(GetHardwareInfo("Win32_PhysicalMemory", "Capacity"), 0, true, true);
            labelDisk1.Text = OutputResult(GetHardwareInfo("Win32_DiskDrive", "Caption"), 0, false, false) + " " + OutputResult(GetHardwareInfo("Win32_DiskDrive", "Size"), 0, true, false);
            labelDisk2.Text = OutputResult(GetHardwareInfo("Win32_DiskDrive", "Caption"), 1, false, false) + " " + OutputResult(GetHardwareInfo("Win32_DiskDrive", "Size"), 1, true, false);
            labelDisk3.Text = OutputResult(GetHardwareInfo("Win32_DiskDrive", "Caption"), 2, false, false) + " " + OutputResult(GetHardwareInfo("Win32_DiskDrive", "Size"), 2, true, false);
            labelDisk4.Text = OutputResult(GetHardwareInfo("Win32_DiskDrive", "Caption"), 3, false, false) + " " + OutputResult(GetHardwareInfo("Win32_DiskDrive", "Size"), 3, true, false);
            labelOperatingSystem.Text = OutputResult(GetHardwareInfo("Win32_OperatingSystem", "Caption"), 0, false, false) + " " + OutputResult(GetHardwareInfo("Win32_OperatingSystem", "Version"), 0, false, false);
            
            loader.Close();
        }

        private void buttonSend_Click(object sender, EventArgs e)
		{
            labelStatus.ForeColor = Color.DarkOrange;
            labelStatus.Text = "Статус: Отправка данных";
            var computer = new Computer()
            {
                Name = labelName.Text,
                OS = OutputResult(GetHardwareInfo("Win32_OperatingSystem", "Caption"), 0, false, false),
                OSVersion = OutputResult(GetHardwareInfo("Win32_OperatingSystem", "Version"), 0, false, false),
                Proc = labelProc.Text,
                Video = labelVideoName.Text,
                Ram = labelMemory.Text,
                Hdd1 = !(labelDisk1.Text.Length > 1) ? null : OutputResult(GetHardwareInfo("Win32_DiskDrive", "Caption"), 0, false, false),
                HddSize1 = !(labelDisk1.Text.Length > 1) ? null : OutputResult(GetHardwareInfo("Win32_DiskDrive", "Size"), 0, true, false),
                Hdd2 = !(labelDisk2.Text.Length > 1) ? null : OutputResult(GetHardwareInfo("Win32_DiskDrive", "Caption"), 1, false, false),
                HddSize2 = !(labelDisk2.Text.Length > 1) ? null : OutputResult(GetHardwareInfo("Win32_DiskDrive", "Size"), 1, true, false),
                Hdd3 = !(labelDisk3.Text.Length > 1) ? null : OutputResult(GetHardwareInfo("Win32_DiskDrive", "Caption"), 2, false, false),
                HddSize3 = !(labelDisk3.Text.Length > 1) ? null : OutputResult(GetHardwareInfo("Win32_DiskDrive", "Size"), 2, true, false),
                Hdd4 = !(labelDisk4.Text.Length > 1) ? null : OutputResult(GetHardwareInfo("Win32_DiskDrive", "Caption"), 3, false, false),
                HddSize4 = !(labelDisk4.Text.Length > 1) ? null : OutputResult(GetHardwareInfo("Win32_DiskDrive", "Size"), 3, true, false),
                Invent = textBoxInvent.Text,
                Sticker = textBoxStamp.Text,
                Stamp = textBoxSticker.Text,
                Room = textBoxRoom.Text,
            };

            var options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true,
                IgnoreNullValues = true
            };

            string jsonString = JsonSerializer.Serialize(computer, options);
			File.WriteAllText("./computer.json", jsonString);



            WebRequest request = WebRequest.Create("http://1c.ni.nlmk.com/engineering/hs/post/PCInformation/");
            request.Method = "POST";
            request.ContentType = "application/json";
            
            var username = "post_pc_info";
            var password = "1234567yY!";

            string encoded = System.Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1")
                                           .GetBytes(username + ":" + password));
            request.Headers.Add("Authorization", "Basic " + encoded);

            using (var dataStream = new StreamWriter(request.GetRequestStream()))
            {
                dataStream.Write(jsonString);
            }

            try
            {
                var httpResponse = (HttpWebResponse)request.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    labelAnswerServer.Text = "Ответ сервера: " + result;
                }

                labelStatus.ForeColor = Color.Green;
                labelStatus.Text = "Статус: Данные успешно отправлены";
            }
            catch (Exception exception)
            {
                labelStatus.ForeColor = Color.Red;
                labelStatus.Text = "Статус: Данные не отправлены";
                labelAnswerServer.Text = "Ответ сервера:";
            }

            System.Threading.Thread.Sleep(2000);
        }

		private void button2_Click(object sender, EventArgs e)
		{
            Form2 info = new Form2();
            info.ShowDialog();
        }
	}
}
