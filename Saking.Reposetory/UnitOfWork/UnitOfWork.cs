﻿using Sakiny.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakiny.Repository.UnitOfWork
{
    public class UnitOfWork:IUnitOfWork
    {
        Context _context;

        public UnitOfWork(Context context)
        {
            _context = context;

            BeginTransaction();
        }

        public void SaveChanges()
        {
            try
            {
                _context.SaveChanges();
            }
            catch
            {
                _context.Database.CurrentTransaction.Rollback();
            }
        }

        public void CommitChanges()
        {
            try
            {
                _context.SaveChanges();
                _context.Database.CurrentTransaction.Commit();
            }
            catch
            {
                _context.Database.CurrentTransaction.Rollback();
            }
        }

        public void BeginTransaction()
        {
            if (_context.Database.CurrentTransaction is null)
            {
                _context.Database.BeginTransaction();
            }
        }
    }
}
