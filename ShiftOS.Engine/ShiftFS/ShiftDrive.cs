using System.IO;
using ShiftOS.Engine.Misc;

namespace ShiftOS.Engine.ShiftFS
{
	public class ShiftDrive
	{
		internal ShiftDrive(DirectoryInfo dir)
		{
			Label = dir.Name;
			var file = new IniFile(Path.Combine(dir.FullName, "driveinfo.ini"));
			Letter = char.TryParse(file.ReadValue("", "DriveLetter"), out var letter) ? letter : '?';
			Contents = new ShiftDirectory(dir.FullName);
		}

		public string Label { get; }
		public char Letter { get; }
		public ShiftDirectory Contents { get; }
	}
}