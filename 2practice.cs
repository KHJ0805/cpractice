using System.Threading;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

// 스타트씬
public class Start
{
    public void start()
    {
        Console.WriteLine("스파르타 마을에 오신 것을 환영합니다.");
        Console.WriteLine("당신의 이름은 무엇입니까?");
        string PlayerName = Console.ReadLine();
        Console.WriteLine($"{PlayerName}님 마을로 이동하겠습니다. 행운을 빕니다.");
        Player psetting = new Player(PlayerName, 100, 10, 5, 800);
        Replacement game = new Replacement();
        game.TownBoard();
    }
}


// 플레이어 클래스
class Player
{
    public Player(string name, int health, int attack, int defence, int gold)
    {
        Name = name;
        Health = health;
        Attack = attack;
        Defence = defence;
        Gold = gold;
    }
    public string Name { get; }
    public int Attack { get; set; }
    public int Health { get; set; }
    public int Defence { get; set; }
    public int Gold { get; set; }


    public void StatusBoard()
    {
        Console.Clear();
        Console.WriteLine("상태 보기");
        Console.WriteLine("캐릭터의 정보가 표시됩니다.");
        Console.WriteLine($"이름 : {Name}");
        Console.WriteLine("Lv. 01");
        Console.WriteLine($"공격력 : {Attack}");
        Console.WriteLine($"방어력 : {Defence}");
        Console.WriteLine($"체 력 : {Health}");
        Console.WriteLine($"방어력 : {Gold}g");
        Console.WriteLine("");
        Console.WriteLine("0. 나가기");
        Console.WriteLine("");
        Console.WriteLine("원하시는 행동을 입력해주세요.");
        Console.WriteLine(">>>>");
        string StatusSelect = Console.ReadLine();

        if (StatusSelect == "0")
        {
            Replacement game = new Replacement();
            game.TownBoard();
        }
        else
        {
            Console.WriteLine("잘못된 입력입니다.");
            StatusBoard();
        }
    }
}


    // 아이템 인터페이스 
    public interface IItem
    {
        string name { get; }
        int attack { get; }
        int defence { get; }
        int gold { get; }
        string script { get; }
    }

    // 수련자의 갑옷
    public class Equip1 : IItem
    {
        public string name => "수련자의 갑옷";
        public int attack => 0;
        public int defence => 5;
        public int gold => 1000;
        public string script => "수련에 도움을 주는 갑옷입니다. /t";
    }
     // 무쇠갑옷
    public class Equip2 : IItem
    {
        public string name => "무쇠 갑옷";
        public int attack => 0;
        public int defence => 9;
        public int gold => 2000;
        public string script => "무쇠로 만들어져 튼튼한 갑옷입니다./t";
    }
        // 스파르타의 갑옷
    public class Equip3 : IItem
    {
        public string name => "스파르타의 갑옷";
        public int attack => 0;
        public int defence => 15;
        public int gold => 3500;
        public string script => "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.";
    }
    // 낡은 검
    public class Equip4 : IItem
    {
        public string name => "낡은 검";
        public int attack => 2;
        public int defence => 0;
        public int gold => 600;
        public string script => "쉽게 볼 수 있는 낡은 검 입니다. /t";
    }
    // 청동 도끼
    public class Equip5 : IItem
    {
        public string name => "청동 도끼";
        public int attack => 5;
        public int defence => 0;
        public int gold => 1500;
        public string script => "어디선가 사용됐던거 같은 도끼입니다./t";
    }
    // 스파르타의 창
    public class Equip6 : IItem
    {
        public string name => "스파르타의 창";
        public int attack => 7;
        public int defence => 0;
        public int gold => 3000;
        public string script => "스파르타의 전사들이 사용했다는 전설의 창입니다.";
    }

    

// 이동장소들
public class Replacement
{
   

    public void TownBoard()
    {
        Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
        Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
        Console.WriteLine("");
        Console.WriteLine("1. 상태 보기");
        Console.WriteLine("2. 인벤토리");
        Console.WriteLine("3. 상점");
        Console.WriteLine("4. 사냥가기");
        Console.WriteLine("");
        Console.WriteLine("원하시는 행동을 입력해주세요.");
        Console.WriteLine(">>>> ");
        string TownSelect = Console.ReadLine();

        if (TownSelect == "1")
        {
            game.StatusBoard();

        }
        else if (TownSelect == "2")
        {
            IventoryBoard();
        }
        else if (TownSelect == "3")
        {
            ShopBoard();
        }
        else if (TownSelect == "4")
        {
            hunt();
        }
        else
        {
            Console.WriteLine("잘못된 입력입니다.");
            TownBoard();
        }
    }



    // 인벤토리


    public void IventoryBoard()
    {
        Console.Clear();
        Console.WriteLine("인벤토리");
        Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
        Console.WriteLine("");
        Console.WriteLine("[아이템 목록]");
        Console.WriteLine("");
        Console.WriteLine("1. 장착 관리");
        Console.WriteLine("0. 나가기");
        Console.WriteLine("");
        Console.WriteLine("원하시는 행동을 입력해주세요.");
        Console.WriteLine(">>>");
        string InventorySelect = Console.ReadLine();
        if (InventorySelect == "0")
        {
            TownBoard();
        }
        else if (InventorySelect == "1")
        {
            EquipmentsBoard();
        }
        else
        {
            Console.WriteLine("잘못된 입력입니다.");
            IventoryBoard();
        }
    }


