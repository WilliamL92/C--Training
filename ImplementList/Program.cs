public class Program
{
    static void Main(string[] args)
    { 
        string elem = "William";
        Stack<char> _stacks = new Stack<char>();

        foreach(char letter in elem)
        {
            _stacks.Push(letter);
        }
        Console.WriteLine(_stacks.Count);
        char elemRemoved = _stacks.Pop();
        Console.WriteLine(_stacks.Count);
        Console.WriteLine(elemRemoved);
    }
}