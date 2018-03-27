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
    }
}
