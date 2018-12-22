using System.Collections.Generic;
using System.Text;

namespace PureTextPlus
{
	public class CleanText
	{
		private static Dictionary<char, string> _plainTranslations = null;
		private static Dictionary<char, string> _htmlTranslations = null;

		public CleanText()
		{
			if (_plainTranslations != null && _htmlTranslations != null)
			{
				return;
			}

			// Initialize lookup dictionaries
			_plainTranslations = new Dictionary<char, string>
			{
				{ '\n', "\r\n" },   //CR -> CR/LF (\r will be dropped)
				{ '“', "\"" },
				{ '”', "\"" },
				{ '–', "-" },       // en-dash
				{ '—', "-" },       // em-dash
				{ '‘', "'" },
				{ '’', "'" },
				{ '«', "<<" },
				{ '»', ">>" },
				{ ' ', " " },       // alt-0160 non-breaking space character replaced with normal space  (source: hex character code A0)
				{ '¢', "cents" },
				{ '©', "(C)" },
				{ '®', "(R)" },
				{ '™', "(TM)" },
				{ '÷', "/" },
				{ 'µ', "u" },
				{ '·', " " },       // mid-dot replace with space
				{ '±', "+-" }
			};

			string literalPlainChars = " \t&~!@#$%^*()[]{}_-+=;:'\"/?\\|,.<>¶€£§¥áÁàÀâÂåÅãÃäÄæÆçÇéÉèÈêÊëËíÍìÌîÎïÏñÑóÓòÒôÔøØõÕöÖßúÚùÙûÛüÜÿ¡¿";

			foreach (char ch in literalPlainChars)
			{
				_plainTranslations.Add(ch, ch.ToString());
			}


			_htmlTranslations = new Dictionary<char, string>
			{
				{ '\n', "\r\n" },    //CR -> CR/LF (\r will be dropped)
				{ '–', "&ndash;" },
				{ '—', "&mdash;" },
				{ '¡', "&iexcl;" },
				{ '¿', "&iquest;" },
				{ '“', "&ldquo;" },
				{ '”', "&rdquo;" },
				{ '‘', "&lsquo;" },
				{ '’', "&rsquo;" },
				{ '«', "&laquo;" },
				{ '»', "&raquo;" },
				{ ' ', "&nbsp;" },       // alt-0160
				{ '&', "&amp;" },
				{ '¢', "&cent;" },
				{ '©', "&copy;" },
				{ '÷', "&divide;" },
				{ '>', "&gt;" },
				{ '<', "&lt;" },
				{ 'µ', "&micro;" },
				{ '·', "&middot;" },
				{ '¶', "&para;" },
				{ '±', "&plusmn;" },
				{ '€', "&euro;" },
				{ '£', "&pound;" },
				{ '®', "&reg;" },
				{ '§', "&sect;" },
				{ '™', "&trade;" },
				{ '¥', "&yen;" },
				{ 'á', "&aacute;" },
				{ 'à', "&agrave;" },
				{ 'â', "&acirc;" },
				{ 'å', "&aring;" },
				{ 'ã', "&atilde;" },
				{ 'ä', "&auml;" },
				{ 'æ', "&aelig;" },
				{ 'ç', "&ccedil;" },
				{ 'é', "&eacute;" },
				{ 'è', "&egrave;" },
				{ 'ê', "&ecirc;" },
				{ 'ë', "&euml;" },
				{ 'í', "&iacute;" },
				{ 'ì', "&igrave;" },
				{ 'î', "&icirc;" },
				{ 'ï', "&iuml;" },
				{ 'ñ', "&ntilde;" },
				{ 'ó', "&oacute;" },
				{ 'ò', "&ograve;" },
				{ 'ô', "&ocirc;" },
				{ 'ø', "&oslash;" },
				{ 'õ', "&otilde;" },
				{ 'ö', "&ouml;" },
				{ 'ú', "&uacute;" },
				{ 'ù', "&ugrave;" },
				{ 'û', "&ucirc;" },
				{ 'ü', "&uuml;" },
				{ 'Á', "&Aacute;" },
				{ 'À', "&Agrave;" },
				{ 'Â', "&Acirc;" },
				{ 'Å', "&Aring;" },
				{ 'Ã', "&Atilde;" },
				{ 'Ä', "&Auml;" },
				{ 'Æ', "&AElig;" },
				{ 'Ç', "&Ccedil;" },
				{ 'É', "&Eacute;" },
				{ 'È', "&Egrave;" },
				{ 'Ê', "&Ecirc;" },
				{ 'Ë', "&Euml;" },
				{ 'Í', "&Iacute;" },
				{ 'Ì', "&Igrave;" },
				{ 'Î', "&Icirc;" },
				{ 'Ï', "&Iuml;" },
				{ 'Ñ', "&Ntilde;" },
				{ 'Ó', "&Oacute;" },
				{ 'Ò', "&Ograve;" },
				{ 'Ô', "&Ocirc;" },
				{ 'Ø', "&Oslash;" },
				{ 'Õ', "&Otilde;" },
				{ 'Ö', "&Ouml;" },
				{ 'Ú', "&Uacute;" },
				{ 'Ù', "&Ugrave;" },
				{ 'Û', "&Ucirc;" },
				{ 'Ü', "&Uuml;" },
				{ '´', "&#180;" },
				{ '`', "&#96;" },
				{ 'ÿ', "&yuml;" },
				{ 'ß', "&szlig;" }
			};

			string literalHtmlChars = " \t~!@#$%^*()[]{}_-+=;:'\"/?\\|,.";

			foreach (char ch in literalHtmlChars)
			{
				_htmlTranslations.Add(ch, ch.ToString());
			}
		}

		public string ToPlain(char input)
		{
			// Literal ranges
			if ((input >= 'a' && input <= 'z')
				|| (input >= 'A' && input <= 'Z')
				|| (input >= '0' && input <= '9')
				)
			{
				return input.ToString();
			}

			_plainTranslations.TryGetValue(input, out string output);

			return output;
		}

		public string ToPlain(string input)
		{
			StringBuilder output = new StringBuilder();
			foreach (char ch in input)
			{
				string transalated = ToPlain(ch);
				if (transalated != null)
				{
					output.Append(transalated);
				}
			}

			return output.ToString();
		}

		public string ToHtml(char input)
		{
			// Literal ranges
			if ((input >= 'a' && input <= 'z')
				|| (input >= 'A' && input <= 'Z')
				|| (input >= '0' && input <= '9')
				)
			{
				return input.ToString();
			}

			_htmlTranslations.TryGetValue(input, out string output);

			return output;
		}

		public string ToHtml(string input)
		{
			StringBuilder output = new StringBuilder();
			foreach (char ch in input)
			{
				string transalated = ToHtml(ch);
				if (transalated != null)
				{
					output.Append(transalated);
				}
			}

			return output.ToString();
		}
	}
}
