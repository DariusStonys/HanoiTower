namespace HanoiTower.Model
{
	public class Disk : IDisk
	{
		public readonly int Size;

		public Disk(int size)
		{
			Size = size;
		}
	}
}