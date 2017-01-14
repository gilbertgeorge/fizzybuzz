namespace FizzyBuzz
{
	public class Number
	{
		public Number(int intitialize)
		{
			_value = intitialize;
		}

		public bool IsMod3()
		{
			return _value % 3 == 0;
		}

		public bool IsMod5()
		{
			return _value % 5 == 0;
		}

		public int Value
		{
			get
			{
				return _value;
			}

			set
			{
				_value = value;
			}
		}

		protected int _value;
	}
}
