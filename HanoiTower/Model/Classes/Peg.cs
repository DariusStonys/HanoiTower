namespace HanoiTower.Model
{
	public class Peg : IPeg
	{
		public readonly Row[] Rows = new Row[4];

		public Peg()
		{
			Rows[0] = new Row();
			Rows[1] = new Row();
			Rows[2] = new Row();
			Rows[3] = new Row();
		}

		public Peg(Row row1, Row row2, Row row3, Row row4)
		{
			Rows[0] = row1;
			Rows[1] = row2;
			Rows[2] = row3;
			Rows[3] = row4;
		}

		public int GetTopNonEmptyRowIndex()
		{
			for (int i = 0; i < Rows.Length; i++)
			{
				if (Rows[i].Disk.Size != 0) return i;
			}

			return 3;
		}
		
		public int GetTopEmptyRowIndex() => GetTopNonEmptyRowIndex() - 1;
	}
}