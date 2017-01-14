namespace FizzyBuzz
{
	public class Number
	{
		public Number(int intitialize)
		{
			_value = intitialize;
		}

		public static Number operator ++(Number number)
		{
			Number retVal = new Number(number.Value + 1);
			return retVal;
		}

		public static bool operator <=(Number number1, int number2)
		{
			return number1.Value <= number2;
		}

		public static bool operator >=(Number number1, int number2)
		{
			return number1.Value >= number2;
		}

		public static explicit operator int(Number number)
		{
			return number.Value;
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
