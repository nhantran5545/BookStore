﻿using BookStoreAPI.Core.Interface;
using BookStoreAPI.Core.Model;
using BookStoreAPI.Infracstructure.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreAPI.Infracstructure.Repositories
{
    public class ImportationRepository : GenericRepository<Importation>, IImportationRepository
    {
        public ImportationRepository(DbContextClass context) : base(context)
        {
        }
    }
}
