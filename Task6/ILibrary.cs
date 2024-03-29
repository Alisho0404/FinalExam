﻿namespace Task6;

public interface ILibrary
{
public void AddBook(Book book); 
public List<Book> DisplayBook(); 
public void UpdateBook(Book book); 
public void DeleteBook(int id); 
public Book SearchByTitle(string title); 
public Book SearchByAuthor(string author); 
}
