namespace Task5;

public class Stack<T>
{    
    List<T>_list=new List<T>(); 
public void Push(T item)
{
_list.Add(item);
} 
public List<T> Pop()
{  
     var delete =_list.FirstOrDefault(_list[_list.Count-1]); 
     _list.Remove(_list[_list.Count-1]); 
     return delete;
} 
public List<T> Peek()
{
    return _list.FirstOrDefault(a=>a==_list[_list.Count-1]);
}
}
