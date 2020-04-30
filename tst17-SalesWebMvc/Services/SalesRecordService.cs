using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tst17_SalesWebMvc.Data;
using tst17_SalesWebMvc.Models;

namespace tst17_SalesWebMvc.Services
{
    public class SalesRecordService
    {
        private readonly tst17_SalesWebMvcContext _context;

        public SalesRecordService(tst17_SalesWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }

            return await result
                        .Include(x => x.Seller)
                        .Include(x => x.Seller.Department)
                        .OrderBy(x => x.Date)
                        .ToListAsync();
        }

    }
}
