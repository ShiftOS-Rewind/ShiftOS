using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ShiftOS.Engine.ShiftFS
{
	public class ShiftFile : ShiftFsObject
	{
		public ShiftFile(string path) : base(path)
		{
			path = path.Replace(ShiftFs.SavePath, "");

			using (var fs = new FileStream(Path.Combine(ShiftFs.SavePath, path), FileMode.Open))
			{
				Bytes = new MemoryStream();
				fs.CopyTo(Bytes);
			}

			var file = new FileInfo(Path.Combine(ShiftFs.SavePath, path));

			Name = file.Name;
			FullDiskName = file.FullName;
			FullName = path;
		}

		public new ShiftDirectory Parent => new ShiftDirectory(new FileInfo(FullDiskName).Directory.FullName);

		public MemoryStream Bytes { get; set; }
		public long Length => Bytes.Length;
	}

	public class ShiftFile<T> : ShiftFile // please C# gods let us constrain to attributes
	{
		public ShiftFile(string path) : base(path)
		{
			if (!typeof(T).IsSerializable)
			{
				throw new InvalidOperationException("Non-serializable types are not supported");
			}
		}

		public T Object
		{
			get => (T) new BinaryFormatter().Deserialize(Bytes);
			set => new BinaryFormatter().Serialize(Bytes, value);
		}
	}
}