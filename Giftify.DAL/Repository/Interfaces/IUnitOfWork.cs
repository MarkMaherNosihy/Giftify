﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giftify.DAL.Repository.Interfaces
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }
        IProductRepository Product { get; }
        ICompanyRepostiory Company{ get; }


        void Save();
    }
}
