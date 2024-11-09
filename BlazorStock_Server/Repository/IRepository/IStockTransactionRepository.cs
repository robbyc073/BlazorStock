using BlazorStock.Server.Entities.Models;

namespace BlazorStock.Server.Repository.IRepository
{
    public interface IStockTransactionRepository
    {
        public StockTransactionDTO Create(StockTransactionDTO objDTO);
        public StockTransactionDTO Update(StockTransactionDTO objDTO);
        public int Delete(int id);
        public StockTransactionDTO Get(int id);
        public IEnumerable<StockTransactionDTO> GetAll();
    }
}
