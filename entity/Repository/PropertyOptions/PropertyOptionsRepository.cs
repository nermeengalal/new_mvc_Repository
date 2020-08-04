using entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Repository.PropertyOptions
{
    public class PropertyOptionsRepository : IPropertyOptionsRepository
    {
        private TASKEntities _context;
        public PropertyOptionsRepository(TASKEntities context)
        {
            _context = context;
        }
        public void Add(Property_Options entity)
        {
            _context.Property_Options.Add(entity);
            _context.SaveChanges();
        }

        public List<Property_Options> GetAll(int PropId)
        {
            return _context.Property_Options.ToList();
        }
    }
}
