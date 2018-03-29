using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClassLibrary
{
    public class Card : ICloneable
    {
        // 添加浅度复制
        public object Clone() => MemberwiseClone();

        // 字段属性 - 修饰符 - 常量类型 - readonly
        public readonly Rank rank;
        public readonly Suit suit;

        private Card()
        {
        }

        public Card(Suit newSuit, Rank newRank)
        {
            suit = newSuit;
            rank = newRank;
        }
        // ToString 属性 - 修饰符 - 继承修饰符 - override
        public override string ToString()
        {
            return "The " + rank + " of " + suit + "s";
        }

        /// <summary>
        /// Flag for trump usage. If true, trumps are valued higher than cards of other suits.
        /// </summary>
        public static bool useTrumps = false;
        /// <summary>
        /// Trump suit to use if useTrumps is true.
        /// </summary>
        public static Suit trump = Suit.Club;
        /// <summary>
        /// Flag that determines whether aces are higher than kings or lower than deuces.
        /// </summary>
        public static bool isAceHigh = true;

        // 运算符重载
        public static bool operator ==(Card card1, Card card2)
            => (card1?.suit == card2?.suit) && (card1?.rank == card2?.rank);
        public static bool operator !=(Card card1, Card card2)
            => !(card1 == card2);
        public override bool Equals(object card) => this == (Card)card;
        public override int GetHashCode() => 13 * (int)suit + (int)rank;
        public static bool operator >(Card card1, Card card2)
        {
            if (card1.suit == card2.suit)
            {
                if (isAceHigh)  // 检测使能Ace
                {
                    if (card1.rank == Rank.Ace) // 检测Ace
                    {
                        if (card2.rank == Rank.Ace) // 检测Ace
                            return false;
                        else
                            return true;
                    }
                    else
                    {
                        if (card2.rank == Rank.Ace)
                            return false;
                        else
                            return (card1.rank > card2?.rank);
                    }
                }
                else
                    return (card1.rank > card2.rank);   // 非使能Ace比较
            }
            else
            {
                if (useTrumps && (card2.suit == Card.trump))    // 检测王牌
                    return false;
                else
                    return true;
            }
        }
        public static bool operator <(Card card1, Card card2)
            => !(card1 >= card2);
        public static bool operator >=(Card card1, Card card2)
        {
            if (card1.suit == card2.suit)
            {
                if (isAceHigh)
                {
                    if (card1.rank == Rank.Ace)
                        return true;
                    else
                    {
                        if (card2.rank == Rank.Ace)
                            return false;
                        else
                            return (card1.rank >= card2.rank);
                    }
                }
                else
                    return (card1.rank >= card2.rank);
            }
            else
            {
                if (useTrumps && (card2.suit == Card.trump))
                    return false;
                else
                    return true;
            }
        }
        public static bool operator <=(Card card1, Card card2) => !(card1 > card2);
    }
}
