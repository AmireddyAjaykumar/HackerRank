using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class BalancedBrackets
    {
        static string isBalanced(string s)
        {
            //Stack<char> stack = new Stack<char>();
            //for (int i = 0; i < s.Length; i++)
            //{
            //    switch (s[i])
            //    {
            //        case '[':
            //        case '(':
            //        case '{':
            //            stack.Push(s[i]);
            //            break;
            //        case '}':
            //            if(stack.Count == 0 || stack.Peek() == '{')
            //            {
            //                return "NO";
            //            }
            //            stack.Pop();
            //            break;
            //        case ']':
            //            if (stack.Count == 0 || stack.Peek() == '[')
            //            {
            //                return "NO";
            //            }
            //            stack.Pop();
            //            break;
            //        case ')':
            //            if (stack.Count == 0 || stack.Peek() == '(')
            //            {
            //                return "NO";
            //            }
            //            stack.Pop();
            //            break;
            //    }
            //}
            if (s.Length % 2 == 1) return "NO";
            Char[] bc = s.ToCharArray();
            int[] b = new int[bc.Length];
            for (int i = 0; i < b.Length; i++) b[i] = Convert.ToInt32(bc[i]);
            Stack<int> stack = new Stack<int>();
            int c;
            for (int i = 0; i < s.Length; i++)
            {
                if (stack.Count == 0)
                {
                    if (s[i] == 125 || s[i] == 93 || s[i] == 41) return "NO";
                    stack.Push(s[i]);
                    continue;
                }
                c = stack.Peek();
                switch (s[i])
                {
                    case '}':
                    case ']':
                        if (c != s[i] - 2) return "NO";
                        stack.Pop();
                        break;
                    case ')':
                        if (c != 40) return "NO";
                        stack.Pop();
                        break;
                    default: stack.Push(s[i]); break;
                }
            }
            return (stack.Count > 0) ? "NO" : "YES";
        }

        public static void Execute()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int tItr = 0; tItr < t; tItr++)
            {
                string s = Console.ReadLine();
                string result = isBalanced(s);
                Console.WriteLine(result);
            }
        }
    }
}
