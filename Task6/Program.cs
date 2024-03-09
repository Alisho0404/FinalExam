using Task6;

var book1=new Book();
book1.Id=1;
book1.Author="Hal"; 
book1.Title="Miracle morning"; 

var book2=new Book();
book2.Id=2;
book2.Author="Hal"; 
book2.Title="Power of morning"; 

var book3=new Book();
book3.Id=3;
book3.Author="Firdavsi"; 
book3.Title="Shohnoma"; 

var book4=new Book();
book4.Id=4;
book4.Author="Firdavsi"; 
book4.Title="Layli and Majnun";  




var library=new Library(); 
library.AddBook(book1); 
library.AddBook(book2);
library.AddBook(book3);
library.AddBook(book4); 

// foreach (var item in library.DisplayBook())
// {
//     System.Console.WriteLine(item.Id);
//     System.Console.WriteLine(item.Author); 
//     System.Console.WriteLine(item.Title); 
//     System.Console.WriteLine("=================================");
// }  

var book5=new Book();
book5.Id=4;
book5.Author="Firdavsi"; 
book5.Title="Yusuf and zulaykho"; 
library.UpdateBook(book5);
