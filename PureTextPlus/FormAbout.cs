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
using System.Reflection;
using System.Windows.Forms;

namespace PureTextPlus
{
	/// <summary>
	/// Description of frmAbout.
	/// </summary>
	public partial class FormAbout : Form
	{
		public FormAbout()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

			Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
			AssemblyName asmName = assembly.GetName();
			lblTitle.Text = string.Format("{0} {1}", Preferences.APPLICATION_TITLE, asmName.Version);

			object[] customAttributes = assembly.GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
			if ((customAttributes != null) && (customAttributes.Length > 0))
			{
				lblDescription.Text = ((AssemblyDescriptionAttribute) customAttributes[0]).Description;
			}
			customAttributes = assembly.GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
			/*
			if ((customAttributes != null) && (customAttributes.Length > 0))
				lblCopyright.Text = ((AssemblyCopyrightAttribute)customAttributes[0]).Copyright;
			*/
		}

		private void BtnCloseClick(object sender, EventArgs e)
		{
			Close();
		}

		private void lblMelloware_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("http://melloware.com");
		}

		private void lblKrahmer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("http://www.dougsuniverse.com");
		}

		private void lnkMiller_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("http://www.stevemiller.net/puretext/");
		}
	}
}
