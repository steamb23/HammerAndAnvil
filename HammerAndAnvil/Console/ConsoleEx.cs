using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SteamB23.KoreanUtility.Grammar;

namespace System
{
    public static partial class ConsoleEx
    {
        public static void SelectElement(char selectChar, string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(selectChar);
            Console.ResetColor();
            Console.WriteLine("){0}", text);
        }
        public static ConsoleKeyInfo Select()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(">");
            Console.ResetColor();
            var result = Console.ReadKey(true);
            ClearLine();
            return result;
        }
        public static void ClearMultipleLines(int lines)
        {
            for (int i = 0; i < lines; i++)
            {
                ConsoleEx.CursorUp();
                ConsoleEx.ClearLine();
            }
        }
        public static string ReadText(bool clear)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(">");
            Console.ResetColor();
            var result = Console.ReadLine();
            if (clear)
            {
                Console.CursorTop--;
                ClearLine();
            }
            return result;
        }
        public static string ReadText()
        {
            return ReadText(true);
        }
        public static void ClearLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', 80));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
        public static void CursorUp()
        {
            Console.CursorTop--;
        }
        public static void ColorChange(string text, int left, ConsoleColor color)
        {
            Console.SetCursorPosition(left, Console.CursorTop);
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();
        }
        public enum Align
        {
            Left,
            Center,
            Right,
        }
        public static void WriteText(string text, int left, int top, Align align, bool isCursorPositionReturn)
        {
            int originLeft = Console.CursorLeft;
            int originTop = Console.CursorTop;

            switch (align)
            {
                case Align.Left:
                    Console.SetCursorPosition(left, top);
                    break;
                case Align.Right:
                    Console.SetCursorPosition(left - ANSIStringToByte(text).Length, top);
                    break;
                case Align.Center:
                    Console.SetCursorPosition(left - (ANSIStringToByte(text).Length / 2), top);
                    break;
            }
            Console.Write(text);
            if (isCursorPositionReturn)
                Console.SetCursorPosition(originLeft, originTop);
        }
        public static void WriteText(string text, int left, int top, Align align)
        {
            WriteText(text, left, top, align, false);
        }
        public static void WriteText(string text, int left, int top)
        {
            WriteText(text, left, top, Align.Left, false);
        }
        public static void WriteText(string text, int left, Align align)
        {
            WriteText(text, left, Console.CursorTop, align, false);
        }
        public static void WriteText(string text, int left)
        {
            WriteText(text, left, Console.CursorTop, Align.Left, false);
        }
        public static byte[] ANSIStringToByte(string text)
        {
            Encoding windowsDefault = Encoding.Default;
            Encoding unicode = Encoding.Unicode;
            return Encoding.Convert(unicode, windowsDefault, unicode.GetBytes(text));
        }
        public static void Dialogue(string name, string text)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(name);
            Console.ResetColor();
            Console.WriteLine(" : \"{0}\"", text);
        }

    }
    public static class ConsoleKo
    {
        public static void Write(string text)
        {
            Console.Write(조사.문자처리(text));
        }
        public static void Write(string text, params object[] args)
        {
            Console.Write(조사.문자처리(text, args));
        }
        public static void WriteLine(string text)
        {
            Console.WriteLine(조사.문자처리(text));
        }
        public static void WriteLine(string text, params object[] args)
        {
            Console.WriteLine(조사.문자처리(text, args));
        }
    }
}
