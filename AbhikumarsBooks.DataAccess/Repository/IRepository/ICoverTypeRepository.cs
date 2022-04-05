using System;
using AbhikumarsBooks.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbhikumarsBooks.DataAccess.Repository.IRepository
{
   
        public interface ICoverTypeRepository : IRepository<CoverType>
        {
            void Update(CoverType CoverType);
        }
    
}
