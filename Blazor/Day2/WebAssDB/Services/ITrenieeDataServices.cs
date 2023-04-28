using System.Collections;
using TranieeLibrary;

namespace WebAssDB.Services
{
    public interface ITrenieeDataServices
    {
        Task<IEnumerable<Treniee>> GetAllTreniees();
        Task<Treniee> GetTrenieeDetails(int trenieeId);
        Task AddTreniee(Treniee treniee);
        Task UpdateTreniee(Treniee treniee);

        Task DeleteTreniee(int trenieeId);



    }
}
