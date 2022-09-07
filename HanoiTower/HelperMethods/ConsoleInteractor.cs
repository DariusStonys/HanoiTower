using HanoiTower.Model;

namespace HanoiTower.HelperMethods
{
	public static class ConsoleInteractor
	{
		public static void ReadConsole(Tower tower)
		{
			int fromPeg = Convert.ToInt32(Console.ReadLine());
			int toPeg = Convert.ToInt32(Console.ReadLine());

			Tower.MoveDisk(tower.Pegs[fromPeg], tower.Pegs[toPeg]);

			Console.ReadLine();
		}
	}
}