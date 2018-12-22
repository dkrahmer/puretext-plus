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
using System;
using System.Windows.Forms;

namespace PureTextPlus
{
	/// <summary>
	/// Form for the user setting the Options.
	/// </summary>
	public partial class FormOptions : Form
	{
		public FormOptions()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

			chkControl.Checked = Preferences.Instance.ModifierPureControl;
			chkShift.Checked = Preferences.Instance.ModifierPureShift;
			chkWin.Checked = Preferences.Instance.ModifierPureWindows;
			cboLetter.SelectedItem = Preferences.Instance.Hotkey;
			chkControlPlain.Checked = Preferences.Instance.ModifierPlainControl;
			chkShiftPlan.Checked = Preferences.Instance.ModifierPlainShift;
			chkWinPlain.Checked = Preferences.Instance.ModifierPlainWindows;
			cboPlainLetter.SelectedItem = Preferences.Instance.PlainTextHotKey;
			chkControlHtml.Checked = Preferences.Instance.ModifierHtmlControl;
			chkShiftHtml.Checked = Preferences.Instance.ModifierHtmlShift;
			chkWinHtml.Checked = Preferences.Instance.ModifierHtmlWindows;
			cboHtmlLetter.SelectedItem = Preferences.Instance.HtmlTextHotKey;
			chkPasteActiveWindow.Checked = Preferences.Instance.PasteIntoActiveWindow;
			chkPlaySound.Checked = Preferences.Instance.PlaySound;
			chkRunAtStartup.Checked = Preferences.Instance.Startup;
			chkTrayIcon.Checked = Preferences.Instance.TrayIconVisible;
		}

		private void BtnOKClick(object sender, EventArgs e)
		{
			Preferences.Instance.ModifierPureControl = chkControl.Checked;
			Preferences.Instance.ModifierPureShift = chkShift.Checked;
			Preferences.Instance.ModifierPureWindows = chkWin.Checked;
			Preferences.Instance.ModifierPlainControl = chkControlPlain.Checked;
			Preferences.Instance.ModifierPlainShift = chkShiftPlan.Checked;
			Preferences.Instance.ModifierPlainWindows = chkWinPlain.Checked;
			Preferences.Instance.ModifierHtmlControl = chkControlHtml.Checked;
			Preferences.Instance.ModifierHtmlShift = chkShiftHtml.Checked;
			Preferences.Instance.ModifierHtmlWindows = chkWinHtml.Checked;
			Preferences.Instance.PasteIntoActiveWindow = chkPasteActiveWindow.Checked;
			Preferences.Instance.PlaySound = chkPlaySound.Checked;
			Preferences.Instance.Startup = chkRunAtStartup.Checked;
			Preferences.Instance.TrayIconVisible = chkTrayIcon.Checked;
			Preferences.Instance.Hotkey = (string) cboLetter.SelectedItem;
			Preferences.Instance.PlainTextHotKey = (string) cboPlainLetter.SelectedItem;
			Preferences.Instance.HtmlTextHotKey = (string) cboHtmlLetter.SelectedItem;

			Preferences.Instance.Save();
			DialogResult = DialogResult.OK;
			Close();

		}

		private void BtnCancelClick(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
