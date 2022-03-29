using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbhikumarsBooks.DataAccess.Repository.IRepository
{
    public interface ISP_Call : IDisposable
    {
        T Single<T>(string prodedurename, DynamicParameters param = null);
        void Execute(string produurename, DynamicParameters param = null);
        T OneRecord<T>(string producername, DynamicParameters param = null);
        IEnumerable<T> List<T>(string producername, DynamicParameters param = null);
        Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string producername, DynamicParameters param = null);

    }
}
