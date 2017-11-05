using System;
using System.Collections.ObjectModel;
using System.IO;

namespace ShiftOS.Engine.ShiftFS
{
	public static class ShiftFs
	{
		internal static readonly string SavePath = Path.Combine(Environment.CurrentDirectory, "Save") + "\\";

		public static ObservableCollection<ShiftDrive> Drives = new ObservableCollection<ShiftDrive>();

		static ShiftFs()
		{
			if (Directory.Exists(SavePath))
			{
				var info = new DirectoryInfo(SavePath);
				foreach (var dir in info.EnumerateDirectories())
				{
					Drives.Add(new ShiftDrive(dir));
				}
			}
			else
			{
				CreateSaveFile();
			}
		}

		public static void CreateSaveFile()
		{
			throw new NotImplementedException();
		}
	}
}