using System;

namespace MagicNumber
{
    public class Stock
    {
        public bool StockTrading(int stockId)
        {
            // 40 == closed, 43 == suspended
            try
            {
                var stock = MyStockRepository.GetStock(stockId);
                if (stock == null || (stock.Status != 40 && stock.Status != 43))
                {
                    return false;
                }
                
                if (stock.Status == 40)
                {
                    DoSomething40();
                }
                else if (stock.Status == 43)
                {
                    DoSomething43();
                }

                return true;
            }
            catch (Exception ex)
            {
                LogService.Error(string.Format("Stock Trading Error. Message : {0}, stockId : {1}", ex.Message, stockId));
                return false;
            }
        }

        private void DoSomething43()
        {
            throw new NotImplementedException();
        }

        private void DoSomething40()
        {
            throw new NotImplementedException();
        }

    }

}