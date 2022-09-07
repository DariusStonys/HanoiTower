namespace HanoiTower.Model
{
	public class Row : IRow
	{
		public readonly Disk Disk;

		public Row()
		{
			Disk = IDisk.Empty;
		}

		public Row(Disk disk)
		{
			Disk = disk;
		}
	}
}