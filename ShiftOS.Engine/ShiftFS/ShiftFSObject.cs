using System.IO;

namespace ShiftOS.Engine.ShiftFS
{
	public abstract class ShiftFsObject
	{
		protected ShiftFsObject(string path)
		{
			if (!File.Exists(Path.Combine(ShiftFs.SavePath, path)) && !Directory.Exists(Path.Combine(ShiftFs.SavePath, path)))
			{
				throw new FileNotFoundException();
			}
		}

		public string Name { get; set; }
		public ShiftDirectory Parent { get; protected set; }
		public string FullName { get; set; }
		protected string FullDiskName { get; set; }

		public void Delete()
		{
			File.Delete(FullDiskName);
		}
	}
}