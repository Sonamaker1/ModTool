using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//using System.Windows.Controls;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			stageFileDrop.AllowDrop = true;
			groupBox1.AllowDrop = true;

			stgJSONChart.UseVisualStyleBackColor = false;
			stgMP4Video.UseVisualStyleBackColor = false;
			stgOGGInst.UseVisualStyleBackColor = false;
			stgOGGVoices.UseVisualStyleBackColor = false;
			stgPlaceholderChart.UseVisualStyleBackColor = false;
			stgPNGchar.UseVisualStyleBackColor = false;
			stgPNGIcon.UseVisualStyleBackColor = false;
			stgStageImgBG.UseVisualStyleBackColor = false;
			stgSoundEffect.UseVisualStyleBackColor = false;
			stgStageXML.UseVisualStyleBackColor = false;
			stgStageLua.UseVisualStyleBackColor = false;
			stgXMLchar.UseVisualStyleBackColor = false;

			setButtonEnabled(stgJSONChart, false);
			setButtonEnabled(stgMP4Video, false);
			setButtonEnabled(stgOGGInst, false);
			setButtonEnabled(stgOGGVoices, false);
			setButtonEnabled(stgPlaceholderChart, false);
			setButtonEnabled(stgPNGchar, false);
			setButtonEnabled(stgPNGIcon, false);
			setButtonEnabled(stgStageImgBG, false);
			setButtonEnabled(stgSoundEffect, false);
			setButtonEnabled(stgStageXML, false);
			setButtonEnabled(stgStageLua, false);
			setButtonEnabled(stgXMLchar, false);

			//stgJSONChart.BackColor = Color.Black;

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void textBox1_DragDrop(object sender, DragEventArgs e)
		{
			Array filenames;
			string fn;

			filenames = (Array)e.Data.GetData(DataFormats.FileDrop);
			fn = filenames.GetValue(0).ToString();
			stageFileDrop.Text = fn;
			loadFileInfoStage();
		}

		private void textBox1_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
				e.Effect = DragDropEffects.Copy;
			} else {
				e.Effect = DragDropEffects.None;
			}
		}

		private void loadFileInfoStage()
		{
			string fn;
			//System.Diagnostics.Process p;
			fn = stageFileDrop.Text;

			if (System.IO.File.Exists(fn))
			{
				extStageLabel.Text = System.IO.Path.GetExtension(fn);
				setFileExt(extStageLabel.Text);
				locateStageFileLabel.Text = System.IO.Path.GetDirectoryName(fn);
				stageRenameTB.Text = System.IO.Path.GetFileNameWithoutExtension(fn);
				headerText.Text = System.IO.Path.GetFileNameWithoutExtension(fn);
				// p = new System.Diagnostics.Process();
				// p.StartInfo.FileName = fn;
				// p.StartInfo.UseShellExecute = true;
				// p.Start();
			}
			else
			{
				MessageBox.Show(fn + " doesn't Exist!");
			}
		}

		private void setButtonEnabled(Button sender, Boolean enabled) 
		{
			Button btn = sender as Button;
			btn.Enabled = enabled;

			if (enabled){
				btn.BackColor = Color.Chartreuse;
				Bitmap bmp = new Bitmap(btn.Width, btn.Height);
				using (Graphics g = Graphics.FromImage(bmp))
				{
					Rectangle r = new Rectangle(0, 0, bmp.Width, bmp.Height);
					using (LinearGradientBrush br = new LinearGradientBrush(
														r,
														Color.Green,
														Color.DarkGreen,
														LinearGradientMode.Vertical))
					{
						g.FillRectangle(br, r);
					}
				}
				btn.BackgroundImage = bmp;
				//btn.FlatStyle = FlatStyle.Standard;
				btn.FlatStyle = FlatStyle.Flat;
				btn.FlatAppearance.BorderColor = Color.Chartreuse;
				btn.FlatAppearance.BorderSize = 1;
				btn.ForeColor = SystemColors.ControlLight;
			}
			else {
				btn.BackgroundImage = null;
				btn.BackColor = Color.Transparent;
				btn.FlatStyle = FlatStyle.Flat;
				btn.FlatAppearance.BorderColor = Color.Empty;
				btn.FlatAppearance.BorderSize = 0;
				btn.ForeColor = SystemColors.ControlText;
			}
		}

		private void setFileExt(String sender)
		{
			// TextBox textB = sender as TextBox;

			assetTypeLabel.Text = "[None Selected]"; 
			stgJSONChart.UseVisualStyleBackColor = false;
			stgMP4Video.UseVisualStyleBackColor = false;
			stgOGGInst.UseVisualStyleBackColor = false;
			stgOGGVoices.UseVisualStyleBackColor = false;
			stgPlaceholderChart.UseVisualStyleBackColor = false;
			stgPNGchar.UseVisualStyleBackColor = false;
			stgPNGIcon.UseVisualStyleBackColor = false;
			stgStageImgBG.UseVisualStyleBackColor = false;
			stgSoundEffect.UseVisualStyleBackColor = false;
			stgStageXML.UseVisualStyleBackColor = false;
			stgStageLua.UseVisualStyleBackColor = false;
			stgXMLchar.UseVisualStyleBackColor = false;

			setButtonEnabled(stgJSONChart, false);
			setButtonEnabled(stgMP4Video, false);
			setButtonEnabled(stgOGGInst, false);
			setButtonEnabled(stgOGGVoices, false);
			setButtonEnabled(stgPlaceholderChart, false);
			setButtonEnabled(stgPNGchar, false);
			setButtonEnabled(stgPNGIcon, false);
			setButtonEnabled(stgStageImgBG, false);
			setButtonEnabled(stgSoundEffect, false);
			setButtonEnabled(stgStageXML, false);
			setButtonEnabled(stgStageLua, false);
			setButtonEnabled(stgXMLchar, false);

			switch (sender.ToLower())
			{
				case ".xml":
					setButtonEnabled(stgXMLchar, true);
					setButtonEnabled(stgStageXML, true);
					break;

				case ".png":
					setButtonEnabled(stgPNGchar, true);
					setButtonEnabled(stgPNGIcon, true);
					setButtonEnabled(stgStageImgBG, true);
					break;

				case ".ogg": // statement sequence
					setButtonEnabled(stgOGGInst, true);
					setButtonEnabled(stgOGGVoices, true);
					setButtonEnabled(stgSoundEffect, true);
					break;

				case ".mp4": // statement sequence
					setButtonEnabled(stgMP4Video, true);
					break;

				case ".json": // statement sequence
					setButtonEnabled(stgJSONChart, true);
					break;

				default:    // default statement sequence
					break;
			}
		}
		private void loadFileInfoCharacter()
		{
			string fn;
			//System.Diagnostics.Process p;
			fn = stageFileDrop.Text;

			if (System.IO.File.Exists(fn))
			{
				extStageLabel.Text = System.IO.Path.GetExtension(fn);
				locateStageFileLabel.Text = System.IO.Path.GetDirectoryName(fn);
				stageRenameTB.Text = System.IO.Path.GetFileNameWithoutExtension(fn);
				// p = new System.Diagnostics.Process();
				// p.StartInfo.FileName = fn;
				// p.StartInfo.UseShellExecute = true;
				// p.Start();
			}
			else
			{
				MessageBox.Show(fn + " doesn't Exist!");
			}
		}

		private void groupBox4_DragDrop(object sender, DragEventArgs e)
		{
			Array filenames;
			string fn;

			filenames = (Array)e.Data.GetData(DataFormats.FileDrop);
			fn = filenames.GetValue(0).ToString();
			stageFileDrop.Text = fn;
			loadFileInfoCharacter();
		}

		private void groupBox4_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Copy;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void Filter_TextChanged(object sender, EventArgs e)
		{
			var textboxSender = (TextBox)sender;
			var cursorPosition = textboxSender.SelectionStart;
			textboxSender.Text = Regex.Replace(textboxSender.Text, "[^0-9a-zA-Z _-]", "");
			textboxSender.SelectionStart = cursorPosition;
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void groupBox3_Enter(object sender, EventArgs e)
		{

		}

		private void button11_Click(object sender, EventArgs e)
		{

		}

		private void label13_Click(object sender, EventArgs e)
		{

		}

		private void textBox7_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click_1(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{

		}

		private void clearSongNameBtn_Click(object sender, EventArgs e)
		{
			songNameTB.Text = "";
		}

		private void clearStageNameBtn_Click(object sender, EventArgs e)
		{
			stageNameTB.Text = "";
		}

		private void clearStageRenameBtn_Click(object sender, EventArgs e)
		{
			stageRenameTB.Text = "";
		}

		private void clearCharacterNameBtn_Click(object sender, EventArgs e)
		{
			characterNameTB.Text = "";
		}
		private void label2_Click_1(object sender, EventArgs e)
		{

		}

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
		private void clearFileNew()
		{
			setFileExt("none");
			extStageLabel.Text = "";
			locateStageFileLabel.Text = "";
			assetTypeLabel.Text = "[None Selected]";
		}

		private void clearFile(object sender, EventArgs e)
        {
			clearFileNew();
		}

        private void setButtonClicked(object sender, EventArgs e)
        {
			Button btn = sender as Button;
			setFileExt(extStageLabel.Text);
			assetTypeLabel.Text = btn.Text;
			if (btn.Enabled)
			{
				btn.BackColor = Color.YellowGreen;
				Bitmap bmp = new Bitmap(btn.Width, btn.Height);
				using (Graphics g = Graphics.FromImage(bmp))
				{
					Rectangle r = new Rectangle(0, 0, bmp.Width, bmp.Height);
					using (LinearGradientBrush br = new LinearGradientBrush(
														r,
														Color.DarkGreen,
														Color.YellowGreen,
														LinearGradientMode.Vertical))
					{
						g.FillRectangle(br, r);
					}
				}
				btn.BackgroundImage = bmp;
				//btn.FlatStyle = FlatStyle.Standard;
				btn.FlatStyle = FlatStyle.Flat;
				btn.FlatAppearance.BorderColor = Color.Yellow;
				btn.FlatAppearance.BorderSize = 3;
				btn.ForeColor = SystemColors.ControlLight;
			}

			if (assetTypeLabel.Text == "Song Inst") {
				stageRenameTB.Text = "Inst";
			}
			if (assetTypeLabel.Text == "Song Vocals")
			{
				stageRenameTB.Text = "Voices";
			}
			if (assetTypeLabel.Text == "Sound Effect")
			{
				stageRenameTB.Text = headerText.Text;
			}
		}
		private void styleFileBtn(CustomBtn sender, Boolean highlight = false)
		{
			CustomBtn btn = sender as CustomBtn;
			if (btn.Enabled)
			{
				btn.BackColor = Color.YellowGreen;
				Bitmap bmp = new Bitmap(btn.Width, btn.Height);
				using (Graphics g = Graphics.FromImage(bmp))
				{
					Rectangle r = new Rectangle(0, 0, bmp.Width, bmp.Height);
					using (LinearGradientBrush br = new LinearGradientBrush(
														r,
														Color.DarkGreen,
														Color.YellowGreen,
														LinearGradientMode.Vertical))
					{
						g.FillRectangle(br, r);
					}
				}
				btn.BackgroundImage = bmp;
				//btn.FlatStyle = FlatStyle.Standard;
				btn.FlatStyle = FlatStyle.Flat;
				if (highlight)
				{
					btn.FlatAppearance.BorderColor = Color.Yellow;
					btn.FlatAppearance.BorderSize = 3;
				}
				else {
					//btn.BackgroundImage = null;
					//btn.BackColor = Color.Transparent;
					//btn.FlatStyle = FlatStyle.Flat;
					btn.FlatAppearance.BorderColor = Color.Empty;
					btn.FlatAppearance.BorderSize = 0;
					//btn.ForeColor = SystemColors.ControlText;
				}
				btn.ForeColor = SystemColors.ControlLight;
			}
		}

		private void makeFileClicked(object sender, EventArgs e)
		{
			CustomBtn btn = sender as CustomBtn;
			extStageLabel.Text = "";
			locateStageFileLabel.Text = "";
			setFileExt(Path.GetExtension(btn.fileName));
			assetTypeLabel.Text = btn.fileAssetType;

			styleFileBtn(btn, true);

			headerText.Text = Path.GetFileNameWithoutExtension(btn.fileName);
			headerText.Text = Path.GetFileNameWithoutExtension(btn.fileName);
		}

		private void assetTypeLabel_TextChanged(object sender, EventArgs e)
        {
			Label lbl = sender as Label;
			switch (lbl.Text) {
				default:
					setButtonEnabled(btnAssetAdd, true);
					break;
				case "[None Selected]":
				case "":
					setButtonEnabled(btnAssetAdd, false);
					break;
			}

		}
		private void AddButton(string path)
		{
			CustomBtn btn;
			Icon iconForFile;

			btn = new CustomBtn();
			btn.Size = new System.Drawing.Size(80, 80);
			btn.UseVisualStyleBackColor = true; 
			btn.Text = Path.GetFileName(path);
			btn.fileAssetType = assetTypeLabel.Text;
			btn.fileName = path;

			// set alignment
			btn.TextAlign = ContentAlignment.BottomCenter;
			btn.ImageAlign = ContentAlignment.TopCenter;

			// add icon image 7
			
			iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(path);
			btn.Image = iconForFile.ToBitmap();
			if (System.IO.Path.GetExtension(path).ToLower() == ".png")
            {
				using (var stream = File.OpenRead(path))
				using (var image = Image.FromStream(stream))
				{
					btn.Image = PngIconConverter.Resize(stream, 80, true);
				}
			}
			styleFileBtn(btn, false);
			btn.Click += new EventHandler(makeFileClicked);
			flowLayoutPanel1.Controls.Add(btn);
		}

		private void btnAssetAdd_Click(object sender, EventArgs e)
        {
			AddButton(stageFileDrop.Text);
			clearFileNew();
		}



		private void copySongNameBtn_Click(object sender, EventArgs e)
		{
			String txt = headerText.Text;
			if (txt != "DRAG FILES HERE") {
				songNameTB.Text = txt;
			}
		}

		private void copyStageNameBtn_Click(object sender, EventArgs e)
		{
			String txt = headerText.Text;
			if (txt != "DRAG FILES HERE")
			{
				stageNameTB.Text = headerText.Text;
			}
		}

		private void copyStageRenameBtn_Click(object sender, EventArgs e)
		{
			String txt = headerText.Text;
			if (txt != "DRAG FILES HERE")
			{
				stageRenameTB.Text = headerText.Text;
			}
		}

		private void copyCharacterNameBtn_Click(object sender, EventArgs e)
		{
			String txt = headerText.Text;
			if (txt != "DRAG FILES HERE")
			{
				characterNameTB.Text = headerText.Text;
			}
		}

        private void updateAssetBtn_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
