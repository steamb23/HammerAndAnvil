﻿using System;
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
                ConsoleEx.Selector.Read('n');
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
                ConsoleEx.Selector.Read('n');
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
            ConsoleEx.Selector.Read('y');


            Console.Clear();
            Console.WriteLine("...");
            Console.ReadKey(true);
            Console.WriteLine();
            Console.WriteLine("아리스 대륙으로 건너온 이후 아리스글로리 여관에서 지낸지 벌써 한달이 다 되가고 있다.");
            Console.ReadKey(true);
            Console.WriteLine("물론 그 동안 놀고만 있었던 것만은 아니다.");
            Console.ReadKey(true);
            Console.WriteLine("이 낯선 정착지에 정착해서 내 기술을 펼치기 위해 아리스토나시 행정 조합에 대장장이등록과 대장간 건축 허가를 받고 건설현장을 다니며 내 요구에 부합하는 대장간을 갖기 위해 노력했다.");
            Console.ReadKey(true);
            Console.WriteLine("그리고 오늘 아침 가구 배치까지 모든 작업을 끝냈다고 건축사무소에서 사람을 보내왔다.");
            Console.ReadKey(true);
            Console.WriteLine("이제 가서 확인만 하면 되겠군.");
            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("아리스토나의 거리...");
            Console.ReadKey(true);
            Console.WriteLine();
            Console.WriteLine("도시의 거리는 사람들의 활기찬 발걸음으로 가득찼다.");
            Console.ReadKey(true);
            Console.WriteLine("아직은 마을 수준보다 조금 크다고 말할 수 있는 작은 도시긴하지만 정착지가 세워진 몇년동안 이 정도로 성장했다는 것은 놀라울 따름이다.");
            Console.ReadKey(true);
            Console.WriteLine("그 만큼 많은 이들이 이주해온다는 것이다.");
            Console.ReadKey(true);
            Console.WriteLine("도시 북쪽에는 제련소가 있다.");
            Console.ReadKey(true);
            Console.WriteLine("내 대장간을 둘러보기전에 제련소에 들러서 첫 작품에 들어갈 철 주괴를 사두는 것이 좋겠다.");
            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("아리스토나 제련소...");
            Console.ReadKey(true);
            Console.WriteLine();
            Console.WriteLine("이제까지는 도시 북부에 위치한 철광에서 캔 철광석들을 주괴로 만들어 거의 다 본토의 왕국에 수출하던 제련소다.");
            Console.ReadKey(true);
            Console.WriteLine("그리고 이제는 내가 이 제련소의 주요 고객이 되겠지...");
            Console.ReadKey(true);
            ConsoleEx.Dialogue("클랑 아저씨","여, 신참 대장장이 양반 아니신가. 대장간 다 지어졌다고 하던데.");
            Console.ReadKey(true);
            Console.WriteLine("이 분은 제련소 주인인 클랑 아저씨, 처음 이 도시에 왔을때 술집에서 친해진 사람이다. 굉장히 편하고 호쾌한 사람이다.");
            Console.ReadKey(true);
            ConsoleEx.Dialogue(PlayData.CurrentPlayData.PlayerName, "아, 네. 소문이 퍼졌나보군요.");
            Console.ReadKey(true);
            ConsoleEx.Dialogue("클랑 아저씨", "당연하지. 도시가 세워지고 나서 처음으로 전문적인 대장간이 들어서는 건데.");
            Console.ReadKey(true);
            Console.WriteLine("대장간이 없었던 당시에는 제련소에서 칼이나 지렛대 등의 간단한 단조 제품도 취급했다고 한다.");
            Console.ReadKey(true);
            Console.WriteLine("당연히 이곳에 왔을 때 클랑 아저씨가 제련소 안에서 일하는게 어떻겠느냐고 제안 했었다.");
            Console.ReadKey(true);
            Console.WriteLine("그러나 나 혼자만의 대장간을 갖고 싶다고 하니 아저씨는 호쾌하게 대장간에 필요한 도구들을 선물해주기로 약속했다.");
            Console.ReadKey(true);
            ConsoleEx.Dialogue("클랑 아저씨", "주괴 사러온거지? 안 그래도 철 주괴 보내놨네.");
            Console.ReadKey(true);
            ConsoleEx.Dialogue(PlayData.CurrentPlayData.PlayerName, "네?");
            Console.ReadKey(true);
            Console.WriteLine("말도 꺼내지도 않았는데 이미 보냈다니?");
            Console.ReadKey(true);
            ConsoleEx.Dialogue("클랑 아저씨", "개업 축하 선물이야. 돈은 안줘도 돼.");
            Console.ReadKey(true);
            ConsoleEx.Dialogue(PlayData.CurrentPlayData.PlayerName, "그래도 제가 빚진 것도 있는데 괜찮겠습니까?");
            Console.ReadKey(true);
            ConsoleEx.Dialogue("클랑 아저씨", "뭐야, 그런 이유로 내 호의를 거절하겠다는 건가? 빚은 술 사주는 것으로 갚으면 되잖나.");
            Console.ReadKey(true);
            Console.WriteLine("클랑 아저씨의 콧수염이 삐죽거렸다.");
            Console.ReadKey(true);
            ConsoleEx.Dialogue(PlayData.CurrentPlayData.PlayerName, "하하, 아저씨 호탕함은 누구라도 못이기겠네요. 감사하게 쓰겠습니다.");
            Console.ReadKey(true);
            ConsoleEx.Dialogue("클랑 아저씨", "그래, 좋은 철기를 만들길 빌겠네.");
            Console.ReadKey(true);
            Console.WriteLine("자, 이제 내 대장간을 보러 가볼까.");
            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("{0} 앞...", PlayData.CurrentPlayData.WorkshopName);
            Console.ReadKey(true);
            Console.WriteLine();
            Console.WriteLine("중심가에서 약간 구석진 곳에 위치한 작은 대장간.");
            Console.ReadKey(true);
            Console.WriteLine("이제, 내 집이자 일터가 될 곳이다.");
            Console.ReadKey(true);
            Console.WriteLine("스승님이 보태주신 정착금과 그 동안 모아왔던 목돈을 모조리 쏟아부었다.");
            Console.ReadKey(true);
            Console.WriteLine("지금은 작고 초라하지만 나중에는 더 커지겠지...");
            Console.ReadKey(true);
            ConsoleEx.Dialogue("소피아", "대장간이 다 지어졌다고 해서 와봤어요.");
            Console.ReadKey(true);
            Console.WriteLine("이 아리따운 여성은 소피아, 아리스글로리의 어린 경영자다.");
            Console.ReadKey(true);
            Console.WriteLine("여려보이지만 의외로 속은 강인한 여자다. 치근대던 술주정뱅이들을 처리하는걸 목격했을 때는 솔직히 좀 무서웠다.");
            Console.ReadKey(true);
            ConsoleEx.Dialogue(PlayData.CurrentPlayData.PlayerName, "안녕하십니까.");
            Console.ReadKey(true);
            ConsoleEx.Dialogue("소피아", "대장간이 다 지어졌다고 해서 와봤어요. 오늘부터 일하시는 건가요?");
            Console.ReadKey(true);
            ConsoleEx.Dialogue(PlayData.CurrentPlayData.PlayerName, "아뇨, 오늘은 그냥 짐 정리정도만 하고 내일부터 일해볼까합니다.");
            Console.ReadKey(true);
            ConsoleEx.Dialogue("소피아", "그렇군요. 혹시 내일 국자를 만들어 주실 수 있나요? 제련소에서는 더 이상 취급 안한다고 하더군요.");
            Console.ReadKey(true);
            Console.WriteLine("사실, 제련소의 단조 장비들을 내가 다 가져왔으니 더 이상 만들어 줄 수 없겠지, 내일은 주문처리하느라 좀 바쁘겠는걸...");
            Console.ReadKey(true);
            ConsoleEx.Dialogue(PlayData.CurrentPlayData.PlayerName, "물론이죠. 내일 저녁쯤에 찾으러 오세요.");
            Console.ReadKey(true);
            ConsoleEx.Dialogue("소피아", "네, 내일오도록 할게요.");
            Console.ReadKey(true);
            Console.WriteLine("소피아를 배웅했다. 자 그럼, 이제 건물 안을 둘러봐야지.");
            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("{0} 작업실...", PlayData.CurrentPlayData.WorkshopName);
            Console.ReadKey(true);
            Console.WriteLine();
            Console.WriteLine("모든 연장들이 가지런히 걸려있고, 금속을 빨갛게 달굴 화로는 튼튼하게 지어져있다.");
            Console.ReadKey(true);
            Console.WriteLine("작지만 대장간으로써는 충분하다.");
            Console.ReadKey(true);
            Console.WriteLine("내일은 바로 일할 수 있을 것 같다.");
            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("{0} 2층...", PlayData.CurrentPlayData.WorkshopName);
            Console.ReadKey(true);
            Console.WriteLine();
            Console.WriteLine("이곳이 이제 나의 집이다.");
            Console.ReadKey(true);
            Console.WriteLine("짐 정리좀 하다가 일찍 자야겠군.");
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
