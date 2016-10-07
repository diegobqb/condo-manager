using CondoManager.Business.Dto;
using CondoManager.Data.Dao;
using CondoManager.Data.Model;

namespace CondoManager.Business.Bo
{
    public class CondoBo
    {
        private CondoDao _dao;

        public void Save(CondoDto dto)
        {
            var entity = new Condo()
            {
                Name = dto.Name
            };

            _dao.Insert(entity);
        }
    }
}
