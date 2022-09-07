using HanoiTower.Model;

namespace HanoiTower.HelperMethods
{
	public static class MovementValidator
	{
		public static bool MovementIsValid(Peg fromPeg, Peg toPeg, int fromTopIndex, int toTopIndex)
		{
			int fromPegSizeOfUnderTopDisk = GetSizeOfDiskUnderTop(fromPeg, fromTopIndex);
			int fromPegSizeOfTopDisk = fromPeg.Rows[fromTopIndex].Disk.Size;

			int toPegSizeOfUnderTopDisk = GetSizeOfDiskUnderTop(toPeg, toTopIndex);
			int toPegSizeOfTopDisk = toPeg.Rows[toTopIndex].Disk.Size;

			return fromPegSizeOfUnderTopDisk >= fromPegSizeOfTopDisk && toPegSizeOfUnderTopDisk >= toPegSizeOfTopDisk;
		}

		private static int GetSizeOfDiskUnderTop(Peg peg, int topIndex)
		{
			if (topIndex < 3) return peg.Rows[topIndex + 1].Disk.Size;

			return int.MaxValue;
		}
	}
}
