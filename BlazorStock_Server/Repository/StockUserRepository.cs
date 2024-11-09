

using AutoMapper;
using BlazorStock.Server.Entities.Models;
using BlazorStock.Server.Repository.IRepository;
using BlazorStock_DataAccess;

namespace BlazorStock.Server.Repository
{
    public class StockUserRepository : IStockUserRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        public StockUserRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public StockUserDTO Create(StockUserDTO objDTO)
        {
            var obj = _mapper.Map<StockUserDTO, StockUser>(objDTO);
            obj.CreatedDate = DateTime.Now;

            var addedObj = _db.StoredUsers.Add(obj);
            _db.SaveChanges();

            return _mapper.Map<StockUser, StockUserDTO>(addedObj.Entity);
        }

        public int Delete(int id)
        {
            var obj = _db.StoredUsers.FirstOrDefault(u => u.UserId == id);
            if (obj != null)
            {
                _db.StoredUsers.Remove(obj);
                return _db.SaveChanges();
            }
            return 0;
        }

        public StockUserDTO Get(int id)
        {
            var obj = _db.StoredUsers.FirstOrDefault(u => u.UserId == id);
            if (obj != null)
            {
                return _mapper.Map<StockUser, StockUserDTO>(obj);
            }
            return new StockUserDTO();
        }

        public IEnumerable<StockUserDTO> GetAll()
        {
            return _mapper.Map<IEnumerable<StockUser>,IEnumerable<StockUserDTO>>(_db.StoredUsers);
        }

        public StockUserDTO Update(StockUserDTO objDTO)
        {
            var objFromDb = _db.StoredUsers.FirstOrDefault(u => u.UserId == objDTO.UserId);
            if(objFromDb != null)
            {
                objFromDb = _mapper.Map<StockUserDTO, StockUser>(objDTO);
                _db.StoredUsers.Update(objFromDb);
                _db.SaveChanges();
                return _mapper.Map<StockUser, StockUserDTO>(objFromDb);
            }
            return objDTO;
        }
    }
}
