using HanoiTower.HelperMethods;

namespace HanoiTower.Model
{
	public class Tower : ITower
	{
		public readonly Peg[] Pegs = new Peg[3];

		public Tower(Peg peg1, Peg peg2, Peg peg3)
		{
			Pegs[0] = peg1;
			Pegs[1] = peg2;
			Pegs[2] = peg3;
		}

		public static void MoveDisk(Peg fromPeg, Peg toPeg)
		{
			int fromTopIndex = fromPeg.GetTopNonEmptyRowIndex();
			int toTopIndex = toPeg.GetTopEmptyRowIndex();

			if (!MovementValidator.MovementIsValid(fromPeg, toPeg, fromTopIndex, toTopIndex)) return;

			SwitchRows(fromPeg, toPeg, fromTopIndex, toTopIndex);
		}

		private static void SwitchRows(Peg fromPeg, Peg toPeg, int fromTopIndex, int toTopIndex)
		{
			toPeg.Rows[toTopIndex] = fromPeg.Rows[fromTopIndex];
			fromPeg.Rows[fromTopIndex] = new Row();
		}
	}
}