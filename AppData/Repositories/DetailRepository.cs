using AppData.Configuration;
using AppData.Model;
using AppData.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppData.Repositories
{
    public class DetailRepository : IDetailRepository
    {
        private readonly RepositoryContext _context;

        public DetailRepository(RepositoryContext context)
        {
            _context = context;
        }

        public Task<List<Detail>> GetAsync()
        {
            var result = _context.Details
                .Where(x=>x.RemoveDate==null)
                .Include(x => x.Employee)
                .ToListAsync();
            return result;
        }

        public Task DeleteAsync(int id, DateTime removeDateTime)
        {
            var detail = _context.Details.SingleOrDefault(x => x.Id == id);
            detail.RemoveDate = removeDateTime;
            return _context.SaveChangesAsync();
        }

        public Task<bool> ExistsAsync(int id)
        {
            return _context.Details.AnyAsync(x => x.Id == id && x.RemoveDate == null);
        }

        public Task AddAsync(Detail detail)
        {
            _context.Details.Add(detail);
            return _context.SaveChangesAsync();
        }

        public Task UpdateAsync(Detail detail)
        {
            var currentDetail = _context.Details.Find(detail.Id);
            detail.CreatedDate = currentDetail.CreatedDate;

            _context.Entry(currentDetail).CurrentValues.SetValues(detail);
            
            return _context.SaveChangesAsync();
        }

        public Task<DateTime> GetCreatedDateByIdAsync(int id)
        {
            return _context.Details.Where(x => x.Id == id).Select(x => x.CreatedDate).FirstAsync();
        }
    }
}
