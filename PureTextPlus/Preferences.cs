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
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace PureTextPlus
{
	/// <summary>
	/// Singleton to hold preferences for the app and store and retrieve from the Registry.
	/// </summary>
	public sealed class Preferences
	{
		// singleton instance
		private static readonly Preferences instance = new Preferences();

		// app title
		public const String APPLICATION_TITLE = "PureText+";

		// registry key for app settings
		public const string REG_KEY_PURETEXT = @"SOFTWARE\Melloware\PureTextPlus";

		// registry key for windows startup entries
		public const string REG_KEY_STARTUP = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";

		// fields
		public bool PlaySound             = false;
		public bool Startup               = false;
		public bool TrayIconVisible       = true;
		public bool PasteIntoActiveWindow = true;

		public bool ModifierPureWindows = false;
		public bool ModifierPureShift   = true;
		public bool ModifierPureControl = true;
		public bool ModifierPureAlt     = false;
		public string Hotkey            = "V";

		public bool ModifierPlainWindows = false;
		public bool ModifierPlainShift   = true;
		public bool ModifierPlainControl = true;
		public bool ModifierPlainAlt     = false;
		public string PlainTextHotKey    = "N";

		public bool ModifierHtmlWindows = false;
		public bool ModifierHtmlShift   = true;
		public bool ModifierHtmlControl = true;
		public bool ModifierHtmlAlt     = false;
		public string HtmlTextHotKey    = "M";

		/// <summary>
		/// Singleton access
		/// </summary>
		public static Preferences Instance
		{
			get
			{
				return instance;
			}
		}

		/// <summary>
		/// Private no arg constructor for Singleton
		/// </summary>
		private Preferences()
		{
			// create the key if it does not exist
			RegistryKey key = Registry.CurrentUser.OpenSubKey(REG_KEY_PURETEXT, true);
			if (key == null)
			{
				key = Registry.CurrentUser.CreateSubKey(REG_KEY_PURETEXT);
			}
			using (key)
			{
				PlaySound = Convert.ToBoolean(key.GetValue("PlaySound", false));

				ModifierPureWindows = Convert.ToBoolean(key.GetValue("ModifierPureWindows", false));
				ModifierPureShift   = Convert.ToBoolean(key.GetValue("ModifierPureShift", true));
				ModifierPureControl = Convert.ToBoolean(key.GetValue("ModifierPureControl", true));
				ModifierPureAlt     = Convert.ToBoolean(key.GetValue("ModifierPureAlt", false));

				ModifierPlainWindows = Convert.ToBoolean(key.GetValue("ModifierPlainWindows", false));
				ModifierPlainShift   = Convert.ToBoolean(key.GetValue("ModifierPlainShift", true));
				ModifierPlainControl = Convert.ToBoolean(key.GetValue("ModifierPlainControl", true));
				ModifierPlainAlt     = Convert.ToBoolean(key.GetValue("ModifierPlainAlt", false));

				ModifierHtmlWindows = Convert.ToBoolean(key.GetValue("ModifierHtmlWindows", false));
				ModifierHtmlShift   = Convert.ToBoolean(key.GetValue("ModifierHtmlShift", true));
				ModifierHtmlControl = Convert.ToBoolean(key.GetValue("ModifierHtmlControl", true));
				ModifierHtmlAlt     = Convert.ToBoolean(key.GetValue("ModifierHtmlAlt", false));

				Hotkey = (string) key.GetValue("Hotkey", "V");
				PlainTextHotKey = (string) key.GetValue("PlainTextHotKey", "N");
				HtmlTextHotKey = (string) key.GetValue("HtmlTextHotKey", "M");
				TrayIconVisible = Convert.ToBoolean(key.GetValue("TrayIconVisible", true));
				PasteIntoActiveWindow = Convert.ToBoolean(key.GetValue("PasteIntoActiveWindow", true));
			}

			key = Registry.CurrentUser.OpenSubKey(REG_KEY_STARTUP, true);
			using (key)
			{
				Startup = key.GetValue(APPLICATION_TITLE) != null;
			}
		}

		/// <summary>
		/// Saves the values to the registry
		/// </summary>
		public void Save()
		{
			try
			{
				RegistryKey key = Registry.CurrentUser.OpenSubKey(REG_KEY_PURETEXT, true);
				using (key)
				{
					key.SetValue("PlaySound", PlaySound, RegistryValueKind.DWord);
					key.SetValue("ModifierPureWindows", ModifierPureWindows, RegistryValueKind.DWord);
					key.SetValue("ModifierPureShift", ModifierPureShift, RegistryValueKind.DWord);
					key.SetValue("ModifierPureControl", ModifierPureControl, RegistryValueKind.DWord);
					key.SetValue("ModifierPureAlt", ModifierPureAlt, RegistryValueKind.DWord);
					key.SetValue("ModifierPlainWindows", ModifierPlainWindows, RegistryValueKind.DWord);
					key.SetValue("ModifierPlainShift", ModifierPlainShift, RegistryValueKind.DWord);
					key.SetValue("ModifierPlainControl", ModifierPlainControl, RegistryValueKind.DWord);
					key.SetValue("ModifierPlainAlt", ModifierPlainAlt, RegistryValueKind.DWord);
					key.SetValue("ModifierHtmlWindows", ModifierHtmlWindows, RegistryValueKind.DWord);
					key.SetValue("ModifierHtmlShift", ModifierHtmlShift, RegistryValueKind.DWord);
					key.SetValue("ModifierHtmlControl", ModifierHtmlControl, RegistryValueKind.DWord);
					key.SetValue("ModifierHtmlAlt", ModifierHtmlAlt, RegistryValueKind.DWord);
					key.SetValue("TrayIconVisible", TrayIconVisible, RegistryValueKind.DWord);
					key.SetValue("PasteIntoActiveWindow", PasteIntoActiveWindow, RegistryValueKind.DWord);
					key.SetValue("Hotkey", Hotkey, RegistryValueKind.String);
					key.SetValue("PlainTextHotKey", PlainTextHotKey, RegistryValueKind.String);
					key.SetValue("HtmlTextHotKey", HtmlTextHotKey, RegistryValueKind.String);
				}

				// if startup is checked must add to Run registry entry of Windows
				if (Startup)
				{
					key = Registry.CurrentUser.OpenSubKey(REG_KEY_STARTUP, true);
					using (key)
					{
						key.SetValue(APPLICATION_TITLE, Application.ExecutablePath, RegistryValueKind.String);
					}
				}
				else
				{
					key = Registry.CurrentUser.OpenSubKey(REG_KEY_STARTUP, true);
					using (key)
					{
						key.DeleteValue(APPLICATION_TITLE);
					}
				}
			}
			catch (Exception ex)
			{
				// log the exception
				Debug.WriteLine("Unexpected Exception Saving to Registry" + ex.Message);
			}
		}
	}
}
