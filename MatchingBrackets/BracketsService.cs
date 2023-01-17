using System;
namespace MatchingBrackets
{
	public class BracketsService
	{
		public BracketsService()
		{
		}

        public bool CheckMatchingBrackets(string input)
        {
            var stack = new Stack<char>();
            foreach (char c in input)
            {
                if (c == '{')
                    stack.Push(c);
                else if (c == '}')
                {
                    if (stack.Count == 0)
                        return false;
                    if (stack.Pop() != '{')
                        return false;
                }
            }
            return stack.Count == 0;
        }
    }
}

