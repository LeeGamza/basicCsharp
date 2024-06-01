using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Serialization;
/*
 * Text- Rpg 개발 기획

적 : [슬라임, 오크, 스켈레톤]

아이템 : [소량 체력 포션, 평범한 체력 포션, 대용량 체력 포션]

클래스 : [기사, 궁수, 법사]

[도망 시스템 구현]

[상점 시스템 구현]

[몬스터 처치 시 전리품 구현 (돈만)]


 */



namespace Solo_Practice_CSharp
{
    internal class Program
    {
        enum ClassType
        {
            None = 0,
            Knight = 1,
            Archer = 2,
            Mage = 3
        }

        enum MonsterType
        {
            None = 0,
            Slime = 1,
            Orc = 2,
            Skeleton = 3
        }

        struct Player
        {
            public int hp;
            public int atk;
            public int money;
        }

        struct Monster
        {
            public int hp;
            public int atk;
            public int booty;
        }

        static ClassType ChooseClass()
        {
            while (true)
            {
                ClassType user = ClassType.None;
                Console.WriteLine("직업을 선택하세요!");
                Console.WriteLine("[1] 기사");
                Console.WriteLine("[2] 궁수");
                Console.WriteLine("[3] 법사");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        user = ClassType.Knight;
                        break;
                    case "2":
                        user = ClassType.Archer;
                        break;
                    case "3":
                        user = ClassType.Mage;
                        break;
                    default:
                        user = ClassType.None;
                        break;
                }
                if (user != ClassType.None)
                    return user;
            }
        }

        static void CreatePlayer(out Player player, ClassType userClass)
        {
            switch (userClass)
            {
                case ClassType.Knight:
                    player.hp = 100;
                    player.atk = 10;
                    player.money = 0;
                    break;

                case ClassType.Archer:
                    player.hp = 75;
                    player.atk = 12;
                    player.money = 0;
                    break;
                    
                case ClassType.Mage:
                    player.hp = 50;
                    player.atk = 15;
                    player.money = 0;
                    break;
                default:
                    player.hp = 0;
                    player.atk = 0;
                    player.money = 0;
                    break;
            }
        }

        static void EnterGame(ref Player player)
        {
            while (true)
            {
                Console.WriteLine("게임에 접속하셨습니다!");
                Console.WriteLine($"현재 플레이어의 체력 : {player.hp}");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("[1] 던전에 들어간다.");
                Console.WriteLine("[2] 마을에 들어간다.");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        EnterDungeon(ref player);
                        break;
                    case "2":
                        GotoTown(ref player);
                        break;
                    default:
                        Console.WriteLine("잘못된 키 값 입력");
                        break;
                }
            }
        }

        static void EnterDungeon(ref Player player)
        {
            while (true)
            {
                Console.WriteLine("던전에 들어오셨습니다!");
                Console.WriteLine($"현재 플레이어의 체력 : {player.hp}");
                Console.WriteLine("[1] 몬스터 생성");
                Console.WriteLine("[2] 메인화면으로 돌아가기");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        CreateRandomMonster(ref player);
                        break;
                    case "2":
                        EnterGame(ref player);
                        break;
                    default:
                        Console.WriteLine("잘못된 키 값 입력");
                        break;
                }
            }
        }
        
        static void CreateRandomMonster(ref Player player)
        {
            while (true)
            {
                Random rand = new Random();
                int randMonster = rand.Next(1, 4);
                MonsterType monsterType = MonsterType.None;
                switch (randMonster)
                {
                    case 1:
                        monsterType = MonsterType.Slime;
                        Console.WriteLine("슬라임이 나타났습니다!");
                        break;
                    case 2:
                        monsterType = MonsterType.Orc;
                        Console.WriteLine("오크가 나타났습니다!");
                        break;
                    case 3:
                        monsterType = MonsterType.Skeleton;
                        Console.WriteLine("스켈레톤이 나타났습니다!");
                        break;
                    default:
                        monsterType = MonsterType.None;
                        break;
                }
                if (monsterType != MonsterType.None)
                {
                    SettingMonster(ref player, monsterType);
                }
            }
        }

        static void SettingMonster(ref Player player, MonsterType monsterType)
        {
            Monster monster;
            switch (monsterType)
            {
                case MonsterType.Slime:
                    monster.hp = 20;
                    monster.atk = 2;
                    monster.booty = 4;
                    break;

                case MonsterType.Orc:
                    monster.hp = 32;
                    monster.atk = 8;
                    monster.booty = 10;
                    break;

                case MonsterType.Skeleton:
                    monster.hp = 25;
                    monster.atk = 5;
                    monster.booty = 8;
                    break;
                default:
                    monster.hp = 0;
                    monster.atk = 0;
                    monster.booty = 0;
                    break;
            }
            FightAndRun(ref player, ref monster);
        }

        static void FightAndRun(ref Player player, ref Monster monster)
        {
            Console.WriteLine("[1] 싸운다");
            Console.WriteLine("[2] 30%확률로 도망간다");
            string input = Console.ReadLine();
            while (true)
            {
                switch (input)
                {
                    case "1":
                        Console.WriteLine($"플레이어 체력 {player.hp} || 몬스터 체력 : {monster.hp} ");
                        monster.hp -= player.atk;
                        if ( monster.hp <= 0 )
                        {
                            Console.WriteLine("이기셨습니다");
                            Console.WriteLine($"전리품으로 골드 {monster.booty} 만큼 얻으셨습니다.");
                            GotoTown(ref player);
                        }
                        player.hp -= monster.atk;
                        if (player.hp <= 0 )
                        {
                            Console.WriteLine("패배하셨습니다.");
                            Console.WriteLine("메인화면으로 돌아갑니다.");
                            ChooseClass();
                        }
                        continue;
                    case "2":
                        Random rand = new Random();
                        int randAway = rand.Next(1, 101);
                        if (randAway <= 30)
                        {
                            Console.WriteLine("도망에 성공하셨습니다.");
                            GotoTown(ref player);
                        }
                        else
                        {
                            Console.WriteLine("도망실패 싸웁니다");
                            input = "1";
                        }
                        break;
                    default:
                        Console.WriteLine("잘못된 키 값입니다.");
                        continue;
                }
            }
        }

        static void GotoTown(ref Player player)
        {
            Console.WriteLine("마을에 오셨습니다.");
            Console.WriteLine("[1] 상점들리기");     // 구현은 가능하지만 구현 시 진도를 못따라감 따라서 미구현상태로 놔둠
            Console.WriteLine("[2] 돌아가기");
            string input = Console.ReadLine() ;

            if (input == "1")
            {
                EnterGame(ref player);
                
            }
            else if (input == "2")
            {
                EnterGame(ref player);
            }
            else
            {
                EnterGame(ref player);       // while문으로 가둬서 하는건 시간이 너무 아까움 따라서 그냥 구현안하겠음 
            }
        }

        
        static void Main(string[] args)
        {
            while(true)
            {
                Player player;
                ClassType userClass = ChooseClass();
                if (userClass != ClassType.None)
                {
                    CreatePlayer(out player, userClass);
                    while (true)
                    {
                        Console.WriteLine("[1] 게임을 시작한다.");
                        Console.WriteLine("[2] 처음부터 다시한다.");
                        string input = Console.ReadLine();
                        if (input == "1")
                        {
                            // 게임을 시작한다.
                            EnterGame(ref player);
                        }
                        else if (input == "2")
                        {
                            break;
                            
                        }
                        else
                        {
                            Console.WriteLine("잘못된 키 값 입력");
                            continue;
                        }    
                    }
                }
            }
            
        }
    }
}