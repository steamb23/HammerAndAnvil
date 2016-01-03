using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HA.Scenes
{
    class NewGameScene : IScene
    {
        public void Run()
        {
            PlayData.CurrentPlayData = new PlayData();
            
            Console.WriteLine("태모신 아리스가 태초의 불을 피웠다고 전해지는 잊혀진 대륙이 발견되었다.");
            Console.ReadKey(true);
            Console.Write("그 소식을 들은 많은 모험가들이 명성을 거머쥐기 위해,");
            Console.ReadKey(true);
            Console.WriteLine(" 그리고 구대륙에서 등 떠밀려나온 자들이 잊혀진 대륙, 아리스 대륙으로 몰려들었다.");
            Console.ReadKey(true);
            Console.WriteLine();
            Console.WriteLine("나도 그들 중 하나.");
            Console.ReadKey(true);
            Console.WriteLine("대장장이의 제자였던 나는 어처구니 없게도 누명을 쓰고 신대륙으로 도망쳐왔다.");
            Console.ReadKey(true);
            Console.WriteLine("이 새로운 기회의 땅에서 살아남기 위해서는 이 미숙하게 배운 대장장이의 기술을 혼자서 발전시켜나가야만 한다.");
            Console.ReadKey(true);
            Console.WriteLine();
            Console.WriteLine("그렇담, 이 땅에서 무슨 이름으로 불리는 것이 좋을까?");

            bool isNameConfirmed = false;
            string playerName = string.Empty;
            while (!isNameConfirmed)
            {
                playerName = ConsoleEx.ReadText();
                if (string.IsNullOrEmpty(playerName))
                {
                    playerName = "에단";
                }
                ConsoleKo.WriteLine("{0}[으로] 할까?", playerName);
                ConsoleEx.Selector.Add('y', "이 이름으로 한다.", () =>
                {
                    isNameConfirmed = true;
                    ConsoleEx.CursorUp();
                    ConsoleEx.ClearLine();
                });
                ConsoleEx.Selector.Add('n', "아니다, 다시 정한다.", () =>
                {
                    ConsoleEx.CursorUp();
                    ConsoleEx.ClearLine();
                });
                ConsoleEx.Selector.Read('y');
            }
            PlayData.CurrentPlayData.PlayerName = playerName;
            ConsoleKo.WriteLine("{0}[으로] 하는 것이 좋을 것같다.", playerName);
            Console.ReadKey(true);
            Console.WriteLine("대장간 간판을 뭘로 하지?");

            bool isWorkshopNameConfirmed = false;
            string workshopName = string.Empty;
            while (!isWorkshopNameConfirmed)
            {
                workshopName = ConsoleEx.ReadText();
                if (string.IsNullOrEmpty(workshopName))
                {
                    workshopName = "아리스토나 단조공방";
                }
                ConsoleKo.WriteLine("{0}[으로] 할까?", workshopName);
                ConsoleEx.Selector.Add('y', "이 이름으로 한다.", () =>
                {
                    isWorkshopNameConfirmed = true;
                    ConsoleEx.CursorUp();
                    ConsoleEx.ClearLine();
                });
                ConsoleEx.Selector.Add('n', "아니다, 다시 정한다.", () =>
                {
                    ConsoleEx.CursorUp();
                    ConsoleEx.ClearLine();
                });
                ConsoleEx.Selector.Read('y');
            }
            PlayData.CurrentPlayData.WorkshopName = workshopName;
            ConsoleKo.WriteLine("{0}[으로] 하는 것이 좋을 것같다.", workshopName);

            Console.WriteLine(" 게임을 본격적으로 시작하기 전에 게임 설명을 읽으시겠습니까?");
            Console.WriteLine(" 해당 설명은 지금 읽을 것을 권장하지만 잊어버렸다면 게임내에서 언제든지 다시 읽을 수 있습니다.");
            ConsoleEx.Selector.Add('y', "네", () =>
            {
                Tutorial();
            });
            ConsoleEx.Selector.Add('n', "아니오", () =>
            {
            });
            ConsoleEx.Selector.Read('y');
            Program.SceneManager.ChangeScene(new Events.Prologue());


        }
        public static void Tutorial()
        {
            bool isTutorialExit = false;
            while (!isTutorialExit)
            {
                Console.Clear();
                Console.WriteLine("   [게임 설명]");
                ConsoleEx.Selector.Add('1', "[장르]",()=>
                {
                    Console.Clear();
                    Console.WriteLine("   [장르]");
                    Console.WriteLine();
                    Console.WriteLine("망치와 모루는 무기나 갑옷 등의 철제 제품을 만들어 판매하여 수익을 올리는 경영RPG 게임입니다.");
                    Console.ReadKey(true);
                });
                ConsoleEx.Selector.Add('2', "[시스템]", () =>
                {
                    Console.Clear();
                    Console.WriteLine("   [시스템]");
                    ConsoleEx.Selector.Add('1', "[시간 시스템]", () =>
                    {
                        Console.Clear();
                        Console.WriteLine("   [시간 시스템]");
                        Console.WriteLine();
                        Console.WriteLine("하루는 오전, 오후, 저녁의 3단위로 나뉘어져 있으며 캐릭터가 어떤 행동을 하느냐에 따라서 소요되는 시간이 다릅니다.");
                        Console.WriteLine("마을을 돌아다니는 행위등은 반나절이 소요되고,");
                        Console.WriteLine("제작과 판매는 한나절이 소요됩니다.");
                        Console.WriteLine("모험은 하루단위로 소요됩니다.");
                        Console.ReadKey(true);
                    });
                    ConsoleEx.Selector.Add('2', "[제작 시스템]", () =>
                    {
                        Console.Clear();
                        Console.WriteLine("   [제작 시스템]");
                        Console.WriteLine();
                        Console.WriteLine("재료를 사용하여 상품을 만들어냅니다.");
                        Console.WriteLine("숙련도가 높을 수록 실패, 졸작 등급 상품이 적게나오고 걸작, 명작, 전설등의 상품이 잘나오게 됩니다.");
                        Console.WriteLine("체력이 낮으면 낮은 만큼 숙련도 반영에 패널티를 받습니다.");
                        Console.ReadKey(true);
                    });
                    ConsoleEx.Selector.Add('3', "[전투 시스템]", () =>
                    {
                        Console.Clear();
                        Console.WriteLine("   [전투 시스템]");
                        Console.WriteLine();
                        Console.WriteLine("전투는 공격, 방어, 회피, 대기, 아이템 사용등의 기력을 소모거나 회복시키는 커맨드를 사용하여 적을 이기는 것이 목표입니다.");
                        Console.WriteLine("플레이어의 기교가 적보다 높다면 더 많은 행동 기회를 얻을 수 있습니다. 반대로 적이 플레이어보다 기교가 높을 수도 있습니다.");
                        Console.WriteLine("적의 종류에 따라 전투 성향이 다른 경우가 있습니다. 어떤 적은 무조건 공격만 할 수도 있고 플레이어의 행동 패턴을 눈여겨 보다가 허를 찌르기도 합니다.");
                        Console.WriteLine("서로 공격을 하면 두 배 정도의 더 큰 피해를 입게 됩니다.");
                        Console.WriteLine("공격을 방어하여 막게되면 장착한 장비의 방어효율에 따라 피해를 적게 입습니다.");
                        Console.WriteLine("회피는 꽤 많은 기력을 소모하며 피해를 전혀 입지 않습니다.");
                        Console.WriteLine("대기하거나 아이템을 사용하는 것은 일반적으로 기력을 회복시킵니다.");
                        Console.ReadKey(true);
                    });
                    ConsoleEx.Selector.Add('x', "취소", () =>
                    {
                    });
                    ConsoleEx.Selector.Read();
                });
                ConsoleEx.Selector.Add('x', "취소", () =>
                {
                    isTutorialExit = true;
                });
                ConsoleEx.Selector.Read();
            }
        }
    }
}
