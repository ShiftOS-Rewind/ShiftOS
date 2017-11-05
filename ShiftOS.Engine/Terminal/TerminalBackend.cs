using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ShiftOS.Engine.Terminal
{
	public static class TerminalBackend
	{
		// The line below gets all the terminal commands in... well... the entire ShiftOS.Engine
		static readonly IEnumerable<TerminalCommand> Instances = from t in Assembly.GetExecutingAssembly().GetTypes()
		                                                       where t.IsSubclassOf(typeof(TerminalCommand)) &&
		                                                             t.GetConstructor(Type.EmptyTypes) != null
		                                                       select (TerminalCommand) Activator.CreateInstance(t);

	    /// <summary>
	    ///     Runs a terminal command.
	    /// </summary>
	    /// <param name="command"></param>
	    /// <returns>Returns all the output from that command.</returns>
	    public static string RunCommand(string command)
		{
			string name;
			try
			{
				name = command.Split(' ')[0];
			}
			catch
			{
				name = command;
			}

			var theParams = new string[command.Split(' ').Length - 1];
			Array.Copy(command.Split(' '), 1, theParams, 0, command.Split(' ').Length - 1);

			foreach (var instance in Instances)
			{
				if (instance.GetName() == name)
				{
					return instance.Run(theParams);
				}
			}

			return "The command cannot be found.";
		}
	}
}