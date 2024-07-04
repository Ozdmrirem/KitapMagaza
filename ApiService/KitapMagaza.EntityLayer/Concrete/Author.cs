using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapMagaza.EntityLayer.Concrete
{
    public class Author
    {
        public int AutorId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public string Detail { get; set; }
        public List<Book> Books { get; set; }
    }
}
