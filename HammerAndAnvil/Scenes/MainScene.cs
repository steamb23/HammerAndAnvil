using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HA.Scenes
{
    class MainScene : IScene
    {
        public void Run()
        {
            string version = string.Format("Ver {0}", System.Reflection.Assembly.GetExecutingAssembly().GetName().Version);
            const char borderText = '=';
            Console.SetCursorPosition(1, 0);
            Console.Write(new string(borderText, 78));
            Console.ForegroundColor = ConsoleColor.Magenta;
            ConsoleEx.WriteText("H A M M E R   A N D   A N V I L", 40, 3, ConsoleEx.Align.Center);
            Console.ResetColor();
            ConsoleEx.WriteText("By SteamB23", 80 - 3, 4, ConsoleEx.Align.Right);
            ConsoleEx.WriteText(version, 80 - 3, 5, ConsoleEx.Align.Right);
            Console.SetCursorPosition(1, 6);
            Console.Write(new string(borderText, 78));
            Console.WriteLine();
            ConsoleEx.Selector.Add('N', "새로시작", () =>
            {
                Program.SceneManager.ChangeScene(new NewGameScene());
            });
            ConsoleEx.Selector.Add('L', "불러오기", () =>
            {
            });
            ConsoleEx.Selector.Add('X', "종료", () =>
            {
                Program.Exit();
            });
            ConsoleEx.Selector.Read();
        }
    }
}
