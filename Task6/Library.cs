namespace Task6;

public class Library : ILibrary
{ 
    List<Book>_books=new List<Book>();
    public void AddBook(Book book)
    {
        _books.Add(book);
        System.Console.WriteLine("Book succesfully added"); 

    }

    public void DeleteBook(int id)
    {
          
          try
          {
            var delete=_books.FirstOrDefault(a=>a.Id==id); 
            _books.Remove(delete); 
            System.Console.WriteLine("Book succesfully deleted"); 

          }
          catch (System.Exception)
          {
            
             System.Console.WriteLine("Book not found");
          }
    }

    public List<Book> DisplayBook()
    {
        return _books;
    }

    public Book SearchByAuthor(string author)
    {
        var avtor =_books.FirstOrDefault(a=>a.Author==author); 
        return avtor;
    }

    public Book SearchByTitle(string title)
    {
        var kitob =_books.FirstOrDefault(a=>a.Title==title); 
        return kitob;
    }

    public void UpdateBook(Book book)
    { 
         
        try
        { 
            var kitob =_books.FirstOrDefault(a=>a.Id==book.Id); 
           kitob.Author=book.Author; 
            kitob.Title=book.Title; 
            System.Console.WriteLine("Book succesfully updated"); 
        }
        catch (System.Exception)
        {
            System.Console.WriteLine("Book not found");

        }
                 
    }
}
