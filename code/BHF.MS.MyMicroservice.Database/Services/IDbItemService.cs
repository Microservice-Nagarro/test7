using BHF.MS.test7.Database.Models.DbItem;

namespace BHF.MS.test7.Database.Services
{
    public interface IDbItemService
    {
        public Task<IList<DbItemDto>> GetAll();

        public Task<DbItemDto?> GetById(Guid id);

        public Task<bool> Update(DbItemDto model);

        public Task<DbItemDto> Add(DbItemCreateDto model);

        public Task<bool> Delete(Guid id);
    }
}
