using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solo_Practice_CSharp
{
    public enum GameMode
    {
        None,
        Lobby,
        Town,
        Field
    }
    internal class Game
    {
        private GameMode mode = GameMode.Lobby;
        private Player player = null;
        private Monster monster = null;
        Random rand = new Random();
        public void Process()
        {
            switch(mode)
            {
                case GameMode.Lobby:
                    ProcessLobby();
                    break;
                case GameMode.Town:
                    ProcessTown();
                    break;
                case GameMode.Field:
                    break;
            }
        }

        private void ProcessLobby()
        {
            Console.WriteLine("직업을 선택하세요!");
            Console.WriteLine("[1] 기사");
            Console.WriteLine("[2] 궁수");
            Console.WriteLine("[3] 법사");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    player = new Knight();
                    mode = GameMode.Town;
                    break;
                case "2":
                    player = new Archer();
                    mode = GameMode.Town;
                    break;
                case "3":
                    player = new Mage();
                    mode = GameMode.Town;
                    break;
            }
        }

        private void ProcessTown()
        {
            Console.WriteLine("마을에 왔습니다.");
            Console.WriteLine("[1] 필드로 간다.");
            Console.WriteLine("[2] 로비로 돌아간다.");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    mode = GameMode.Field;
                    break;
                case "2":
                    mode = GameMode.Lobby;
                    break;
            }
        }

        private void ProcessField()
        {
            Console.WriteLine("필드에 왔습니다.");

            CreateRandomMonster();

            Console.WriteLine("[1] 싸운다.");
            Console.WriteLine("[2] 일정 확률로 도망간다.");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    ProcessFight();
                    break;
                case "2":
                    TryToEscape();
                    break;
            }
        }

        private void CreateRandomMonster()
        {
            int randValue = rand.Next(0, 3);
            switch (randValue)
            {
                case 0:
                    monster = new Slime();
                    Console.WriteLine("슬라임이 생성되었습니다!");
                    break;
                case 1:
                    monster = new Goblin();
                    Console.WriteLine("고블린이 생성되었습니다!");
                    break;
                case 2:
                    monster = new Undead();
                    Console.WriteLine("언데드가 생성되었습니다!");
                    break;
            }
        }

        private void ProcessFight()
        {
            // 자고 나서 구현합시다잉
        }

        private void TryToEscape()
        {
            // 자고 나서 구현합시다잉
        }
    }
}
