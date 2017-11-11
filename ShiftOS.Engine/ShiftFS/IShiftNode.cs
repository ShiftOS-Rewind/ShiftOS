using System;
using Whoa;

namespace ShiftOS.Engine.ShiftFS
{
	public interface IShiftNode
	{
		
		string Name { get; set; }

		
		string FullName { get; }

		
		ShiftDirectory Parent { get; set; }

		
		ShiftTree Drive { get; }

		
		Guid Guid { get; }
	}
}