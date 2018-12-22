/*
	PureText+ - http://code.google.com/p/puretext-plus/
	
	Copyright (C) 2003 Steve P. Miller, http://www.stevemiller.net/puretext/
	Copyright (C) 2011 Melloware, http://www.melloware.com
	Copyright (C) 2018 Doug Krahmer, http://www.dougsuniverse.com
	
   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

	   http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
	
	The idea of the Original PureText Code is Copyright (C) 2003 Steve P. Miller
	
	NO code was taken from the original project this was rewritten from scratch
	from just the idea of Puretext.
*/
namespace PureTextPlus
{
	partial class FormAbout
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
			this.imgIcon = new System.Windows.Forms.PictureBox();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblDescription = new System.Windows.Forms.Label();
			this.lblCopyright = new System.Windows.Forms.Label();
			this.lblMelloware = new System.Windows.Forms.LinkLabel();
			this.lblOriginalAuthor = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.lnkMiller = new System.Windows.Forms.LinkLabel();
			this.lblKrahmer = new System.Windows.Forms.LinkLabel();
			this.lblCopyright2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize) (this.imgIcon)).BeginInit();
			this.SuspendLayout();
			// 
			// imgIcon
			// 
			this.imgIcon.Image = ((System.Drawing.Image) (resources.GetObject("imgIcon.Image")));
			this.imgIcon.InitialImage = null;
			this.imgIcon.Location = new System.Drawing.Point(12, 12);
			this.imgIcon.Name = "imgIcon";
			this.imgIcon.Size = new System.Drawing.Size(54, 58);
			this.imgIcon.TabIndex = 0;
			this.imgIcon.TabStop = false;
			// 
			// lblTitle
			// 
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.lblTitle.Location = new System.Drawing.Point(72, 12);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(310, 23);
			this.lblTitle.TabIndex = 1;
			this.lblTitle.Text = "PureTextPlus";
			// 
			// lblDescription
			// 
			this.lblDescription.Location = new System.Drawing.Point(73, 46);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(368, 51);
			this.lblDescription.TabIndex = 2;
			this.lblDescription.Text = "Description";
			// 
			// lblCopyright
			// 
			this.lblCopyright.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblCopyright.Location = new System.Drawing.Point(12, 97);
			this.lblCopyright.Name = "lblCopyright";
			this.lblCopyright.Size = new System.Drawing.Size(239, 23);
			this.lblCopyright.TabIndex = 3;
			this.lblCopyright.Text = "Coppyright 2011 Melloware";
			this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblMelloware
			// 
			this.lblMelloware.Location = new System.Drawing.Point(257, 97);
			this.lblMelloware.Name = "lblMelloware";
			this.lblMelloware.Size = new System.Drawing.Size(184, 23);
			this.lblMelloware.TabIndex = 4;
			this.lblMelloware.TabStop = true;
			this.lblMelloware.Text = "http://melloware.com";
			this.lblMelloware.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblMelloware.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblMelloware_LinkClicked);
			// 
			// lblOriginalAuthor
			// 
			this.lblOriginalAuthor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblOriginalAuthor.Location = new System.Drawing.Point(12, 143);
			this.lblOriginalAuthor.Name = "lblOriginalAuthor";
			this.lblOriginalAuthor.Size = new System.Drawing.Size(239, 23);
			this.lblOriginalAuthor.TabIndex = 5;
			this.lblOriginalAuthor.Text = "Based on PureText by Steve P. Miller";
			this.lblOriginalAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(165, 181);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 6;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// lnkMiller
			// 
			this.lnkMiller.Location = new System.Drawing.Point(257, 143);
			this.lnkMiller.Name = "lnkMiller";
			this.lnkMiller.Size = new System.Drawing.Size(184, 23);
			this.lnkMiller.TabIndex = 7;
			this.lnkMiller.TabStop = true;
			this.lnkMiller.Text = "http://www.stevemiller.net/puretext/";
			this.lnkMiller.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lnkMiller.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkMiller_LinkClicked);
			// 
			// lblKrahmer
			// 
			this.lblKrahmer.Location = new System.Drawing.Point(257, 120);
			this.lblKrahmer.Name = "lblKrahmer";
			this.lblKrahmer.Size = new System.Drawing.Size(184, 23);
			this.lblKrahmer.TabIndex = 9;
			this.lblKrahmer.TabStop = true;
			this.lblKrahmer.Text = "http://www.dougsuniverse.com";
			this.lblKrahmer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblKrahmer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblKrahmer_LinkClicked);
			// 
			// lblCopyright2
			// 
			this.lblCopyright2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblCopyright2.Location = new System.Drawing.Point(12, 120);
			this.lblCopyright2.Name = "lblCopyright2";
			this.lblCopyright2.Size = new System.Drawing.Size(239, 23);
			this.lblCopyright2.TabIndex = 8;
			this.lblCopyright2.Text = "Coppyright 2018 Doug Krahmer";
			this.lblCopyright2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FormAbout
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(453, 221);
			this.Controls.Add(this.lblKrahmer);
			this.Controls.Add(this.lblCopyright2);
			this.Controls.Add(this.lnkMiller);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.lblOriginalAuthor);
			this.Controls.Add(this.lblMelloware);
			this.Controls.Add(this.lblCopyright);
			this.Controls.Add(this.lblDescription);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.imgIcon);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormAbout";
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "About PureTextPlus";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize) (this.imgIcon)).EndInit();
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.LinkLabel lnkMiller;
		private System.Windows.Forms.LinkLabel lblMelloware;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label lblOriginalAuthor;
		private System.Windows.Forms.Label lblCopyright;
		private System.Windows.Forms.PictureBox imgIcon;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.LinkLabel lblKrahmer;
		private System.Windows.Forms.Label lblCopyright2;
	}
}
