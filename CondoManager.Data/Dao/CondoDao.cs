using CondoManager.Data.Context;
using CondoManager.Data.Model;

namespace CondoManager.Data.Dao
{
    public class CondoDao : AbDao<Condo>
    {
        public CondoDao()
            : base(new CondoManagerContext())
        {
        }
    }
}
