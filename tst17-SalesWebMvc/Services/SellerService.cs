using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tst17_SalesWebMvc.Models;
using tst17_SalesWebMvc.Data;

namespace tst17_SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly tst17_SalesWebMvcContext _context;

        public SellerService(tst17_SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
