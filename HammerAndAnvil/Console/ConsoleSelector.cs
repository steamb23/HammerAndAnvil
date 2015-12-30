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
                public SelectElement(char key, Action action)
                {
                    this.key = key;
                    this.action = action;
                }
                public char key;
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
            public static void Add(char key, string text, Action action)
            {
                key = char.ToUpper(key);

                Console.Write(" ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(key);
                Console.ResetColor();
                Console.WriteLine("){0}", text);
                selectList.Add(new SelectElement(key, action));
            }
            public static void Read(char defaultKey)
            {
                defaultKey = char.ToUpper(defaultKey);
                bool pass = false;
                SelectElement selectedElement = new SelectElement();

                while (!pass)
                {
                    char key = char.ToUpper(Console.ReadKey(true).KeyChar);
                    char kokey = '\0';
                    if (ko_enTable.TryGetValue(key, out kokey))
                        key = kokey;
                    key = (key != '\r') ? key : defaultKey;
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
            public static void Read()
            {
                Read('\0');
            }
            public static void Clear()
            {
                for (int i = selectList.Count; i > 0; i--)
                {
                    CursorUp();
                    ClearLine();
                }
                selectList.Clear();
            }
            //For Korean
            static Dictionary<char, char> ko_enTable = new Dictionary<char, char>
            {
                { 'ㅃ', 'Q'},
                { 'ㅉ', 'W'},
                { 'ㄸ', 'E'},
                { 'ㄲ', 'R'},
                { 'ㅆ', 'T'},
                { 'ㅂ', 'Q'},
                { 'ㅈ', 'W'},
                { 'ㄷ', 'E'},
                { 'ㄱ', 'R'},
                { 'ㅅ', 'T'},
                { 'ㅛ', 'Y'},
                { 'ㅕ', 'U'},
                { 'ㅑ', 'I'},
                { 'ㅐ', 'O'},
                { 'ㅔ', 'P'},
                { 'ㅁ', 'A'},
                { 'ㄴ', 'S'},
                { 'ㅇ', 'D'},
                { 'ㄹ', 'F'},
                { 'ㅎ', 'G'},
                { 'ㅗ', 'H'},
                { 'ㅓ', 'J'},
                { 'ㅏ', 'K'},
                { 'ㅣ', 'L'},
                { 'ㅋ', 'Z'},
                { 'ㅌ', 'X'},
                { 'ㅊ', 'C'},
                { 'ㅍ', 'V'},
                { 'ㅠ', 'B'},
                { 'ㅜ', 'N'},
                { 'ㅡ', 'M'}
            };
        }
    }
}
