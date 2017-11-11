using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using ShiftOS.Engine.Misc;

namespace ShiftOS.Engine.ShiftFS
{
	public static class ShiftFS
	{
		static readonly string FilePath = Path.Combine(Environment.CurrentDirectory, "save.bin");

		static readonly FileSystemWatcher _watcher;
		
		static readonly BinaryFormatter _formatter = new BinaryFormatter();
		
		public static EventList<ShiftTree> Drives { get; private set; } = new EventList<ShiftTree>();

		public static void Save()
		{
			using (var fs = File.OpenWrite(FilePath))
			{
				//Whoa.Whoa.SerialiseObject(fs, Drives);
				_formatter.Serialize(fs, Drives);
			}
		}


		static ShiftFS()
		{
			Drives.ItemAdded += (sender, e) => Debug.WriteLine(e.Item.Name + e.Item.Letter);
			
			if (!File.Exists(FilePath))
			{
				using (File.Create(FilePath))
				{
					
					Drives.Add(new ShiftTree("Local Disk", 'C')
					{
						new ShiftDirectory("usr")
						{
							//i'll put in extensions later
							new ShiftFile<string>("stringfile.txt", "THIS IS SECRETEXT")
						},
						new ShiftDirectory("libs")
						{
							new ShiftFile<string>("thing.dll", "oh no it's not code FACH")
						}

					});
				}

				Save();

				MessageBox.Show("Save file created.");
				Debug.WriteLine("Drives: " + Drives.Count);
			}

			WatcherOnChanged(null, null);
			
			_watcher = new FileSystemWatcher(Environment.CurrentDirectory)
			{
				Filter = "save.bin",
			};

			_watcher.Changed += WatcherOnChanged;
		}

		static void WatcherOnChanged(object sender, FileSystemEventArgs e)
		{
			using (var fs = File.OpenRead(FilePath))
			{
				//Drives = Whoa.Whoa.DeserialiseObject<EventList<ShiftTree>>(fs);
				Drives = (EventList<ShiftTree>) _formatter.Deserialize(fs);
			}
		}
	}
}