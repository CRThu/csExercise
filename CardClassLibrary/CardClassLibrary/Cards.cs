using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClassLibrary
{
    public class Cards : CollectionBase
    {
        // IList
        public void Add(Card newCard)
        {
            List.Add(newCard);
        }
        public void Remove(Card oldCard)
        {
            List.Remove(oldCard);
        }
        public Card this[int cardIndex]
        {
            get { return (Card)List[cardIndex]; }
            set { List[cardIndex] = value; }
        }
        ///<summary>
        /// 复制实例至另一个实例的方法
        /// 在Deck.Shuffle()使用
        ///</summary>
        public void CopyTo(Cards targetCards)
        {
            for (int index = 0; index < this.Count; index++)
                targetCards[index] = this[index];
        }
    }
}