    // 장착관리

    public void EquipmentsBoard()
    {
        Console.Clear();
        Console.WriteLine("인벤토리 - 장착관리");
        Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
        Console.WriteLine("");
        Console.WriteLine("[아이템 목록]");
        Console.WriteLine("");
        Console.WriteLine("1. ");
        Console.WriteLine("0. 나가기");
        Console.WriteLine("");
        Console.WriteLine("원하시는 행동을 선택해주세요.");
        Console.WriteLine(">>>");
        string EquipmentsSelect = Console.ReadLine();
        if (EquipmentsSelect == "0")
        {
            IventoryBoard();
        }

        else
        {
            Console.WriteLine("잘못된 입력입니다.");
            EquipmentsBoard();
        }
    }




    // 상점
    public void ShopBoard()
    {
        Console.Clear();
        Console.WriteLine("상점");
        Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
        Console.WriteLine("");
        Console.WriteLine("[보유 골드]");
        Console.WriteLine("G");
        Console.WriteLine("");
        Console.WriteLine("[아이템 목록]");
        Console.WriteLine("- 수련자 갑옷    | 방어력 +5  | 수련에 도움을 주는 갑옷입니다.             |");
        Console.WriteLine("- 무쇠갑옷      | 방어력 +9  | 무쇠로 만들어져 튼튼한 갑옷입니다.           |");
        Console.WriteLine("- 스파르타의 갑옷 | 방어력 +15 | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다.|");
        Console.WriteLine("- 낡은 검      | 공격력 +2  | 쉽게 볼 수 있는 낡은 검 입니다.            |");
        Console.WriteLine("- 청동 도끼     | 공격력 +5  |  어디선가 사용됐던거 같은 도끼입니다.        |");
        Console.WriteLine("- 스파르타의 창  | 공격력 +7  | 스파르타의 전사들이 사용했다는 전설의 창입니다. |");
        Console.WriteLine("");
        Console.WriteLine("1. 아이템 구매");
        Console.WriteLine("0. 나가기");
        Console.WriteLine("");
        Console.WriteLine("원하시는 행동을 입력해주세요.");
        Console.WriteLine(">>");
        string ShopSelect = Console.ReadLine();

        if (ShopSelect == "0")
        {
            TownBoard();
        }
        else if (ShopSelect == "1")
        {
            Buyitem();
        }

        void Buyitem()
        {
            Console.Write("몇번째 아이템을 구매하시겠습니까? : ");
            Console.Write("0. 나가기");
            string input = Console.ReadLine();
            if (input == "0")
            {
                ShopBoard();
            }
            //if (input == "1")
            //{
            //    if (//1번템이 없고 골드가 충분할 때)
            //    {
            //        Console.Write("구매하였습니다.");
            //        //수련자의 갑옷 인벤토리로, 골드 -
            //        ShopBoard();
            //    }
            //    else
            //    {
            //        Console.Write("구매할 수 없습니다.");
            //        Buyitem();
            //    }

            //}
            //else if (input == "2")
            //{
            //    if (//2번템이 없고 골드가 충분할 때)
            //    {
            //        Console.Write("구매하였습니다.");
            //        //무쇠 갑옷 인벤토리로, 골드 -
            //        ShopBoard();
            //    }
            //    else
            //    {
            //        Console.Write("구매할 수 없습니다.");
            //        Buyitem();
            //    }
            //}
            //else if (input == "3")
            //{
            //    if (//3번템이 없고 골드가 충분할 때)
            //    {
            //        Console.Write("구매하였습니다.");
            //        //스파르타의 갑옷 인벤토리, 골드 -
            //        ShopBoard();
            //    }
            //    else
            //    {
            //        Console.Write("구매할 수 없습니다.");
            //        Buyitem();
            //    }
            //}
            //else if (input == "4")
            //{
            //    if (//4번템이 없고 골드가 충분할때)
            //    {
            //        Console.Write("구매하였습니다.");
            //        //낡은 검 인벤토리, 골드 -
            //        ShopBoard();
            //    }
            //    else
            //    {
            //        Console.Write("구매할 수 없습니다.");
            //        Buyitem();
            //    }
            //}
            //else if (input == "5")
            //{
            //    if (//5번템이 없고 골드가 충분할 때)
            //    {
            //        //청동 도끼 인벤토리, 골드 -
            //        ShopBoard();
            //    }
            //    else
            //    {
            //        Console.Write("구매할 수 없습니다.");
            //        Buyitem();
            //    }
            //}
            //else if (input == "6")
            //{
            //    if (//6번템이 없고 골드가 충분할 때)
            //    {
            //        // 스파르타의 창 인벤토리, 골드 -
            //        ShopBoard();
            //    }
            //    else
            //    {
            //        Console.Write("구매할 수 없습니다.");
            //        Buyitem();
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("잘못된 입력입니다");
            //    ShopBoard();
            //}
        }

    }

    public void hunt()
    {
        Console.Clear();
        Console.WriteLine("test용 열씨미 사냥해서 체력을 10잃고 1000g 벌었다에요.");
        // 플레이어 체력 -10 , 골드 +1000
        TownBoard();
    }
}



    // 메인 메서드
    class Program
    {
        static void Main(string[] args)
        {
            Start game = new Start();
            game.start();
        }
    }
