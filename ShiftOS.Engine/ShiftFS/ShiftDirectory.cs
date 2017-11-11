using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Whoa;

namespace ShiftOS.Engine.ShiftFS
{
	[Serializable]
	public class ShiftDirectory : List<IShiftNode>, IShiftNode
	{
		public ShiftDirectory(string name) => Name = name;
		public ShiftDirectory(string name, ShiftDirectory parent)
		{
			Name = name;
			Parent = parent;
		}


		public IShiftNode this[string name] => this.First(n => string.Equals(n.Name, name, StringComparison.Ordinal));

		
		public string Name { get; set; }

		public IEnumerable<ShiftFile> Flatten()
		{
			foreach (var item in this)
			{
				switch (item)
				{
					case ShiftFile file:
						yield return file;
						break;
					case ShiftDirectory dir:
						foreach (var shiftNode in dir.Flatten())
						{
							yield return shiftNode;
						}
						break;
				}
			}
		}

		public IEnumerable<ShiftDirectory> FlattenFolders()
		{
			foreach (var item in this)
			{
				if (!(item is ShiftDirectory dir)) continue;
				yield return dir;

				foreach (var subdir in dir.FlattenFolders())
				{
					yield return subdir;
				}
			}
		}
	 
		public string FullName
		{
			get
			{
				var list = new List<string> { Name };
				var currentNode = Parent;
				while (currentNode?.Parent != null )
				{
					list.Add(currentNode.Name);
					currentNode = currentNode.Parent;
				}
				
				return Path.Combine(list.Reverse<string>().ToArray());
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

		public ShiftTree Drive => ShiftFS.Drives.First(d => d.FlattenFolders().Contains(this));

		
		public Guid Guid { get; } = Guid.NewGuid();
	}
}