using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tst17_SalesWebMvc.Data;
using tst17_SalesWebMvc.Models;

namespace tst17_SalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly tst17_SalesWebMvcContext _context;

        public DepartmentService(tst17_SalesWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}

