using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_Linq_Join
{
    public class Author
    {
        // Yazarın kimliğini temsil eder / Represents the author's ID
        public int AuthorId { get; set; }

        // Yazarın adını temsil eder / Represents the author's name
        public string Name { get; set; }
    }

    public class Book
    {
        // Kitabın kimliğini temsil eder / Represents the book's ID
        public int BookId { get; set; }

        // Kitabın başlığını temsil eder / Represents the book's title
        public string Title { get; set; }

        // Kitabın yazarını belirtmek için yazar kimliği / Author's ID to associate with the book
        public int AuthorId { get; set; }
    }
}
