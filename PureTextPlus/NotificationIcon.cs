/*
	PureText+ - https://github.com/dkrahmer/puretext-plus
	
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
using System.Drawing;
using System.Media;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;

namespace PureTextPlus
{
	/// <summary>
	/// Main class of the application which displays the notification icon and business logic.
	/// </summary>
	public sealed class NotificationIcon
	{
		private NotifyIcon notifyIcon;
		private readonly ContextMenu _notificationMenu;
		private static readonly HotkeyHook _hotkey = new HotkeyHook();
		private static readonly HotkeyHook _plainHotKey = new HotkeyHook();
		private static readonly HotkeyHook _htmlHotKey = new HotkeyHook();
		private InputSimulator _inputSimulator = new InputSimulator();


		#region Initialize icon and menu
		public NotificationIcon()
		{
			notifyIcon = new NotifyIcon
			{
				Visible = false
			};
			_notificationMenu = new ContextMenu(InitializeMenu());

			notifyIcon.DoubleClick += IconDoubleClick;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationIcon));
			notifyIcon.Icon = (Icon) resources.GetObject("$this.Icon");
			notifyIcon.ContextMenu = _notificationMenu;

			// register the event that is fired after the key press.
			_hotkey.KeyPressed += new EventHandler<KeyPressedEventArgs>(Hotkey_KeyPressed);
			_plainHotKey.KeyPressed += new EventHandler<KeyPressedEventArgs>(PlainHotKey_KeyPressed);
			_htmlHotKey.KeyPressed += new EventHandler<KeyPressedEventArgs>(HtmlHotKey_KeyPressed);
			ConfigureApplication();
		}

		/// <summary>
		/// Creates the context menu on the right click of the tray icon.
		/// </summary>
		/// <returns>a list of MenuItems to display</returns>
		private MenuItem[] InitializeMenu()
		{
			MenuItem mnuConvert = new MenuItem("Convert To Text", IconDoubleClick)
			{
				DefaultItem = true
			};
			MenuItem[] menu = new MenuItem[] {
				mnuConvert,
				new MenuItem("Options... ", menuOptionsClick),
				new MenuItem("About "+Preferences.APPLICATION_TITLE+"...", menuAboutClick),
				new MenuItem("-"),
				new MenuItem("Exit", menuExitClick)
			};
			return menu;
		}

		/// <summary>
		/// Configures the Hotkey based on preferences.
		/// </summary>
		private void ConfigureApplication()
		{

			try
			{
				_hotkey.UnregisterHotKeys();
				ModifierKeys modifierPure = ModifierKeys.None;
				if (Preferences.Instance.ModifierPureAlt)
				{
					modifierPure = modifierPure | ModifierKeys.Alt;
				}
				if (Preferences.Instance.ModifierPureControl)
				{
					modifierPure = modifierPure | ModifierKeys.Control;
				}
				if (Preferences.Instance.ModifierPureShift)
				{
					modifierPure = modifierPure | ModifierKeys.Shift;
				}
				if (Preferences.Instance.ModifierPureWindows)
				{
					modifierPure = modifierPure | ModifierKeys.Win;
				}

				// get the new hotkey
				KeysConverter keysConverter = new KeysConverter();
				Keys keys = (Keys) keysConverter.ConvertFromString(Preferences.Instance.Hotkey);

				// register the control combination as hot key.
				_hotkey.RegisterHotKey(modifierPure, keys);
			}
			catch (Exception ex)
			{
				// could not register hotkey!
				MessageBox.Show("Whoops! Could not register hotkey:\n\n" + ex.Message + ex.StackTrace,
								"Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			try
			{
				_plainHotKey.UnregisterHotKeys();
				ModifierKeys modifierPlain = ModifierKeys.None;
				if (Preferences.Instance.ModifierPlainAlt)
				{
					modifierPlain = modifierPlain | ModifierKeys.Alt;
				}
				if (Preferences.Instance.ModifierPlainControl)
				{
					modifierPlain = modifierPlain | ModifierKeys.Control;
				}
				if (Preferences.Instance.ModifierPlainShift)
				{
					modifierPlain = modifierPlain | ModifierKeys.Shift;
				}
				if (Preferences.Instance.ModifierPlainWindows)
				{
					modifierPlain = modifierPlain | ModifierKeys.Win;
				}
				// get the new hotkey
				KeysConverter keysConverter = new KeysConverter();
				Keys plainKey = (Keys) keysConverter.ConvertFromString(Preferences.Instance.PlainTextHotKey);

				// register the control combination as hot key.
				_plainHotKey.RegisterHotKey(modifierPlain, plainKey);
			}
			catch (Exception ex)
			{
				// could not register hotkey!
				MessageBox.Show("Whoops! Could not register PLAIN hotkey:\n\n" + ex.Message + ex.StackTrace,
								"Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}

			try
			{
				_htmlHotKey.UnregisterHotKeys();
				ModifierKeys modifierHtml = ModifierKeys.None;
				if (Preferences.Instance.ModifierHtmlAlt)
				{
					modifierHtml = modifierHtml | ModifierKeys.Alt;
				}
				if (Preferences.Instance.ModifierHtmlControl)
				{
					modifierHtml = modifierHtml | ModifierKeys.Control;
				}
				if (Preferences.Instance.ModifierHtmlShift)
				{
					modifierHtml = modifierHtml | ModifierKeys.Shift;
				}
				if (Preferences.Instance.ModifierHtmlWindows)
				{
					modifierHtml = modifierHtml | ModifierKeys.Win;
				}


				// get the new hotkey
				KeysConverter keysConverter = new KeysConverter();
				Keys htmlKey = (Keys) keysConverter.ConvertFromString(Preferences.Instance.HtmlTextHotKey);

				// register the control combination as hot key.
				_htmlHotKey.RegisterHotKey(modifierHtml, htmlKey);

			}
			catch (Exception ex)
			{
				// could not register hotkey!
				MessageBox.Show("Whoops! Could not register HTML hotkey:\n\n" + ex.Message + ex.StackTrace,
								"Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}

			// set the visibility of the icon
			notifyIcon.Visible = Preferences.Instance.TrayIconVisible;
		}
		#endregion

		#region Main - Program entry point
		/// <summary>Program entry point.</summary>
		/// <param name="args">Command Line Arguments</param>
		[STAThread]
		public static void Main(string[] args)
		{
			Application.EnableVisualStyles();

			// Please use a unique name for the mutex to prevent conflicts with other programs
			using (Mutex mtx = new Mutex(true, Preferences.APPLICATION_TITLE, out bool isFirstInstance))
			{
				if (isFirstInstance)
				{
					NotificationIcon notificationIcon = new NotificationIcon();

					Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
					AssemblyName asmName = assembly.GetName();
					notificationIcon.notifyIcon.Text = string.Format("{0} {1}", Preferences.APPLICATION_TITLE, asmName.Version);

					AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
					Application.Run();
					notificationIcon.notifyIcon.Dispose();
				}
				else
				{
					// The application is already running
				}
			} // releases the Mutex
		}

		private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
		{
			try
			{
				Exception ex = (Exception) e.ExceptionObject;

				MessageBox.Show("Whoops! Please contact the developers with the following"
								+ " information:\n\n" + ex.Message + ex.StackTrace,
								"Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			finally
			{
				Application.Exit();
			}
		}
		#endregion

		#region Event Handlers
		private void menuAboutClick(object sender, EventArgs e)
		{
			FormAbout frmAbout = new FormAbout();
			frmAbout.ShowDialog();
		}

		private void menuOptionsClick(object sender, EventArgs e)
		{
			FormOptions frmOptions = new FormOptions();
			if (frmOptions.ShowDialog() == DialogResult.OK)
			{
				ConfigureApplication();
			}
		}

		private void menuExitClick(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void IconDoubleClick(object sender, EventArgs e)
		{
			// put plain text on the clipboard replacing anything that was there
			string plainText = Clipboard.GetText(TextDataFormat.UnicodeText);
			if (string.IsNullOrEmpty(plainText))
			{
				return;
			}

			// put plain text on the clipboard
			Clipboard.SetText(plainText, TextDataFormat.UnicodeText);
		}

		/// <summary>
		/// When the hotkey combo is pressed do the following:
		/// 1. Make the data plain text and put it on the clipboard
		/// 2. Send CTRL+V to Paste in the current foreground application
		/// </summary>
		/// <param name="sender">the sending object</param>
		/// <param name="e">the event of which key was pressed</param>
		private void Hotkey_KeyPressed(object sender, KeyPressedEventArgs e)
		{
			// get the text and exit if no text on clipboard
			string plainText = Clipboard.GetText(TextDataFormat.UnicodeText);
			if (string.IsNullOrEmpty(plainText))
			{
				return;
			}

			// put plain text on the clipboard
			Clipboard.SetText(plainText, TextDataFormat.UnicodeText);

			if (Preferences.Instance.PasteIntoActiveWindow)
			{
				// send CTRL+V for Paste to the active window or control
				_inputSimulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_V);
			}

			// play a sound if the user wants to on every paste
			if (Preferences.Instance.PlaySound)
			{
				SystemSounds.Asterisk.Play();
			}
		}

		private void PlainHotKey_KeyPressed(object sender, KeyPressedEventArgs e)
		{
			CleanText cleanText = new CleanText();

			// get the text and exit if no text on clipboard
			string plainText = Clipboard.GetText();
			if (string.IsNullOrEmpty(plainText))
			{
				return;
			}

			// put plain text on the clipboard
			Clipboard.SetText(cleanText.ToPlain(plainText));

			if (Preferences.Instance.PasteIntoActiveWindow)
			{
				// send CTRL+V for Paste to the active window or control
				_inputSimulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_V);
			}

			// play a sound if the user wa nts to on every paste
			if (Preferences.Instance.PlaySound)
			{
				SystemSounds.Asterisk.Play();
			}
		}

		private void HtmlHotKey_KeyPressed(object sender, KeyPressedEventArgs e)
		{
			CleanText cleanText = new CleanText();

			// get the text and exit if no text on clipboard
			string htmlText = Clipboard.GetText();
			if (string.IsNullOrEmpty(htmlText))
			{
				return;
			}

			// put plain text on the clipboard
			Clipboard.SetText(cleanText.ToHtml(htmlText));

			if (Preferences.Instance.PasteIntoActiveWindow)
			{
				// send CTRL+V for Paste to the active window or control
				_inputSimulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_V);
			}

			// play a sound if the user wa nts to on every paste
			if (Preferences.Instance.PlaySound)
			{
				SystemSounds.Asterisk.Play();
			}
		}
		#endregion
	}
}
