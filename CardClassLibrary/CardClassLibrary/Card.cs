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
    }
}
