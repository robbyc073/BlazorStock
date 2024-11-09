using BlazorStock.Server.Entities.Models;

namespace BlazorStock.Server.Repository.IRepository
{
    public interface IStockUserRepository
    {
        public StockUserDTO Create(StockUserDTO obj);
        public StockUserDTO Update(StockUserDTO obj);
        public int Delete (int id);
        public StockUserDTO Get (int id);
        public IEnumerable<StockUserDTO> GetAll ();
    }
}
