using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interface
{
    public interface IRepository<T>
    {
        public void Insert(T element, bool UpdateToNull = false);
        public void InsertMany(IEnumerable<T> elements);
        public void Update(T element, bool UpdateToNull = false);
        public void HardDelete(T element);
        public void HardDeleteById(Guid Id);
        public Task HardDeleteByIdAsync(Guid id);
    }
}
