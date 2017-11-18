namespace ShiftOS.Engine.Terminal.Commands
{
	public class Hello : TerminalCommand
	{
		public override string GetName() => "Hello";

		public override string Run(params string[] parameters) => "Oh, HELLO, " + string.Join(" ", parameters);
	}
}