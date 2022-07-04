using System;
using System.Linq.Expressions;
using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;

namespace BulkyBook.DataAccess.Repository
{
    public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
    {
        private ApplicationDbContext _db;

        public ShoppingCartRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }      

        public void UpdateCount(ShoppingCart obj, int count)
        {
            obj.Count = count;
            _db.Update(obj);
        }
    }
}

