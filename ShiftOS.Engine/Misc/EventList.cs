using System;
using System.Collections.Generic;
using System.Linq;

namespace ShiftOS.Engine.Misc
{
	[Serializable]
	public class EventList<T> : List<T>
	{
		public event EventHandler<EventListArgs<T>> ItemAdded;
		public event EventHandler<EventListArgs<T>> ItemRemoved;

		public new void Add(T obj)
		{
			base.Add(obj);
			ItemAdded?.Invoke(this, new EventListArgs<T>(obj));
		}

		public new void AddRange(IEnumerable<T> objs)
		{
			foreach (var obj in objs)
			{
				base.Add(obj);
				ItemAdded?.Invoke(this, new EventListArgs<T>(obj));
			}
		}

		public new bool Remove(T obj)
		{
			var b = base.Remove(obj);

			ItemRemoved?.Invoke(this, new EventListArgs<T>(obj));
			return b;
		}

		public new void RemoveAt(int index)
		{
			base.RemoveAt(index);
			ItemRemoved?.Invoke(this, new EventListArgs<T>(default));
		}

		public new void RemoveAll(Predicate<T> match)
		{
			//will this work
			foreach (var item in this.Where(match as Func<T, bool> ?? throw new InvalidOperationException()))
			{
				Remove(item);
			}
		}

		public new void RemoveRange(int start, int end)
		{
			for (var i = start; i <= end; i++)
			{
				Remove(this[i]);
			}
		}

		public new void Clear()
		{
			RemoveAll(x => true);
		}
	}

	public class EventListArgs<T> : EventArgs
	{
		public EventListArgs(T item) => Item = item;

		public T Item { get; }
	}
}
