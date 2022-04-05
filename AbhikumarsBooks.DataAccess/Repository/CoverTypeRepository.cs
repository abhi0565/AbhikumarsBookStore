﻿using AbhikumarsBooks.DataAccess.Repository.IRepository;
using AbhikumarsBooks.Models;
using AbhikumarsBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbhikumarsBooks.DataAccess.Repository
{

    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CoverType CoverType)
        {
            // use .NET LINQ to retrieve the first or default category object
            // then pass the id as a generic entity which matches the Category ID
            var objFromDb = _db.CoverTypes.FirstOrDefault(s => s.Id == CoverType.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = CoverType.Name;

            }

        }
    }


}