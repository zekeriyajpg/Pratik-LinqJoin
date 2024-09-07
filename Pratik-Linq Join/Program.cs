using Pratik_Linq_Join; // Namespace definition for the LINQ Join example


// Author sınıfı yazarları tanımlar / Defines authors in the Author class
List<Author> authors = new List<Author>
{
    new Author { AuthorId = 1, Name = "Orhan Pamuk" },// Yazar ID 1 için Orhan Pamuk
    new Author { AuthorId = 2, Name = "Elif Şafak" },// Yazar ID 2 için Elif Şafak
    new Author { AuthorId = 3, Name = "Ahmet Ümit" }// Yazar ID 3 için Ahmet Ümit
};


// Book sınıfı kitapları tanımlar / Defines books in the Book class
List<Book> books = new List<Book>
{
    new Book { BookId = 1, Title = "Kar", AuthorId = 1 },// Kitap ID 1, Orhan Pamuk tarafından yazılmış
    new Book { BookId = 2, Title = "İstanbul", AuthorId = 1 },// Kitap ID 2, Orhan Pamuk tarafından yazılmış
    new Book { BookId = 3, Title = "10 Minutes 38 Seconds in This Strange World", AuthorId = 2 },// Kitap ID 3, Elif Şafak tarafından yazılmış
    new Book { BookId = 4, Title = "Beyoğlu Rapsodisi", AuthorId = 3 }// Kitap ID 4, Ahmet Ümit tarafından yazılmış
};


// LINQ sorgusu ile kitapları yazarlarıyla birleştiriyoruz / Using LINQ to join books with their authors
var query = from book in books
            join author in authors on book.AuthorId equals author.AuthorId
            select new
            {
                BookTitle=book.Title,// Kitap başlığı / Book title
                AuthorName =author.Name// Yazar adı / Author name
            };

// Sonuçları konsola yazdırıyoruz / Outputting the results to the console
foreach (var item in query)
{
    Console.WriteLine($"Kitap : {item.BookTitle}, Yazar : {item.AuthorName}");
}