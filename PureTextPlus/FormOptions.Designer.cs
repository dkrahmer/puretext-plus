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
	partial class FormOptions
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOptions));
			this.gbHotkey = new System.Windows.Forms.GroupBox();
			this.cboLetter = new System.Windows.Forms.ComboBox();
			this.chkWin = new System.Windows.Forms.CheckBox();
			this.chkShift = new System.Windows.Forms.CheckBox();
			this.chkControl = new System.Windows.Forms.CheckBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.gbActions = new System.Windows.Forms.GroupBox();
			this.chkPlaySound = new System.Windows.Forms.CheckBox();
			this.chkPasteActiveWindow = new System.Windows.Forms.CheckBox();
			this.gbGlobal = new System.Windows.Forms.GroupBox();
			this.chkTrayIcon = new System.Windows.Forms.CheckBox();
			this.chkRunAtStartup = new System.Windows.Forms.CheckBox();
			this.gbPlainKey = new System.Windows.Forms.GroupBox();
			this.cboPlainLetter = new System.Windows.Forms.ComboBox();
			this.chkWinPlain = new System.Windows.Forms.CheckBox();
			this.chkShiftPlan = new System.Windows.Forms.CheckBox();
			this.chkControlPlain = new System.Windows.Forms.CheckBox();
			this.gbHtmlKey = new System.Windows.Forms.GroupBox();
			this.cboHtmlLetter = new System.Windows.Forms.ComboBox();
			this.chkWinHtml = new System.Windows.Forms.CheckBox();
			this.chkShiftHtml = new System.Windows.Forms.CheckBox();
			this.chkControlHtml = new System.Windows.Forms.CheckBox();
			this.gbHotkey.SuspendLayout();
			this.gbActions.SuspendLayout();
			this.gbGlobal.SuspendLayout();
			this.gbPlainKey.SuspendLayout();
			this.gbHtmlKey.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbHotkey
			// 
			this.gbHotkey.Controls.Add(this.cboLetter);
			this.gbHotkey.Controls.Add(this.chkWin);
			this.gbHotkey.Controls.Add(this.chkShift);
			this.gbHotkey.Controls.Add(this.chkControl);
			this.gbHotkey.Location = new System.Drawing.Point(12, 12);
			this.gbHotkey.Name = "gbHotkey";
			this.gbHotkey.Size = new System.Drawing.Size(319, 89);
			this.gbHotkey.TabIndex = 0;
			this.gbHotkey.TabStop = false;
			this.gbHotkey.Text = "Hotkey to convert the clipboard to pure text";
			// 
			// cboLetter
			// 
			this.cboLetter.FormattingEnabled = true;
			this.cboLetter.Items.AddRange(new object[] {
			"A",
			"B",
			"C",
			"D",
			"E",
			"F",
			"G",
			"H",
			"I",
			"J",
			"K",
			"L",
			"M",
			"N",
			"O",
			"P",
			"Q",
			"R",
			"S",
			"T",
			"U",
			"V",
			"X",
			"Y",
			"Z",
			"0",
			"1",
			"2",
			"3",
			"4",
			"5",
			"6",
			"7",
			"8",
			"9",
			"F1",
			"F2",
			"F3",
			"F4",
			"F5",
			"F6",
			"F7",
			"F8",
			"F9",
			"F10",
			"F11",
			"F12",
			"Oemplus",
			"Oemcomma",
			"OemMinus",
			"OemPeriod",
			"Oemtilde",
			"OemOpenBrackets",
			"OemCloseBrackets",
			"OemQuotes",
			"OemBackslash"});
			this.cboLetter.Location = new System.Drawing.Point(6, 22);
			this.cboLetter.Name = "cboLetter";
			this.cboLetter.Size = new System.Drawing.Size(198, 21);
			this.cboLetter.TabIndex = 3;
			// 
			// chkWin
			// 
			this.chkWin.Location = new System.Drawing.Point(219, 58);
			this.chkWin.Name = "chkWin";
			this.chkWin.Size = new System.Drawing.Size(84, 24);
			this.chkWin.TabIndex = 2;
			this.chkWin.Text = "Windows";
			this.chkWin.UseVisualStyleBackColor = true;
			// 
			// chkShift
			// 
			this.chkShift.Location = new System.Drawing.Point(219, 39);
			this.chkShift.Name = "chkShift";
			this.chkShift.Size = new System.Drawing.Size(84, 24);
			this.chkShift.TabIndex = 1;
			this.chkShift.Text = "Shift";
			this.chkShift.UseVisualStyleBackColor = true;
			// 
			// chkControl
			// 
			this.chkControl.Location = new System.Drawing.Point(219, 20);
			this.chkControl.Name = "chkControl";
			this.chkControl.Size = new System.Drawing.Size(84, 24);
			this.chkControl.TabIndex = 0;
			this.chkControl.Text = "Control";
			this.chkControl.UseVisualStyleBackColor = true;
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(336, 12);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.BtnOKClick);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(336, 41);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
			// 
			// gbActions
			// 
			this.gbActions.Controls.Add(this.chkPlaySound);
			this.gbActions.Controls.Add(this.chkPasteActiveWindow);
			this.gbActions.Location = new System.Drawing.Point(12, 285);
			this.gbActions.Name = "gbActions";
			this.gbActions.Size = new System.Drawing.Size(319, 84);
			this.gbActions.TabIndex = 3;
			this.gbActions.TabStop = false;
			this.gbActions.Text = "Perform actions on Hotkey pressed";
			// 
			// chkPlaySound
			// 
			this.chkPlaySound.Location = new System.Drawing.Point(7, 50);
			this.chkPlaySound.Name = "chkPlaySound";
			this.chkPlaySound.Size = new System.Drawing.Size(296, 24);
			this.chkPlaySound.TabIndex = 1;
			this.chkPlaySound.Text = "Play a sound";
			this.chkPlaySound.UseVisualStyleBackColor = true;
			// 
			// chkPasteActiveWindow
			// 
			this.chkPasteActiveWindow.Location = new System.Drawing.Point(7, 20);
			this.chkPasteActiveWindow.Name = "chkPasteActiveWindow";
			this.chkPasteActiveWindow.Size = new System.Drawing.Size(296, 24);
			this.chkPasteActiveWindow.TabIndex = 0;
			this.chkPasteActiveWindow.Text = "Paste converted text into active window";
			this.chkPasteActiveWindow.UseVisualStyleBackColor = true;
			// 
			// gbGlobal
			// 
			this.gbGlobal.Controls.Add(this.chkTrayIcon);
			this.gbGlobal.Controls.Add(this.chkRunAtStartup);
			this.gbGlobal.Location = new System.Drawing.Point(12, 374);
			this.gbGlobal.Name = "gbGlobal";
			this.gbGlobal.Size = new System.Drawing.Size(319, 80);
			this.gbGlobal.TabIndex = 4;
			this.gbGlobal.TabStop = false;
			this.gbGlobal.Text = "Global Options";
			// 
			// chkTrayIcon
			// 
			this.chkTrayIcon.Location = new System.Drawing.Point(7, 50);
			this.chkTrayIcon.Name = "chkTrayIcon";
			this.chkTrayIcon.Size = new System.Drawing.Size(306, 24);
			this.chkTrayIcon.TabIndex = 1;
			this.chkTrayIcon.Text = "Show Tray Icon (WARNING registry edit req to enable)";
			this.chkTrayIcon.UseVisualStyleBackColor = true;
			// 
			// chkRunAtStartup
			// 
			this.chkRunAtStartup.Location = new System.Drawing.Point(7, 20);
			this.chkRunAtStartup.Name = "chkRunAtStartup";
			this.chkRunAtStartup.Size = new System.Drawing.Size(306, 24);
			this.chkRunAtStartup.TabIndex = 0;
			this.chkRunAtStartup.Text = "Automatically run at Windows startup";
			this.chkRunAtStartup.UseVisualStyleBackColor = true;
			// 
			// gbPlainKey
			// 
			this.gbPlainKey.Controls.Add(this.cboPlainLetter);
			this.gbPlainKey.Controls.Add(this.chkWinPlain);
			this.gbPlainKey.Controls.Add(this.chkShiftPlan);
			this.gbPlainKey.Controls.Add(this.chkControlPlain);
			this.gbPlainKey.Location = new System.Drawing.Point(12, 104);
			this.gbPlainKey.Name = "gbPlainKey";
			this.gbPlainKey.Size = new System.Drawing.Size(319, 87);
			this.gbPlainKey.TabIndex = 4;
			this.gbPlainKey.TabStop = false;
			this.gbPlainKey.Text = "Hotkey to convert the clipboard to plain text";
			// 
			// cboPlainLetter
			// 
			this.cboPlainLetter.FormattingEnabled = true;
			this.cboPlainLetter.Items.AddRange(new object[] {
			"A",
			"B",
			"C",
			"D",
			"E",
			"F",
			"G",
			"H",
			"I",
			"J",
			"K",
			"L",
			"M",
			"N",
			"O",
			"P",
			"Q",
			"R",
			"S",
			"T",
			"U",
			"V",
			"X",
			"Y",
			"Z",
			"0",
			"1",
			"2",
			"3",
			"4",
			"5",
			"6",
			"7",
			"8",
			"9",
			"F1",
			"F2",
			"F3",
			"F4",
			"F5",
			"F6",
			"F7",
			"F8",
			"F9",
			"F10",
			"F11",
			"F12",
			"Oemplus",
			"Oemcomma",
			"OemMinus",
			"OemPeriod",
			"Oemtilde",
			"OemOpenBrackets",
			"OemCloseBrackets",
			"OemQuotes",
			"OemBackslash"});
			this.cboPlainLetter.Location = new System.Drawing.Point(6, 22);
			this.cboPlainLetter.Name = "cboPlainLetter";
			this.cboPlainLetter.Size = new System.Drawing.Size(198, 21);
			this.cboPlainLetter.TabIndex = 3;
			// 
			// chkWinPlain
			// 
			this.chkWinPlain.Location = new System.Drawing.Point(219, 58);
			this.chkWinPlain.Name = "chkWinPlain";
			this.chkWinPlain.Size = new System.Drawing.Size(84, 24);
			this.chkWinPlain.TabIndex = 2;
			this.chkWinPlain.Text = "Windows";
			this.chkWinPlain.UseVisualStyleBackColor = true;
			// 
			// chkShiftPlan
			// 
			this.chkShiftPlan.Location = new System.Drawing.Point(219, 39);
			this.chkShiftPlan.Name = "chkShiftPlan";
			this.chkShiftPlan.Size = new System.Drawing.Size(84, 24);
			this.chkShiftPlan.TabIndex = 1;
			this.chkShiftPlan.Text = "Shift";
			this.chkShiftPlan.UseVisualStyleBackColor = true;
			// 
			// chkControlPlain
			// 
			this.chkControlPlain.Location = new System.Drawing.Point(219, 20);
			this.chkControlPlain.Name = "chkControlPlain";
			this.chkControlPlain.Size = new System.Drawing.Size(84, 24);
			this.chkControlPlain.TabIndex = 0;
			this.chkControlPlain.Text = "Control";
			this.chkControlPlain.UseVisualStyleBackColor = true;
			// 
			// gbHtmlKey
			// 
			this.gbHtmlKey.Controls.Add(this.cboHtmlLetter);
			this.gbHtmlKey.Controls.Add(this.chkWinHtml);
			this.gbHtmlKey.Controls.Add(this.chkShiftHtml);
			this.gbHtmlKey.Controls.Add(this.chkControlHtml);
			this.gbHtmlKey.Location = new System.Drawing.Point(12, 194);
			this.gbHtmlKey.Name = "gbHtmlKey";
			this.gbHtmlKey.Size = new System.Drawing.Size(319, 88);
			this.gbHtmlKey.TabIndex = 5;
			this.gbHtmlKey.TabStop = false;
			this.gbHtmlKey.Text = "Hotkey to convert the clipboard to HTML text";
			// 
			// cboHtmlLetter
			// 
			this.cboHtmlLetter.FormattingEnabled = true;
			this.cboHtmlLetter.Items.AddRange(new object[] {
			"A",
			"B",
			"C",
			"D",
			"E",
			"F",
			"G",
			"H",
			"I",
			"J",
			"K",
			"L",
			"M",
			"N",
			"O",
			"P",
			"Q",
			"R",
			"S",
			"T",
			"U",
			"V",
			"X",
			"Y",
			"Z",
			"0",
			"1",
			"2",
			"3",
			"4",
			"5",
			"6",
			"7",
			"8",
			"9",
			"F1",
			"F2",
			"F3",
			"F4",
			"F5",
			"F6",
			"F7",
			"F8",
			"F9",
			"F10",
			"F11",
			"F12",
			"Oemplus",
			"Oemcomma",
			"OemMinus",
			"OemPeriod",
			"Oemtilde",
			"OemOpenBrackets",
			"OemCloseBrackets",
			"OemQuotes",
			"OemBackslash"});
			this.cboHtmlLetter.Location = new System.Drawing.Point(6, 22);
			this.cboHtmlLetter.Name = "cboHtmlLetter";
			this.cboHtmlLetter.Size = new System.Drawing.Size(198, 21);
			this.cboHtmlLetter.TabIndex = 3;
			// 
			// chkWinHtml
			// 
			this.chkWinHtml.Location = new System.Drawing.Point(219, 58);
			this.chkWinHtml.Name = "chkWinHtml";
			this.chkWinHtml.Size = new System.Drawing.Size(84, 24);
			this.chkWinHtml.TabIndex = 2;
			this.chkWinHtml.Text = "Windows";
			this.chkWinHtml.UseVisualStyleBackColor = true;
			// 
			// chkShiftHtml
			// 
			this.chkShiftHtml.Location = new System.Drawing.Point(219, 39);
			this.chkShiftHtml.Name = "chkShiftHtml";
			this.chkShiftHtml.Size = new System.Drawing.Size(84, 24);
			this.chkShiftHtml.TabIndex = 1;
			this.chkShiftHtml.Text = "Shift";
			this.chkShiftHtml.UseVisualStyleBackColor = true;
			// 
			// chkControlHtml
			// 
			this.chkControlHtml.Location = new System.Drawing.Point(219, 20);
			this.chkControlHtml.Name = "chkControlHtml";
			this.chkControlHtml.Size = new System.Drawing.Size(84, 24);
			this.chkControlHtml.TabIndex = 0;
			this.chkControlHtml.Text = "Control";
			this.chkControlHtml.UseVisualStyleBackColor = true;
			// 
			// FormOptions
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(414, 468);
			this.Controls.Add(this.gbHtmlKey);
			this.Controls.Add(this.gbPlainKey);
			this.Controls.Add(this.gbGlobal);
			this.Controls.Add(this.gbActions);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.gbHotkey);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormOptions";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PureText+ Options";
			this.gbHotkey.ResumeLayout(false);
			this.gbActions.ResumeLayout(false);
			this.gbGlobal.ResumeLayout(false);
			this.gbPlainKey.ResumeLayout(false);
			this.gbHtmlKey.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.CheckBox chkRunAtStartup;
		private System.Windows.Forms.CheckBox chkTrayIcon;
		private System.Windows.Forms.GroupBox gbGlobal;
		private System.Windows.Forms.CheckBox chkPasteActiveWindow;
		private System.Windows.Forms.CheckBox chkPlaySound;
		private System.Windows.Forms.GroupBox gbActions;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.ComboBox cboLetter;
		private System.Windows.Forms.CheckBox chkControl;
		private System.Windows.Forms.CheckBox chkShift;
		private System.Windows.Forms.CheckBox chkWin;
		private System.Windows.Forms.GroupBox gbHotkey;
		private System.Windows.Forms.GroupBox gbPlainKey;
		private System.Windows.Forms.ComboBox cboPlainLetter;
		private System.Windows.Forms.CheckBox chkWinPlain;
		private System.Windows.Forms.CheckBox chkShiftPlan;
		private System.Windows.Forms.CheckBox chkControlPlain;
		private System.Windows.Forms.GroupBox gbHtmlKey;
		private System.Windows.Forms.ComboBox cboHtmlLetter;
		private System.Windows.Forms.CheckBox chkWinHtml;
		private System.Windows.Forms.CheckBox chkShiftHtml;
		private System.Windows.Forms.CheckBox chkControlHtml;
	}
}
