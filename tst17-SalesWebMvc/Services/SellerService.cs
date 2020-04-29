using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tst17_SalesWebMvc.Models;
using tst17_SalesWebMvc.Data;
using Microsoft.EntityFrameworkCore;
using tst17_SalesWebMvc.Services.Exceptions;

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

        public Seller FindById(int id)
        {
            return _context.Seller.Include(x => x.Department).FirstOrDefault(x => x.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();

        }

        public void Update(Seller obj)
        {
            if (!_context.Seller.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundException("Id not found");
            }
            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }
            catch (DbConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
            
        }
    }
}
