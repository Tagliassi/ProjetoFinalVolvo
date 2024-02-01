using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VolvoFinalProject.Api.RepositoryInterfaces;

namespace VolvoFinalProject.Api.Models
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProjectContext _context;

        public UnitOfWork(ProjectContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void RollBack()
        {
            throw new NotImplementedException();
        }
    }
}