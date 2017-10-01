using Ch10CardLib;
using System;
using static System.Console;
using static System.Convert;

namespace Ch10Test05
{
    class Program
    {
        public static bool GameOver { get; private set; } = false;

        private static Deck myDeck;
        private const int TOTAL_CARDS_NUMS = 52;
        private static int RemainsNum { get; set; } = TOTAL_CARDS_NUMS; // 自动属性的初始值
        private static bool[] got = new bool[TOTAL_CARDS_NUMS];
        private static Random gen = new Random();
        
        private static int getNums = 5;
        public static int GetNums
        {
            get { return getNums; }
            set
            {
                if (CheckNum(value))
                    getNums = value;
            }
        }


        private static bool CheckNum(int nums)
        {
            int max = Enum.GetValues(typeof(Rank)).Length;
            if (nums > 0 && nums <= max) // 最多一手抽13张，再多就不可能同花色了
                return true;
            return false;
        }

        private static void GiveNum()
        {
            Write("每手要抽几张牌: ");
            int nums = ToInt32(ReadLine());
            if (CheckNum(nums))
                GetNums = nums;
            else
            {
                WriteLine("要抽牌的数量不合理啊");
                GiveNum();
            }
        }

        static void Main(string[] args)
        {
            // 初始化牌组
            myDeck = new Deck();
            myDeck.Shuffle();

            // 输入要抽几张牌
            GiveNum();

            // 主流程，抽n张牌，并判断花色是不是一样
            int hands = 0;
            while (!GameOver)
            {
                Card[] cards = GetCards();
                WriteLine($"\n第{++hands}手抽牌");
                foreach (var card in cards)
                    WriteLine(card.suit + " " + card.rank);
                if (IsFlush(cards))
                    WriteLine("中了中了");
                else
                    WriteLine("没中");
                if (IsFlush(cards) || RemainsNum <= 1)
                {
                    GameOver = true;
                    WriteLine("抽牌正常结束");
                }
                ReadKey();
            }
        }

        // 一手随机抽n张牌（抽一张就赢了，抽的数量越少越容易赢）
        static Card[] GetCards()
        {
            if (GetNums > RemainsNum)
                GetNums = RemainsNum;

            Card[] cards = new Card[GetNums];
            // 抽过的不再抽。记录索引是否已抽出牌，每次随机后去比较排除掉，重新抽；或者在产生随机数时就把已存索引排除掉

            for (int i = 0; i < GetNums; i++)
            {
                int randomIndex = 0;
                randomIndex = GetIndex(randomIndex);
                Card randomCard = myDeck.GetCard(randomIndex);
                got[randomIndex] = true;
                cards[i] = randomCard;
                RemainsNum--;
            }
            return cards;
        }

        static int GetIndex(int index)
        {
            while (true)
            {
                index = gen.Next(TOTAL_CARDS_NUMS);
                if (got[index] == false)
                    break;
            }
            return index;
        }

        //static int CheckIndex(int index)

        //{
        //    // 随机放在循环里，执行很快，时间相关种子导致随机值重复，基本都会走到下面的true分支里；在那里又会引起大量递归
        //    // 而打了断点，单步执行，就没问题，执行结果不一样
        //    index = gen.Next(TOTAL_CARDS_NUMS); // 将这个Random变量new在循环外面就就不会重复了

        //    // 更诡异，加了输出偶尔能正常执行和输出完；注掉的话必然会直接Process is terminated due to StackOverflowException.
        //    Write(index + " ");

        //    // 递归调用  层数过多会异常
        //    // 还是得用循环实现。偷懒试了下用递归，很容易异常，结果不确定
        //    if (got[index] == true)
        //        index = CheckIndex(index);
        //    return index;
        //}

        // 判断花色是不是一样
        static bool IsFlush(Card[] cards)
        {
            if(cards.Length > 1)
            {
                Suit flushSuit = cards[0].suit;
                for (int i = 1; i < cards.Length; i++)
                {
                    if (cards[i].suit != flushSuit)
                        return false;
                }
            }
            return true;
        }
    }
}