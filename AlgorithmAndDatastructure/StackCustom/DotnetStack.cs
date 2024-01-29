using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmAndDatastructure.StackCustom
{
	public class DotnetStack
	{
		public DotnetStack()
		{
		}

		public static void PrintStack()
		{
            Stack<int> stack = new Stack<int>();
            stack.Pop();
            stack.Pop();

        }

		public static string ReverseString(string str) {
			if (str == null) throw new NullReferenceException();

			Stack<char> strStack = new Stack<char>(str.Length);
			StringBuilder res = new StringBuilder(str.Length);
			foreach (var c in str)
			{
				strStack.Push(c);
			}

			while(strStack.Count > 0)
			{
				res.Append(strStack.Pop());
            }

			return res.ToString();
		}

		public static bool BalancedExpression(string str)
		{
			Stack<char> expr = new Stack<char>();

			foreach (var c in str)
			{
				if( (c == '(') || (c == '{') || (c == '[') || (c == '<'))
				{
					expr.Push(c);
				} else
				{
					if (expr.Count == 0) return false;

					var r = GetReversedChar(c);
					if(r == expr.Peek())
					{
						expr.Pop();
					}
				}
			}

			return expr.Count == 0;
		}


		public static char GetReversedChar(char c)
		{
			return c switch
			{
				')' => '(',
				'>' => '<',
				'}' => '{',
				']' => '[',
				_ => default
            };
		}
	}
}

