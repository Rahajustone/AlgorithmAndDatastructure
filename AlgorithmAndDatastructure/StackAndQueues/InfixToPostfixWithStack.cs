using System;
using System.Collections;
using System.Collections.Generic;

namespace AlgorithmAndDatastructure.StackAndQueues
{
    public class InfixToPostfixWithStack
    {
        public InfixToPostfixWithStack()
        {
        }

        // precedence of a given operator
        static int PrecidenceOfOperator(char op)
        {
            switch (op)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                case '^':
                    return 3;
            }

            return -1;
        }


        /** 
         * a+b*c+d
         * Priority ^=3 * /=2 -+=1
         *  Symbol Stack Postfix
         *  a               a
         *  +       +       a
         *  b               ab
         *  *       +*  
         *  c               abc
         *  +       +     abc*+
         *  d       +      abc*+d  
         *                 abc*+d+     
            

        **/

        // TODO
        // Take an infix expression change it to postfix
        public string InfixToPostfix(string exp)
        {
            string res = "";

            Stack<char> characters = new Stack<char>();

            foreach (var ch in exp)
            {
                // If char is letter or number not character  = +-*/^
                if (char.IsLetterOrDigit(ch))
                {
                    res += ch;
                } else if(ch == '(') // if you encounter this just push it to stack
                {
                    characters.Push(ch);
                } else if (ch == ')') // if you counter ')' pop everything till encounter '(' and push them to result string
                {
                    while(characters.Count > 0 && characters.Pop() != '(')
                    {
                        res += characters.Pop();
                    }

                    if (characters.Count > 0 && characters.Peek() != '(')
                    {
                        return "Invalid Expression";
                    } else
                    {
                        characters.Pop();
                    }
                } else // if operator encountered
                {
                    while ( characters.Count > 0 && PrecidenceOfOperator(characters.Peek()) >= PrecidenceOfOperator(ch))
                    {
                        res += characters.Pop();
                    }

                    characters.Push(ch);
                }
            }

            while (characters.Count > 0)
            {
                res += characters.Pop();
            }


            return res;
        }

        static bool IsOperand(char ch)
        {
            switch (ch)
            {
                case '-':
                case '+':
                case '*':
                case '/':
                    return true;
            }

            return false;
        }

        static string PrefixToInfix(string pre)
        {
            string res = "";
            Stack stack = new Stack(); 

            for (int i = pre.Length-1; i >= 0; i--)
            {
                if ( IsOperand(pre[i]))
                {
                    string op1 = (string)stack.Pop();
                    string op2 = (string)stack.Pop();

                    string temp = "("  + op1 + pre[i] + op2 + ")";

                    stack.Push(temp);
                } else
                {
                    stack.Push(pre[i] + "");
                }
            }

            return (string)stack.Pop();
        }
    }
}
