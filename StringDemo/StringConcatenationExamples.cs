using System;
using System.Diagnostics;
using System.Text;

namespace StringDemo
{
	public class StringConcatenationExamples
	{
		private static readonly string _foo = "Morning!";
		private static readonly string _bar = "Nice day for fishing, ain't it?";
		private static readonly string _result = "Morning! Nice day for fishing, ain't it?";
		private readonly string[] _foobar = { _foo, _bar };
		private static readonly string _assertFailedMessage = "Not equal!";

		public void CheckResult()
		{
			Debug.Assert(_result.Equals(Plus(_foo, _bar)), _assertFailedMessage);
			Debug.Assert(_result.Equals(PlusEquals(_foo, " ", _bar)), _assertFailedMessage);
			Debug.Assert(_result.Equals(Format(_foo, _bar)), _assertFailedMessage);
			Debug.Assert(_result.Equals(Concat(_foo, _bar)), _assertFailedMessage);
			Debug.Assert(_result.Equals(Join(_foo, _bar)), _assertFailedMessage);
			Debug.Assert(_result.Equals(StringBuilder(_foo, _bar)), _assertFailedMessage);
		}

		// Example 1: + Operator
		public string Plus(params string[] values)
		{
			return _foo + " " + _bar;
		}

		// Example 2: += Operator
		public string PlusEquals(params string[] values)
		{
			string plusEqualsResult = String.Empty;

			for (var index = 0; index < values.Length; index++)
			{
				plusEqualsResult += values[index];
			}

			return plusEqualsResult;
		}

		// Example 3: String.Format()
		public string Format(params string[] values)
		{
			return String.Format("{0} {1}", _foo, _bar);
		}

		// Example 4: String.Concatenate() with values
		public string Concat(params string[] values)
		{
			return String.Concat(_foo, " ", _bar);
		}

		// Example 5: Interpolation (C# 6 feature)
		public string Interpolation(params string[] values)
		{
			return $"{_foo} {_bar}";
		}

		//Example 6: String.Join()
		public string Join(params string[] values)
		{
			return String.Join(" ", _foobar);
		}

		//Example 7: StringBuilder.Append()
		public string StringBuilder(params string[] values)
		{
			StringBuilder stringBuilder = new StringBuilder();

			stringBuilder.Append(_foo);
			stringBuilder.Append(" ");
			stringBuilder.Append(_bar);

			return stringBuilder.ToString();
		}
	}
}
