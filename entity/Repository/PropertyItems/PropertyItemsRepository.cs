using entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Repository.PropertyItems
{
    public class PropertyItemsRepository : IPropertyItemsRepository
    {

        private TASKEntities _context;
        public PropertyItemsRepository(TASKEntities context)
        {
            _context = context;
        }
        public void add(Property_Items prop)
        {
            _context.Property_Items.Add(prop);
            _context.SaveChanges();
        }

        public List<Property_Items> GetAll(int CatId)
        {
            return _context.Property_Items.Where(x => x.Category_ID == CatId).ToList();
        }
    }
}
