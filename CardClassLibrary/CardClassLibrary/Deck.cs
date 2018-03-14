using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardClassLibrary
{
    public class Deck
    {
        // private Card[] cards;
        private Cards cards = new Cards();
        public Deck()
        {
            // cards = new Card[52];
            for (int suitVal = 0; suitVal < 4; suitVal++)
                for (int rankVal = 1; rankVal < 14; rankVal++)
                    //cards[suitVal * 13 + rankVal - 1] = new Card((Suit)suitVal, (Rank)rankVal);
                    cards.Add(new Card((Suit)suitVal, (Rank)rankVal));
        }

        public Card GetCard(int cardNum)
        {
            if (cardNum >= 0 && cardNum <= 51)
                return cards[cardNum];
            else
                throw (new System.ArgumentOutOfRangeException("cardNum", cardNum, "Value must be between 0 and 51."));
        }

        public void Shuffle()
        {
            // Card[] newDeck = new Card[52];  // 牌组
            Cards newDeck = new Cards(); 
            bool[] assigned = new bool[52]; // 标记
            Random sourceGen = new Random();    // 随机数组
            for (int i = 0; i < 52; i++)
            {
                // int destCard = 0;
                int sourceCard = 0;
                bool foundCard = false;
                while (foundCard == false)
                {
                    // destCard = sourceGen.Next(52);  // [0,51]区间取随机数
                    sourceCard = sourceGen.Next(52);  // [0,51]区间取随机数
                    // if (assigned[destCard] == false)
                    if (assigned[sourceCard] == false)
                        foundCard = true;
                }
                // assigned[destCard] = true;
                assigned[sourceCard] = true;
                // newDeck[destCard] = cards[i];   // 指定牌放入随机抽到的牌组
                newDeck.Add(cards[sourceCard]);   // 指定牌放入随机抽到的牌组
            }
            // newDeck.CopyTo(cards, 0);   // 0开始复制newDeck -> cards
            newDeck.CopyTo(cards);   // 0开始复制newDeck -> cards
            // cards = newDeck; // 若其他地方代码存在对原cards实例引用, 会出问题
        }
    }
}