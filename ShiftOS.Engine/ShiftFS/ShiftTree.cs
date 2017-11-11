using System;
using System.Collections.Generic;
using Whoa;

namespace ShiftOS.Engine.ShiftFS
{
	[Serializable]
	public class ShiftTree : ShiftDirectory, IShiftNode
	{
		public ShiftTree(string name, char letter) : base(name)
		{
			Name = name;
			Letter = letter;
		}

		
		public new IEnumerable<ShiftFile> Flatten()
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

		public new IEnumerable<ShiftDirectory> FlattenFolders()
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

		
		public new string Name { get; set; }

		
		public char Letter { get; }

		public new string FullName => $@"{Name}:\";

		public new ShiftDirectory Parent
		{
			get => null;
			set => throw new InvalidOperationException("Cannot set parent of ShiftTree");
		}

		public new ShiftTree Drive => this;
	}
}