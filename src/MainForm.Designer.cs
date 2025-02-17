﻿namespace JoyConForm
{
	partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonScan = new System.Windows.Forms.Button();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.buttonMouseTrack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonScan
            // 
            this.buttonScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonScan.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.buttonScan, "buttonScan");
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.UseVisualStyleBackColor = false;
            this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
            // 
            // timerUpdate
            // 
            this.timerUpdate.Interval = 16;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // picture1
            // 
            this.picture1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.picture1, "picture1");
            this.picture1.Name = "picture1";
            this.picture1.TabStop = false;
            // 
            // buttonMouseTrack
            // 
            this.buttonMouseTrack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMouseTrack.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.buttonMouseTrack, "buttonMouseTrack");
            this.buttonMouseTrack.Name = "buttonMouseTrack";
            this.buttonMouseTrack.UseVisualStyleBackColor = false;
            this.buttonMouseTrack.Click += new System.EventHandler(this.buttonMouseTrack_Click_1);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.buttonMouseTrack);
            this.Controls.Add(this.picture1);
            this.Controls.Add(this.buttonScan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonScan;
		private System.Windows.Forms.Timer timerUpdate;
		private System.Windows.Forms.PictureBox picture1;
        private System.Windows.Forms.Button buttonMouseTrack;
    }
}

