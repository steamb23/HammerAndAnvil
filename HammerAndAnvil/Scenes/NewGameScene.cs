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
            
            Console.WriteLine("태모신 아리스가 최초의 생명을 만들었다고 전해지는 잊혀진 대륙이 발견되었다.");
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
                if (!string.IsNullOrEmpty(playerName))
                {
                    ConsoleKo.WriteLine("{0}[으로] 할까?", playerName);
                    ConsoleEx.Selector.Add('y', "이 이름으로 한다.", () =>
                    {
                        isNameConfirmed = true;
                    });
                    ConsoleEx.Selector.Add('n', "아니다, 다시 정한다.", () =>
                    {
                    });
                    ConsoleEx.Selector.Read();
                    ConsoleEx.CursorUp();
                    ConsoleEx.ClearLine();
                }
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
                if (!string.IsNullOrEmpty(workshopName))
                {
                    ConsoleKo.WriteLine("{0}[으로] 할까?", workshopName);
                    ConsoleEx.Selector.Add('y', "이 이름으로 한다.", () =>
                    {
                        isWorkshopNameConfirmed = true;
                    });
                    ConsoleEx.Selector.Add('n', "아니다, 다시 정한다.", () =>
                    {
                    });
                    ConsoleEx.Selector.Read();
                    ConsoleEx.CursorUp();
                    ConsoleEx.ClearLine();
                }
            }
            PlayData.CurrentPlayData.WorkshopName = workshopName;
            ConsoleKo.WriteLine("{0}[으로] 하는 것이 좋을 것같다.", workshopName);

            Console.WriteLine(" 게임을 본격적으로 시작하기 전에 게임 설명을 읽으시겠습니까?");
            Console.WriteLine(" 해당 설명은 게임내에서 언제든지 다시 읽을 수 있습니다.");
            ConsoleEx.Selector.Add('y', "네", () =>
            {
                Tutorial();
            });
            ConsoleEx.Selector.Add('n', "아니오", () =>
            {
            });
            ConsoleEx.Selector.Read();


            Console.Clear();
            Console.WriteLine("...");
            Console.ReadKey(true);
            Console.WriteLine();
            Console.WriteLine("아리스 대륙으로 건너온 이후 아리스글로리 여관에서 지낸지 벌써 2주일이 다 되가고 있다.");
            Console.ReadKey(true);
            Console.WriteLine("물론 그 동안 놀고만 있었던 것만은 아니다.");
            Console.ReadKey(true);
            Console.WriteLine("이 낯선 정착지에 정착해서 내 기술을 펼치기 위해 아리스토나시 행정 조합에 대장장이등록과 대장간 건축 허가를 받고 건설현장을 다니며 내 요구에 부합하는 대장간을 갖기 위해 노력했다.");
            Console.ReadKey(true);
            Console.WriteLine("그리고 오늘 아침 모든 정리를 끝냈다고 건축사무소에서 통지가 날아왔다.");
            Console.ReadKey(true);
            Console.WriteLine("이제 가서 일만하면 되겠군.");
            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("아리스토나의 거리...");
            Console.ReadKey(true);
            Console.WriteLine();
            Console.WriteLine("도시의 거리는 사람들의 활기찬 발걸음으로 가득찼다.");
            Console.ReadKey(true);
            Console.WriteLine("아직은 작은 도시긴하지만 정착지가 세워진 10년동안 이 정도로 성장했다는 것은 놀라울 따름이다.");
            Console.ReadKey(true);
            Console.WriteLine("그 만큼 많은 이들이 이주해온다는 것이다.");
            Console.ReadKey(true);
            Console.WriteLine("대장간에서 얼마 떨어지지 않은 곳에는 주조소가 있다.");
            Console.ReadKey(true);
            Console.WriteLine("내 대장간을 둘러보기전에 주조소에 들러서 첫 작품에 들어갈 철 주괴를 사두는 것이 좋겠다.");
            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("아리스토나 주조소...");
            Console.ReadKey(true);
            Console.WriteLine("이제까지는 도시 북부에 위치한 광산에서 캔 철광석들을 주괴로 만들어 본토의 왕국에 수출만 해오던 주조소다.");
            Console.ReadKey(true);
            Console.WriteLine("그리고 이제는 내가 이 주조소의 주요 고객이 되겠지...");
            Console.ReadKey(true);
            ConsoleEx.Dialogue("클랑 아저씨","여, 신참 대장장이 양반 아니신가. 대장간 다 지어졌다고 하던데.");
            Console.ReadKey(true);
            Console.WriteLine("이 분은 주조소 주인인 클랑 아저씨, 처음 이 도시에 왔을때 술집에서 친해진 사람이다.");
            Console.ReadKey(true);
            ConsoleEx.Dialogue(PlayData.CurrentPlayData.PlayerName, "아, 네. 안그래도 마침 가보려고 했습니다. 그 전에 주괴를 주문하려구요.");
            Console.ReadKey(true);
            ConsoleEx.Dialogue("클랑 아저씨", "안그래도 사람 보내놨어.");
            Console.ReadKey(true);
            ConsoleEx.Dialogue(PlayData.CurrentPlayData.PlayerName, "네?");
            Console.ReadKey(true);
            ConsoleEx.Dialogue("클랑 아저씨", "개업 축하 선물이야. 돈은 안줘도 돼.");
            Console.ReadKey(true);
            ConsoleEx.Dialogue(PlayData.CurrentPlayData.PlayerName, "그래도 그거로 장사해 벌어 사시는 건데 공짜로 주셔도 되겠습니까?");
            Console.ReadKey(true);
            ConsoleEx.Dialogue("클랑 아저씨", "뭐야, 내 호의를 거절하겠다는 건가? 그것 참 서운하군.");
            Console.ReadKey(true);
            ConsoleEx.Dialogue(PlayData.CurrentPlayData.PlayerName, "아니오. 감사하게 쓰겠습니다.");
            Console.ReadKey(true);
            ConsoleEx.Dialogue("클랑 아저씨", "그래, 좋은 철기를 만들길 빌겠네.");
            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("{0}...", PlayData.CurrentPlayData.WorkshopName);
            Console.ReadKey(true);
            Console.WriteLine("약간 외진 곳에 위치한 작은 대장간.");
            Console.ReadKey(true);
            Console.WriteLine("이제, 내 집이자 일터가 될 곳이다.");
            Console.ReadKey(true);
            Console.WriteLine("스승님이 보태주신 정착금과 그 동안 모아왔던 목돈을 모조리 쏟아부었다.");
            Console.ReadKey(true);
            Console.WriteLine("지금은 작고 초라하지만 나중에는 더 커지겠지...");
            Console.ReadKey(true);
        }
        public static void Tutorial()
        {
            bool isTutorialExit = false;
            while (!isTutorialExit)
            {
                Console.Clear();
                Console.WriteLine("   [게임 설명]");
                ConsoleEx.Selector.Add('1', "[망치와 모루의 장르]",()=>
                {
                    Console.WriteLine("   [망치와 모루의 장르]");
                    Console.WriteLine();
                    Console.WriteLine("망치와 모루는 무기나 갑옷, 그 외의 철제 제품을 만들어 판매하여 수익을 올리는 경영RPG 게임입니다.");
                    Console.ReadKey(true);
                });
                ConsoleEx.Selector.Add('2', "[시간 시스템]", () =>
                {
                    Console.WriteLine();
                    Console.WriteLine("   [시간 시스템]");
                    Console.WriteLine();
                    Console.WriteLine("하루는 오전, 오후, 저녁의 3단위로 나뉘어져 있으며 캐릭터가 어떤 행동을 하느냐에 따라서 소요되는 시간이 다릅니다.");
                    Console.WriteLine("마을을 돌아다니는 행위등은 반나절이 소요되고,");
                    Console.WriteLine("제작은 한나절이 소요됩니다.");
                    Console.WriteLine("모험은 하루단위로 소요됩니다.");
                    Console.ReadKey(true);
                });
                ConsoleEx.Selector.Add('3', "[제작 시스템]", () =>
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("   [제작 시스템]");
                    Console.WriteLine();
                    Console.WriteLine("재료를 사용하여 상품을 만들어냅니다.");
                    Console.WriteLine("숙련도가 높을 수록 실패, 졸작 등급 상품이 적게나오고 걸작, 명작, 전설등의 상품이 잘나오게 됩니다.");
                    Console.ReadKey(true);
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
