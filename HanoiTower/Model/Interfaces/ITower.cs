namespace HanoiTower.Model
{
	public interface ITower
	{
		public static void MoveDisk(Peg fromPeg, Peg toPeg) => Console.WriteLine("Must override");
		public static void SwitchRows(Peg fromPeg, Peg toPeg, int fromTopIndex, int toTopIndex) => Console.WriteLine("Must override");
	}
}