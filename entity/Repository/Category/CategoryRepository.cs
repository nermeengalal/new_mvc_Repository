
using entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Repository.Category
{
    public class CategoryRepository : ICategoryRepository
    {
        private TASKEntities _context;
        public CategoryRepository(TASKEntities context)
        {
            _context = context;
        }
        public void add(Device_Categories model)
        {
            _context.Device_Categories.Add(model);
            _context.SaveChanges();
        }

        public Device_Categories get(int id)
        {
            var entity = _context.Device_Categories.SingleOrDefault(x => x.ID == id);
            return entity;
        }

        public List<Device_Categories> GetAll()
        {
            var entities = _context.Device_Categories.ToList();
            return entities;
        }
    }
}
