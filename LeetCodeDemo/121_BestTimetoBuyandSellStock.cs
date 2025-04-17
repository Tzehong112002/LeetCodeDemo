using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDemo
{
    public class _121_BestTimetoBuyandSellStock
    {
        //static void Main(string[] args)
        //{
        //   int[] prices1 = { 7, 1, 5, 3, 6, 4 };
        //    int[] prices2 ={ 7, 6, 4, 3, 1 };
        //    int maxProfit = MaxProfit(prices1);
        //    Console.WriteLine("Max Profit: " + maxProfit);


        //}

        #region Method1
        public static int MaxProfit(int[] prices)
        {
            int buyPriced = prices[0];
            int sellPrice = 0;
            int maxProfit = 0;


            for (int i = 0; i < prices.Length; i++)
            {
                if (buyPriced > prices[i])
                {
                    buyPriced = prices[i];
                }

                if (((prices[i] - buyPriced) > 0) && (prices[i] - buyPriced) > maxProfit)
                {
                    sellPrice = prices[i];
                    maxProfit = sellPrice - buyPriced;
                }

            }

            //return value
            if (maxProfit <= 0)
            {
                return 0;
            }
            else { return maxProfit; }
        
            
        }

        #endregion
    }
}
