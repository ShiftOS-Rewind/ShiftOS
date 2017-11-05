namespace ShiftOS.Engine.Terminal
{
	public abstract class TerminalCommand
	{
		public abstract string GetName();

		public abstract string Run(params string[] parameters);
	}
}