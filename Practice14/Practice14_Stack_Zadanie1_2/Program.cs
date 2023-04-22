using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Practice14_Stack_Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Stack()
            {
                Console.WriteLine("Введите какое задание выполнить(1, 2)");
                string zadanie = Console.ReadLine().ToUpper();
                switch (zadanie)
                {
                    case "1":
                        Console.Write("Введите число n: ");
                        int n = 0;
                        while (true)
                        {
                            try
                            {
                                n = int.Parse(Console.ReadLine());
                                if (n <= 1)
                                {
                                    Console.WriteLine("Повторите ввод: ");
                                }
                                else
                                    break;

                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Повторите ввод: ");
                            }
                        }
                        Stack myStack = new Stack();
                        for (int i = 1; i <= n; i++)
                        {
                            myStack.Push(i);
                        }
                        Console.WriteLine($"\nn = {n}");
                        Console.WriteLine($"Размерность стека: {myStack.Count}");
                        Console.WriteLine($"Верхний элемент стека: {myStack.Peek()}");
                        Console.Write("Содержимое стека: ");
                        while (myStack.Count > 0)
                        {
                            Console.Write($" {myStack.Pop()}");
                        }
                        Console.WriteLine($"\nНовая размерность стека: {myStack.Count}");
                        break;
                    case "2":
                        Console.WriteLine("Введите математическое выражение:");
                        string expression = Console.ReadLine();

                        int openBracketCount = expression.Count(c => c == '(');
                        int closeBracketCount = expression.Count(c => c == ')');
                        int bracketsBalance = openBracketCount - closeBracketCount;
                        if (bracketsBalance == 0)
                        {
                            Console.WriteLine("Скобки сбалансированы");
                        }
                        else if (bracketsBalance < 0)
                        {
                            Console.WriteLine($"Недостаточно {Math.Abs(bracketsBalance)} закрывающих скобок");
                        }
                        else
                        {
                            Console.WriteLine($"Недостаточно {bracketsBalance} открывающих скобок");
                        }

                        if (bracketsBalance > 0)
                        {
                            expression += new string(')', bracketsBalance);
                            Console.WriteLine($"Для скобки в позиции {bracketsBalance} не хватало закрывающейся скобки. Добавлено закрывающих скобок: {expression}");
                        }
                        else if (bracketsBalance < 0)
                        {
                            expression = expression.Remove(expression.Length + bracketsBalance, Math.Abs(bracketsBalance));
                            Console.WriteLine($"Удалено {Math.Abs(bracketsBalance)} лишних закрывающих скобок: {expression}");
                        }

                        int lastOpenBracketIndex = expression.LastIndexOf('(');
                        if (lastOpenBracketIndex != -1)
                        {
                            bool hasOperatorAfterLastOpenBracket = false;
                            for (int i = lastOpenBracketIndex + 1; i < expression.Length; i++)
                            {
                                if (IsOperator(expression[i]))
                                {
                                    hasOperatorAfterLastOpenBracket = true;
                                    break;
                                }
                            }

                            if (!hasOperatorAfterLastOpenBracket)
                            {
                                expression = expression.Remove(lastOpenBracketIndex, 1);
                                Console.WriteLine($"Удалена последняя открывающая скобка: {expression}");
                            }
                        }

                        if (expression.StartsWith(")"))
                        {
                            expression = expression.Remove(0, 1);
                            Console.WriteLine($"Удалена первая закрывающая скобка: {expression}");
                        }

                        File.WriteAllText("t1.txt", expression);
                        Console.WriteLine($"Выражение записано в файл t1.txt: {expression}");
                        break;

                    default:
                        Console.WriteLine("Можно выбрать только из списка");
                        break;
                }

            }
            static bool IsOperator(char c)
            {
                return c == '+' || c == '-' || c == '*' || c == '/';
            }
            Stack();
        }
    }
            
}
    

