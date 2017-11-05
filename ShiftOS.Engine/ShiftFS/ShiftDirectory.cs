using System.Collections.ObjectModel;
using System.IO;
using System.Linq;

namespace ShiftOS.Engine.ShiftFS
{
	public class ShiftDirectory : ShiftFsObject
	{
		public ShiftDirectory(string path) : base(path)
		{
			path = path.Replace(ShiftFs.SavePath, "");
			var dir = new DirectoryInfo(Path.Combine(ShiftFs.SavePath, path));
			Name = dir.Name;
			FullDiskName = dir.FullName;
			FullName = path;

			Children.CollectionChanged += (sender, e) => { };
		}

		public ShiftFsObject this[string name] => Children.First(f => f.Name == name);
		public ShiftFsObject this[int index] => Children[index];

		public new ShiftDirectory Parent => new ShiftDirectory(new DirectoryInfo(FullDiskName).Parent.FullName);

		public ObservableCollection<ShiftFsObject> Children
		{
			get
			{
				var collection = new ObservableCollection<ShiftFsObject>();

				foreach (var dir in new DirectoryInfo(Path.Combine(ShiftFs.SavePath, FullName)).EnumerateDirectories())
				{
					collection.Add(new ShiftDirectory(dir.FullName));
				}

				foreach (var file in new DirectoryInfo(Path.Combine(ShiftFs.SavePath, FullName)).EnumerateFiles())
				{
					collection.Add(new ShiftFile(file.FullName.Replace(ShiftFs.SavePath, "")));
				}

				return collection;
			}
		}

		public ObservableCollection<ShiftFile> Files => new ObservableCollection<ShiftFile>(Children.OfType<ShiftFile>());

		public ObservableCollection<ShiftDirectory> Directories
			=> new ObservableCollection<ShiftDirectory>(Children.OfType<ShiftDirectory>());
	}
}