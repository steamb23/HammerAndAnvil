using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static partial class ConsoleEx
    {
        public static class Selector
        {
            public struct SelectElement
            {
                public SelectElement(ConsoleKey key, Action action)
                {
                    this.key = key;
                    this.action = action;
                }
                public ConsoleKey key;
                public Action action;
                public void Action()
                {
                    if (action != null)
                    {
                        action();
                    }
                }
            }
            static List<SelectElement> selectList = new List<SelectElement>();
            static bool isHaveEnterKey;
            public static void Add(ConsoleKey key, string text, Action action)
            {
                Console.Write(" ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(ConsoleKeyToString(key));
                Console.ResetColor();
                Console.WriteLine("){0}", text);
                selectList.Add(new SelectElement(key, action));
                if (key == ConsoleKey.Enter)
                    isHaveEnterKey = true;
            }
            public static void Add(char key, string text, Action action)
            {
                Add(charToConsoleKey_Table[key], text, action);
            }
            public static void Read(ConsoleKey defaultKey)
            {
                bool pass = false;
                SelectElement selectedElement = new SelectElement();
                while (!pass)
                {
                    ConsoleKey key = Console.ReadKey(true).Key;
                    key = (!isHaveEnterKey && key != ConsoleKey.Enter) ? key : defaultKey;
                    foreach (var selectElement in selectList)
                    {
                        if (key == selectElement.key)
                        {
                            pass = true;
                            selectedElement = selectElement;
                            break;
                        }
                    }
                }
                Clear();
                selectedElement.Action();
            }

            internal static void Read(char defaultKey)
            {
                Read(charToConsoleKey_Table[defaultKey]);
            }

            public static void Read()
            {
                Read(ConsoleKey.Enter);
            }
            public static void Clear()
            {
                for (int i = selectList.Count; i > 0; i--)
                {
                    CursorUp();
                    ClearLine();
                }
                selectList.Clear();
                isHaveEnterKey = false;
            }
            public static string ConsoleKeyToString(ConsoleKey key)
            {
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        return "↑";
                    case ConsoleKey.DownArrow:
                        return "↓";
                    case ConsoleKey.RightArrow:
                        return "→";
                    case ConsoleKey.LeftArrow:
                        return "←";
                    case ConsoleKey.D1:
                        return "1";
                    case ConsoleKey.D2:
                        return "2";
                    case ConsoleKey.D3:
                        return "3";
                    case ConsoleKey.D4:
                        return "4";
                    case ConsoleKey.D5:
                        return "5";
                    case ConsoleKey.D6:
                        return "6";
                    case ConsoleKey.D7:
                        return "7";
                    case ConsoleKey.D8:
                        return "8";
                    case ConsoleKey.D9:
                        return "9";
                    case ConsoleKey.D0:
                        return "0";
                    default:
                        return key.ToString();
                }
            }
            public static Dictionary<char, ConsoleKey> charToConsoleKey_Table = new Dictionary<char, ConsoleKey>
            {
                {'1',ConsoleKey.D1 },
                {'2',ConsoleKey.D2 },
                {'3',ConsoleKey.D3 },
                {'4',ConsoleKey.D4 },
                {'5',ConsoleKey.D5 },
                {'6',ConsoleKey.D6 },
                {'7',ConsoleKey.D7 },
                {'8',ConsoleKey.D8 },
                {'9',ConsoleKey.D9 },
                {'0',ConsoleKey.D0 },
                {'q',ConsoleKey.Q },
                {'w',ConsoleKey.W },
                {'e',ConsoleKey.E },
                {'r',ConsoleKey.R },
                {'t',ConsoleKey.T },
                {'y',ConsoleKey.Y },
                {'u',ConsoleKey.U },
                {'i',ConsoleKey.I },
                {'o',ConsoleKey.O },
                {'p',ConsoleKey.P },
                {'a',ConsoleKey.A },
                {'s',ConsoleKey.S },
                {'d',ConsoleKey.D },
                {'f',ConsoleKey.F },
                {'g',ConsoleKey.G },
                {'h',ConsoleKey.H },
                {'j',ConsoleKey.J },
                {'k',ConsoleKey.K },
                {'l',ConsoleKey.L },
                {'z',ConsoleKey.Z },
                {'x',ConsoleKey.X },
                {'c',ConsoleKey.C },
                {'v',ConsoleKey.V },
                {'b',ConsoleKey.B },
                {'n',ConsoleKey.N },
                {'m',ConsoleKey.M },
                {'Q',ConsoleKey.Q },
                {'W',ConsoleKey.W },
                {'E',ConsoleKey.E },
                {'R',ConsoleKey.R },
                {'T',ConsoleKey.T },
                {'Y',ConsoleKey.Y },
                {'U',ConsoleKey.U },
                {'I',ConsoleKey.I },
                {'O',ConsoleKey.O },
                {'P',ConsoleKey.P },
                {'A',ConsoleKey.A },
                {'S',ConsoleKey.S },
                {'D',ConsoleKey.D },
                {'F',ConsoleKey.F },
                {'G',ConsoleKey.G },
                {'H',ConsoleKey.H },
                {'J',ConsoleKey.J },
                {'K',ConsoleKey.K },
                {'L',ConsoleKey.L },
                {'Z',ConsoleKey.Z },
                {'X',ConsoleKey.X },
                {'C',ConsoleKey.C },
                {'V',ConsoleKey.V },
                {'B',ConsoleKey.B },
                {'N',ConsoleKey.N },
                {'M',ConsoleKey.M }
            };
        }
    }
}
