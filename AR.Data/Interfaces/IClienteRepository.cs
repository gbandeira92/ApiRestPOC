using System.Linq;
using System.Threading.Tasks;
using AR.Domain;

namespace AR.Data.Interfaces
{
    public interface IClienteRepository
    {
        IQueryable<Cliente> GetAll();
        Task Add(Cliente entity);
    }
}
