using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using Whoa;

namespace ShiftOS.Engine.ShiftFS
{
	[Serializable]
	public class ShiftFile<T> : ShiftFile
	{
		public ShiftFile(string name) => Name = name;
		public ShiftFile(string name, ShiftDirectory directory)
		{
			Name = name;
			Parent = directory;
		}
		public ShiftFile(string name, T @object, ShiftDirectory directory)
		{
			Name = name;
			Object = @object;
			Parent = directory;
		}
		public ShiftFile(string name, T @object, ShiftDirectory directory, Bitmap icon)
		{
			Name = name;
			Object = @object;
			Parent = directory;
			Icon = icon;
		}
		public ShiftFile(string name, T @object)
		{
			Name = name;
			Object = @object;
		}
		public ShiftFile(string name, T @object, Bitmap icon)
		{
			Name = name;
			Object = @object;
			Icon = icon;
		}



		public T Object { get; set; }
	}

	[Serializable]
	public abstract class ShiftFile : IShiftNode 
	{
		public Bitmap Icon { get; set; }

		public string Name { get; set; }

		public string FullName
		{
			get
			{
				var list = new List<string> { Name };
				var currentNode = Parent;
				while (currentNode?.Parent != null)
				{
					list.Add(currentNode.Name);
					currentNode = currentNode.Parent;
				}

				return Path.Combine(list.Reverse<string>().ToArray()) + "\\";
			}
		}
		
		public ShiftDirectory Parent
		{
			get => Drive.FlattenFolders().FirstOrDefault(x => x.Contains(this));
			set
			{
				value.Add(this);
				Parent?.Remove(this);
			}
		}

		public ShiftTree Drive => ShiftFS.Drives.First(d => d.FlattenFolders().FirstOrDefault(f => f.Contains(this)) != null);

		
		public Guid Guid { get; } = Guid.NewGuid();
		
	}
}