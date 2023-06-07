
namespace FamilyUpgrade
{
	partial class AddinForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddinForm));
			this.label1 = new System.Windows.Forms.Label();
			this.destinationFolderTextBox = new System.Windows.Forms.Label();
			this.sourceFolderTextBox = new System.Windows.Forms.TextBox();
			this.destFolderTextBox = new System.Windows.Forms.TextBox();
			this.selectFamilies = new System.Windows.Forms.Button();
			this.chooseDestinationFolder = new System.Windows.Forms.Button();
			this.upgradeBtn = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(33, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Source folder:";
			// 
			// destinationFolderTextBox
			// 
			this.destinationFolderTextBox.AutoSize = true;
			this.destinationFolderTextBox.Location = new System.Drawing.Point(14, 52);
			this.destinationFolderTextBox.Name = "destinationFolderTextBox";
			this.destinationFolderTextBox.Size = new System.Drawing.Size(92, 13);
			this.destinationFolderTextBox.TabIndex = 1;
			this.destinationFolderTextBox.Text = "Destination folder:";
			// 
			// sourceFolderTextBox
			// 
			this.sourceFolderTextBox.Location = new System.Drawing.Point(109, 21);
			this.sourceFolderTextBox.Name = "sourceFolderTextBox";
			this.sourceFolderTextBox.ReadOnly = true;
			this.sourceFolderTextBox.Size = new System.Drawing.Size(402, 20);
			this.sourceFolderTextBox.TabIndex = 2;
			// 
			// destFolderTextBox
			// 
			this.destFolderTextBox.Location = new System.Drawing.Point(109, 49);
			this.destFolderTextBox.Name = "destFolderTextBox";
			this.destFolderTextBox.ReadOnly = true;
			this.destFolderTextBox.Size = new System.Drawing.Size(402, 20);
			this.destFolderTextBox.TabIndex = 3;
			// 
			// selectFamilies
			// 
			this.selectFamilies.Location = new System.Drawing.Point(517, 19);
			this.selectFamilies.Name = "selectFamilies";
			this.selectFamilies.Size = new System.Drawing.Size(99, 23);
			this.selectFamilies.TabIndex = 4;
			this.selectFamilies.Text = "Select Families";
			this.selectFamilies.UseVisualStyleBackColor = true;
			this.selectFamilies.Click += new System.EventHandler(this.selectFamilies_Click);
			// 
			// chooseDestinationFolder
			// 
			this.chooseDestinationFolder.Location = new System.Drawing.Point(517, 47);
			this.chooseDestinationFolder.Name = "chooseDestinationFolder";
			this.chooseDestinationFolder.Size = new System.Drawing.Size(99, 23);
			this.chooseDestinationFolder.TabIndex = 5;
			this.chooseDestinationFolder.Text = "Choose Folder";
			this.chooseDestinationFolder.UseVisualStyleBackColor = true;
			this.chooseDestinationFolder.Click += new System.EventHandler(this.chooseDestinationFolder_Click);
			// 
			// upgradeBtn
			// 
			this.upgradeBtn.Location = new System.Drawing.Point(630, 19);
			this.upgradeBtn.Name = "upgradeBtn";
			this.upgradeBtn.Size = new System.Drawing.Size(99, 51);
			this.upgradeBtn.TabIndex = 6;
			this.upgradeBtn.Text = "Upgrade Families";
			this.upgradeBtn.UseVisualStyleBackColor = true;
			this.upgradeBtn.Click += new System.EventHandler(this.upgradeBtn_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(209)))), ((int)(((byte)(139)))));
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 91);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(747, 55);
			this.panel1.TabIndex = 7;
			// 
			// textBox1
			// 
			this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(209)))), ((int)(((byte)(139)))));
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(228, 41);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(284, 11);
			this.textBox1.TabIndex = 4;
			this.textBox1.Text = "© Copyrights - Petersime NV 2023";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = global::FamilyUpgrade.Properties.Resources.petpanel;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(747, 55);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// AddinForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(747, 146);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.upgradeBtn);
			this.Controls.Add(this.chooseDestinationFolder);
			this.Controls.Add(this.selectFamilies);
			this.Controls.Add(this.destFolderTextBox);
			this.Controls.Add(this.sourceFolderTextBox);
			this.Controls.Add(this.destinationFolderTextBox);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddinForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Upgrade Families";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label destinationFolderTextBox;
		private System.Windows.Forms.TextBox sourceFolderTextBox;
		private System.Windows.Forms.TextBox destFolderTextBox;
		private System.Windows.Forms.Button selectFamilies;
		private System.Windows.Forms.Button chooseDestinationFolder;
		private System.Windows.Forms.Button upgradeBtn;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}