using AutoMapper;
using BlazorStock.Server.Entities;
using BlazorStock.Server.Entities.Models;
using BlazorStock.Server.Repository.IRepository;
using BlazorStock_DataAccess;

namespace BlazorStock.Server.Repository
{
    public class StockTransactionRepository : IStockTransactionRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        public StockTransactionRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        StockTransactionDTO IStockTransactionRepository.Create(StockTransactionDTO objDTO)
        {
            var obj = _mapper.Map<StockTransactionDTO, StockTransaction>(objDTO);
            obj.CreatedDate = DateTime.Now;


            var addedObj = _db.StoredTransactions.Add(obj);
            _db.SaveChanges();

            return _mapper.Map<StockTransaction, StockTransactionDTO>(addedObj.Entity);
        }

        int IStockTransactionRepository.Delete(int id)
        {
            var obj = _db.StoredTransactions.FirstOrDefault(u => u.TransactionId == id);
            if (obj != null)
            {
                _db.StoredTransactions.Remove(obj);
                return _db.SaveChanges();
            }
            return 0;
        }

        StockTransactionDTO IStockTransactionRepository.Get(int id)
        {
            var obj = _db.StoredTransactions.FirstOrDefault(u => u.UserId == id);
            if (obj != null)
            {
                return _mapper.Map<StockTransaction, StockTransactionDTO>(obj);
            }
            return new StockTransactionDTO();
        }

        IEnumerable<StockTransactionDTO> IStockTransactionRepository.GetAll()
        {
            return _mapper.Map<IEnumerable<StockTransaction>, IEnumerable<StockTransactionDTO>>(_db.StoredTransactions);
        }

        StockTransactionDTO IStockTransactionRepository.Update(StockTransactionDTO objDTO)
        {
            var objFromDb = _db.StoredTransactions.FirstOrDefault(u => u.TransactionId == objDTO.TransactionId);
            if (objFromDb != null)
            {
                objFromDb = _mapper.Map<StockTransactionDTO, StockTransaction>(objDTO);
                _db.StoredTransactions.Update(objFromDb);
                _db.SaveChanges();
                return _mapper.Map<StockTransaction, StockTransactionDTO>(objFromDb);
            }
            return objDTO;
        }
    }
}
