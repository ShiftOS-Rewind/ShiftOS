using System.Runtime.InteropServices;
using System.Text;

namespace ShiftOS.Engine.Misc
{
	/// <summary>
	///     Create a New INI file to store or load data
	/// </summary>
	public class IniFile
	{
		readonly string _path;

		public IniFile(string iniPath) => _path = iniPath;

		[DllImport("kernel32")]
		static extern long WritePrivateProfileString(
			string section,
			string key,
			string val,
			string filePath);

		[DllImport("kernel32")]
		static extern int GetPrivateProfileString(
			string section,
			string key,
			string def,
			StringBuilder retVal,
			int size,
			string filePath);

		public void WriteValue(string section, string key, string value)
		{
			WritePrivateProfileString(section, key, value, _path);
		}

		public string ReadValue(string section, string key)
		{
			var temp = new StringBuilder(255);
			GetPrivateProfileString(
				section,
				key,
				"",
				temp,
				255,
				_path);

			return temp.ToString();
		}
	}
}