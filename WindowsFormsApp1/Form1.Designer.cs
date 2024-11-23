
namespace WindowsFormsApp1
{
	partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.copyStageRenameBtn = new System.Windows.Forms.PictureBox();
            this.copyStageNameBtn = new System.Windows.Forms.PictureBox();
            this.copyCharacterNameBtn = new System.Windows.Forms.PictureBox();
            this.copySongNameBtn = new System.Windows.Forms.PictureBox();
            this.btnAssetAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.assetTypeLabel = new System.Windows.Forms.Label();
            this.headerText = new System.Windows.Forms.TextBox();
            this.stgStageLua = new System.Windows.Forms.Button();
            this.stgPlaceholderChart = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.clearCharacterNameBtn = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.characterNameTB = new System.Windows.Forms.TextBox();
            this.stgXMLchar = new System.Windows.Forms.Button();
            this.stgPNGIcon = new System.Windows.Forms.Button();
            this.stgPNGchar = new System.Windows.Forms.Button();
            this.clearStageRenameBtn = new System.Windows.Forms.PictureBox();
            this.clearStageNameBtn = new System.Windows.Forms.PictureBox();
            this.clearSongNameBtn = new System.Windows.Forms.PictureBox();
            this.stgMP4Video = new System.Windows.Forms.Button();
            this.stgStageXML = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.stageNameTB = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button8 = new System.Windows.Forms.Button();
            this.stgSoundEffect = new System.Windows.Forms.Button();
            this.stgStageImgBG = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.stageRenameTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.songNameTB = new System.Windows.Forms.TextBox();
            this.stgJSONChart = new System.Windows.Forms.Button();
            this.stgOGGInst = new System.Windows.Forms.Button();
            this.stgOGGVoices = new System.Windows.Forms.Button();
            this.locateStageFileLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.extStageLabel = new System.Windows.Forms.Label();
            this.stageFileDrop = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.updateAssetBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.copyStageRenameBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyStageNameBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyCharacterNameBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copySongNameBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearCharacterNameBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearStageRenameBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearStageNameBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearSongNameBtn)).BeginInit();
            this.stageFileDrop.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(3, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(418, 542);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Files";
            this.groupBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox1_DragDrop);
            this.groupBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox1_DragEnter);
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.updateAssetBtn);
            this.panel1.Controls.Add(this.copyStageRenameBtn);
            this.panel1.Controls.Add(this.copyStageNameBtn);
            this.panel1.Controls.Add(this.copyCharacterNameBtn);
            this.panel1.Controls.Add(this.copySongNameBtn);
            this.panel1.Controls.Add(this.btnAssetAdd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.assetTypeLabel);
            this.panel1.Controls.Add(this.headerText);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.clearCharacterNameBtn);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.characterNameTB);
            this.panel1.Controls.Add(this.clearStageRenameBtn);
            this.panel1.Controls.Add(this.clearStageNameBtn);
            this.panel1.Controls.Add(this.clearSongNameBtn);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.stageNameTB);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.stageRenameTB);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.songNameTB);
            this.panel1.Controls.Add(this.locateStageFileLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.extStageLabel);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(4, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 520);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // copyStageRenameBtn
            // 
            this.copyStageRenameBtn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.copy;
            this.copyStageRenameBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.copyStageRenameBtn.Location = new System.Drawing.Point(124, 415);
            this.copyStageRenameBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.copyStageRenameBtn.Name = "copyStageRenameBtn";
            this.copyStageRenameBtn.Size = new System.Drawing.Size(15, 14);
            this.copyStageRenameBtn.TabIndex = 59;
            this.copyStageRenameBtn.TabStop = false;
            this.copyStageRenameBtn.Click += new System.EventHandler(this.copyStageRenameBtn_Click);
            // 
            // copyStageNameBtn
            // 
            this.copyStageNameBtn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.copy;
            this.copyStageNameBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.copyStageNameBtn.Location = new System.Drawing.Point(101, 180);
            this.copyStageNameBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.copyStageNameBtn.Name = "copyStageNameBtn";
            this.copyStageNameBtn.Size = new System.Drawing.Size(15, 14);
            this.copyStageNameBtn.TabIndex = 58;
            this.copyStageNameBtn.TabStop = false;
            this.copyStageNameBtn.Click += new System.EventHandler(this.copyStageNameBtn_Click);
            // 
            // copyCharacterNameBtn
            // 
            this.copyCharacterNameBtn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.copy;
            this.copyCharacterNameBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.copyCharacterNameBtn.Location = new System.Drawing.Point(325, 141);
            this.copyCharacterNameBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.copyCharacterNameBtn.Name = "copyCharacterNameBtn";
            this.copyCharacterNameBtn.Size = new System.Drawing.Size(15, 14);
            this.copyCharacterNameBtn.TabIndex = 57;
            this.copyCharacterNameBtn.TabStop = false;
            this.copyCharacterNameBtn.Click += new System.EventHandler(this.copyCharacterNameBtn_Click);
            // 
            // copySongNameBtn
            // 
            this.copySongNameBtn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.copy;
            this.copySongNameBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.copySongNameBtn.Location = new System.Drawing.Point(101, 141);
            this.copySongNameBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.copySongNameBtn.Name = "copySongNameBtn";
            this.copySongNameBtn.Size = new System.Drawing.Size(15, 14);
            this.copySongNameBtn.TabIndex = 56;
            this.copySongNameBtn.TabStop = false;
            this.copySongNameBtn.Click += new System.EventHandler(this.copySongNameBtn_Click);
            // 
            // btnAssetAdd
            // 
            this.btnAssetAdd.Enabled = false;
            this.btnAssetAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssetAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btnAssetAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAssetAdd.Location = new System.Drawing.Point(257, 459);
            this.btnAssetAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAssetAdd.Name = "btnAssetAdd";
            this.btnAssetAdd.Size = new System.Drawing.Size(123, 43);
            this.btnAssetAdd.TabIndex = 55;
            this.btnAssetAdd.Text = "Add Asset";
            this.btnAssetAdd.UseVisualStyleBackColor = true;
            this.btnAssetAdd.Click += new System.EventHandler(this.btnAssetAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(196, 181);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "SELECTED ASSET TYPE";
            // 
            // assetTypeLabel
            // 
            this.assetTypeLabel.AutoSize = true;
            this.assetTypeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.assetTypeLabel.Location = new System.Drawing.Point(208, 200);
            this.assetTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.assetTypeLabel.Name = "assetTypeLabel";
            this.assetTypeLabel.Size = new System.Drawing.Size(80, 13);
            this.assetTypeLabel.TabIndex = 53;
            this.assetTypeLabel.Text = "[none selected]";
            this.assetTypeLabel.TextChanged += new System.EventHandler(this.assetTypeLabel_TextChanged);
            // 
            // headerText
            // 
            this.headerText.BackColor = System.Drawing.SystemColors.WindowText;
            this.headerText.Enabled = false;
            this.headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.headerText.Location = new System.Drawing.Point(13, 14);
            this.headerText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.headerText.Multiline = true;
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(374, 39);
            this.headerText.TabIndex = 52;
            this.headerText.Text = "DRAG FILES HERE";
            this.headerText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stgStageLua
            // 
            this.stgStageLua.Enabled = false;
            this.stgStageLua.Location = new System.Drawing.Point(278, 142);
            this.stgStageLua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stgStageLua.Name = "stgStageLua";
            this.stgStageLua.Size = new System.Drawing.Size(88, 66);
            this.stgStageLua.TabIndex = 51;
            this.stgStageLua.Text = "Make Stage LUA";
            this.stgStageLua.UseVisualStyleBackColor = true;
            this.stgStageLua.Click += new System.EventHandler(this.setButtonClicked);
            // 
            // stgPlaceholderChart
            // 
            this.stgPlaceholderChart.Enabled = false;
            this.stgPlaceholderChart.Location = new System.Drawing.Point(186, 142);
            this.stgPlaceholderChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stgPlaceholderChart.Name = "stgPlaceholderChart";
            this.stgPlaceholderChart.Size = new System.Drawing.Size(88, 66);
            this.stgPlaceholderChart.TabIndex = 50;
            this.stgPlaceholderChart.Text = "Placeholder Chart";
            this.stgPlaceholderChart.UseVisualStyleBackColor = true;
            this.stgPlaceholderChart.Click += new System.EventHandler(this.setButtonClicked);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(10, 100);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "FILE LOCATION:";
            this.label9.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // clearCharacterNameBtn
            // 
            this.clearCharacterNameBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clearCharacterNameBtn.BackgroundImage")));
            this.clearCharacterNameBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clearCharacterNameBtn.Location = new System.Drawing.Point(305, 142);
            this.clearCharacterNameBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearCharacterNameBtn.Name = "clearCharacterNameBtn";
            this.clearCharacterNameBtn.Size = new System.Drawing.Size(15, 13);
            this.clearCharacterNameBtn.TabIndex = 43;
            this.clearCharacterNameBtn.TabStop = false;
            this.clearCharacterNameBtn.Click += new System.EventHandler(this.clearCharacterNameBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(196, 141);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "CHARACTER NAME:";
            // 
            // characterNameTB
            // 
            this.characterNameTB.Location = new System.Drawing.Point(199, 158);
            this.characterNameTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.characterNameTB.Name = "characterNameTB";
            this.characterNameTB.Size = new System.Drawing.Size(188, 20);
            this.characterNameTB.TabIndex = 41;
            this.characterNameTB.TextChanged += new System.EventHandler(this.Filter_TextChanged);
            // 
            // stgXMLchar
            // 
            this.stgXMLchar.Enabled = false;
            this.stgXMLchar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.6F);
            this.stgXMLchar.Location = new System.Drawing.Point(94, 142);
            this.stgXMLchar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stgXMLchar.Name = "stgXMLchar";
            this.stgXMLchar.Size = new System.Drawing.Size(88, 66);
            this.stgXMLchar.TabIndex = 40;
            this.stgXMLchar.Text = "Character XML";
            this.stgXMLchar.UseVisualStyleBackColor = true;
            this.stgXMLchar.Click += new System.EventHandler(this.setButtonClicked);
            // 
            // stgPNGIcon
            // 
            this.stgPNGIcon.Enabled = false;
            this.stgPNGIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.6F);
            this.stgPNGIcon.Location = new System.Drawing.Point(2, 142);
            this.stgPNGIcon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stgPNGIcon.Name = "stgPNGIcon";
            this.stgPNGIcon.Size = new System.Drawing.Size(88, 66);
            this.stgPNGIcon.TabIndex = 39;
            this.stgPNGIcon.Text = "Character Icon";
            this.stgPNGIcon.UseVisualStyleBackColor = true;
            this.stgPNGIcon.Click += new System.EventHandler(this.setButtonClicked);
            // 
            // stgPNGchar
            // 
            this.stgPNGchar.Enabled = false;
            this.stgPNGchar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.6F);
            this.stgPNGchar.Location = new System.Drawing.Point(278, 72);
            this.stgPNGchar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stgPNGchar.Name = "stgPNGchar";
            this.stgPNGchar.Size = new System.Drawing.Size(88, 66);
            this.stgPNGchar.TabIndex = 38;
            this.stgPNGchar.Text = "Character PNG";
            this.stgPNGchar.UseVisualStyleBackColor = true;
            this.stgPNGchar.Click += new System.EventHandler(this.setButtonClicked);
            // 
            // clearStageRenameBtn
            // 
            this.clearStageRenameBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clearStageRenameBtn.BackgroundImage")));
            this.clearStageRenameBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clearStageRenameBtn.Location = new System.Drawing.Point(105, 416);
            this.clearStageRenameBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearStageRenameBtn.Name = "clearStageRenameBtn";
            this.clearStageRenameBtn.Size = new System.Drawing.Size(15, 13);
            this.clearStageRenameBtn.TabIndex = 37;
            this.clearStageRenameBtn.TabStop = false;
            this.clearStageRenameBtn.Click += new System.EventHandler(this.clearStageRenameBtn_Click);
            // 
            // clearStageNameBtn
            // 
            this.clearStageNameBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clearStageNameBtn.BackgroundImage")));
            this.clearStageNameBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clearStageNameBtn.Location = new System.Drawing.Point(82, 181);
            this.clearStageNameBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearStageNameBtn.Name = "clearStageNameBtn";
            this.clearStageNameBtn.Size = new System.Drawing.Size(15, 13);
            this.clearStageNameBtn.TabIndex = 35;
            this.clearStageNameBtn.TabStop = false;
            this.clearStageNameBtn.Click += new System.EventHandler(this.clearStageNameBtn_Click);
            // 
            // clearSongNameBtn
            // 
            this.clearSongNameBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clearSongNameBtn.BackgroundImage")));
            this.clearSongNameBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clearSongNameBtn.Location = new System.Drawing.Point(82, 141);
            this.clearSongNameBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearSongNameBtn.Name = "clearSongNameBtn";
            this.clearSongNameBtn.Size = new System.Drawing.Size(15, 14);
            this.clearSongNameBtn.TabIndex = 34;
            this.clearSongNameBtn.TabStop = false;
            this.clearSongNameBtn.Click += new System.EventHandler(this.clearSongNameBtn_Click);
            // 
            // stgMP4Video
            // 
            this.stgMP4Video.Enabled = false;
            this.stgMP4Video.Location = new System.Drawing.Point(186, 72);
            this.stgMP4Video.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stgMP4Video.Name = "stgMP4Video";
            this.stgMP4Video.Size = new System.Drawing.Size(88, 66);
            this.stgMP4Video.TabIndex = 32;
            this.stgMP4Video.Text = "Video";
            this.stgMP4Video.UseVisualStyleBackColor = true;
            this.stgMP4Video.Click += new System.EventHandler(this.setButtonClicked);
            // 
            // stgStageXML
            // 
            this.stgStageXML.Enabled = false;
            this.stgStageXML.Location = new System.Drawing.Point(94, 72);
            this.stgStageXML.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stgStageXML.Name = "stgStageXML";
            this.stgStageXML.Size = new System.Drawing.Size(88, 66);
            this.stgStageXML.TabIndex = 31;
            this.stgStageXML.Text = "Stage Image (XML)";
            this.stgStageXML.UseVisualStyleBackColor = true;
            this.stgStageXML.Click += new System.EventHandler(this.setButtonClicked);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(8, 181);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "STAGE NAME:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // stageNameTB
            // 
            this.stageNameTB.Location = new System.Drawing.Point(12, 197);
            this.stageNameTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stageNameTB.Name = "stageNameTB";
            this.stageNameTB.Size = new System.Drawing.Size(183, 20);
            this.stageNameTB.TabIndex = 29;
            this.stageNameTB.TextChanged += new System.EventHandler(this.Filter_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.checkBox1.Location = new System.Drawing.Point(13, 474);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 17);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Overwrite Existing?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.PapayaWhip;
            this.button8.Location = new System.Drawing.Point(297, 100);
            this.button8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(88, 28);
            this.button8.TabIndex = 24;
            this.button8.Text = "Clear File?";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.clearFile);
            // 
            // stgSoundEffect
            // 
            this.stgSoundEffect.Enabled = false;
            this.stgSoundEffect.Location = new System.Drawing.Point(2, 72);
            this.stgSoundEffect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stgSoundEffect.Name = "stgSoundEffect";
            this.stgSoundEffect.Size = new System.Drawing.Size(88, 66);
            this.stgSoundEffect.TabIndex = 28;
            this.stgSoundEffect.Text = "Sound Effect";
            this.stgSoundEffect.UseVisualStyleBackColor = true;
            this.stgSoundEffect.Click += new System.EventHandler(this.setButtonClicked);
            // 
            // stgStageImgBG
            // 
            this.stgStageImgBG.Enabled = false;
            this.stgStageImgBG.Location = new System.Drawing.Point(278, 2);
            this.stgStageImgBG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stgStageImgBG.Name = "stgStageImgBG";
            this.stgStageImgBG.Size = new System.Drawing.Size(88, 66);
            this.stgStageImgBG.TabIndex = 27;
            this.stgStageImgBG.Text = "Stage Image (BG)";
            this.stgStageImgBG.UseVisualStyleBackColor = true;
            this.stgStageImgBG.Click += new System.EventHandler(this.setButtonClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(8, 416);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "RENAME FILE TO:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // stageRenameTB
            // 
            this.stageRenameTB.Location = new System.Drawing.Point(13, 435);
            this.stageRenameTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stageRenameTB.Name = "stageRenameTB";
            this.stageRenameTB.Size = new System.Drawing.Size(368, 20);
            this.stageRenameTB.TabIndex = 25;
            this.stageRenameTB.TextChanged += new System.EventHandler(this.Filter_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(8, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "SONG NAME:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // songNameTB
            // 
            this.songNameTB.Location = new System.Drawing.Point(12, 158);
            this.songNameTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.songNameTB.Name = "songNameTB";
            this.songNameTB.Size = new System.Drawing.Size(183, 20);
            this.songNameTB.TabIndex = 23;
            this.songNameTB.TextChanged += new System.EventHandler(this.Filter_TextChanged);
            // 
            // stgJSONChart
            // 
            this.stgJSONChart.Enabled = false;
            this.stgJSONChart.Location = new System.Drawing.Point(186, 2);
            this.stgJSONChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stgJSONChart.Name = "stgJSONChart";
            this.stgJSONChart.Size = new System.Drawing.Size(88, 66);
            this.stgJSONChart.TabIndex = 22;
            this.stgJSONChart.Text = "Song Chart";
            this.stgJSONChart.UseVisualStyleBackColor = true;
            this.stgJSONChart.Click += new System.EventHandler(this.setButtonClicked);
            // 
            // stgOGGInst
            // 
            this.stgOGGInst.Enabled = false;
            this.stgOGGInst.Location = new System.Drawing.Point(2, 2);
            this.stgOGGInst.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stgOGGInst.Name = "stgOGGInst";
            this.stgOGGInst.Size = new System.Drawing.Size(88, 66);
            this.stgOGGInst.TabIndex = 20;
            this.stgOGGInst.Text = "Song Inst";
            this.stgOGGInst.UseVisualStyleBackColor = true;
            this.stgOGGInst.Click += new System.EventHandler(this.setButtonClicked);
            // 
            // stgOGGVoices
            // 
            this.stgOGGVoices.Enabled = false;
            this.stgOGGVoices.Location = new System.Drawing.Point(94, 2);
            this.stgOGGVoices.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stgOGGVoices.Name = "stgOGGVoices";
            this.stgOGGVoices.Size = new System.Drawing.Size(88, 66);
            this.stgOGGVoices.TabIndex = 19;
            this.stgOGGVoices.Text = "Song Vocals";
            this.stgOGGVoices.UseVisualStyleBackColor = true;
            this.stgOGGVoices.Click += new System.EventHandler(this.setButtonClicked);
            // 
            // locateStageFileLabel
            // 
            this.locateStageFileLabel.AutoSize = true;
            this.locateStageFileLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.locateStageFileLabel.Location = new System.Drawing.Point(24, 114);
            this.locateStageFileLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.locateStageFileLabel.Name = "locateStageFileLabel";
            this.locateStageFileLabel.Size = new System.Drawing.Size(80, 13);
            this.locateStageFileLabel.TabIndex = 16;
            this.locateStageFileLabel.Text = "[none selected]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(10, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "FILE EXTENSION:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // extStageLabel
            // 
            this.extStageLabel.AutoSize = true;
            this.extStageLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.extStageLabel.Location = new System.Drawing.Point(24, 81);
            this.extStageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.extStageLabel.Name = "extStageLabel";
            this.extStageLabel.Size = new System.Drawing.Size(80, 13);
            this.extStageLabel.TabIndex = 14;
            this.extStageLabel.Text = "[none selected]";
            this.extStageLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // stageFileDrop
            // 
            this.stageFileDrop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stageFileDrop.BackColor = System.Drawing.Color.Transparent;
            this.stageFileDrop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stageFileDrop.BackgroundImage")));
            this.stageFileDrop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stageFileDrop.Controls.Add(this.flowLayoutPanel1);
            this.stageFileDrop.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.stageFileDrop.Location = new System.Drawing.Point(425, 10);
            this.stageFileDrop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stageFileDrop.Name = "stageFileDrop";
            this.stageFileDrop.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stageFileDrop.Size = new System.Drawing.Size(492, 282);
            this.stageFileDrop.TabIndex = 4;
            this.stageFileDrop.TabStop = false;
            this.stageFileDrop.Text = "Added Files";
            this.stageFileDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox1_DragDrop);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(425, 306);
            this.button7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(136, 41);
            this.button7.TabIndex = 23;
            this.button7.Text = "Generate Mod Folder";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Location = new System.Drawing.Point(425, 359);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(492, 136);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Added Songs";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button11.Enabled = false;
            this.button11.Location = new System.Drawing.Point(425, 499);
            this.button11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(487, 41);
            this.button11.TabIndex = 23;
            this.button11.Text = "Generate Week File";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(750, 306);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 41);
            this.button1.TabIndex = 25;
            this.button1.Text = "Export Project as CSV";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(579, 306);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 41);
            this.button2.TabIndex = 26;
            this.button2.Text = "Import Project as CSV";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.gradient;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 19);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(459, 248);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // updateAssetBtn
            // 
            this.updateAssetBtn.Enabled = false;
            this.updateAssetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateAssetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.updateAssetBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.updateAssetBtn.Location = new System.Drawing.Point(130, 459);
            this.updateAssetBtn.Margin = new System.Windows.Forms.Padding(2);
            this.updateAssetBtn.Name = "updateAssetBtn";
            this.updateAssetBtn.Size = new System.Drawing.Size(123, 43);
            this.updateAssetBtn.TabIndex = 60;
            this.updateAssetBtn.Text = "Update";
            this.updateAssetBtn.UseVisualStyleBackColor = true;
            this.updateAssetBtn.Click += new System.EventHandler(this.updateAssetBtn_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AllowDrop = true;
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.gradient;
            this.flowLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.stgOGGInst);
            this.flowLayoutPanel2.Controls.Add(this.stgOGGVoices);
            this.flowLayoutPanel2.Controls.Add(this.stgJSONChart);
            this.flowLayoutPanel2.Controls.Add(this.stgStageImgBG);
            this.flowLayoutPanel2.Controls.Add(this.stgSoundEffect);
            this.flowLayoutPanel2.Controls.Add(this.stgStageXML);
            this.flowLayoutPanel2.Controls.Add(this.stgMP4Video);
            this.flowLayoutPanel2.Controls.Add(this.stgPNGchar);
            this.flowLayoutPanel2.Controls.Add(this.stgPNGIcon);
            this.flowLayoutPanel2.Controls.Add(this.stgXMLchar);
            this.flowLayoutPanel2.Controls.Add(this.stgPlaceholderChart);
            this.flowLayoutPanel2.Controls.Add(this.stgStageLua);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 222);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(388, 188);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.darken;
            this.ClientSize = new System.Drawing.Size(927, 563);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.stageFileDrop);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(943, 602);
            this.MinimumSize = new System.Drawing.Size(943, 602);
            this.Name = "Form1";
            this.Text = "Mod Asset Sorter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.copyStageRenameBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyStageNameBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyCharacterNameBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copySongNameBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearCharacterNameBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearStageRenameBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearStageNameBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearSongNameBtn)).EndInit();
            this.stageFileDrop.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox stageFileDrop;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label locateStageFileLabel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label extStageLabel;
		private System.Windows.Forms.Button stgJSONChart;
		private System.Windows.Forms.Button stgOGGInst;
		private System.Windows.Forms.Button stgOGGVoices;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.TextBox songNameTB;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox stageRenameTB;
		private System.Windows.Forms.Button stgSoundEffect;
		private System.Windows.Forms.Button stgStageImgBG;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button stgStageXML;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox stageNameTB;
		private System.Windows.Forms.Button stgMP4Video;
		private System.Windows.Forms.PictureBox clearSongNameBtn;
		private System.Windows.Forms.PictureBox clearStageRenameBtn;
		private System.Windows.Forms.PictureBox clearStageNameBtn;
        private System.Windows.Forms.PictureBox clearCharacterNameBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox characterNameTB;
        private System.Windows.Forms.Button stgXMLchar;
        private System.Windows.Forms.Button stgPNGIcon;
        private System.Windows.Forms.Button stgPNGchar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button stgPlaceholderChart;
        private System.Windows.Forms.Button stgStageLua;
        private System.Windows.Forms.TextBox headerText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label assetTypeLabel;
        private System.Windows.Forms.Button btnAssetAdd;
        private System.Windows.Forms.PictureBox copySongNameBtn;
        private System.Windows.Forms.PictureBox copyStageNameBtn;
        private System.Windows.Forms.PictureBox copyCharacterNameBtn;
        private System.Windows.Forms.PictureBox copyStageRenameBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button updateAssetBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}

