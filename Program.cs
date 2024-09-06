using SubStitutePattern;

public class Program
{
    static void Main(string[] args)
    {
        ICar carwithaccesstrue = new CarProxy(true);
        carwithaccesstrue.Start();

        ICar carwithaccessfalse = new CarProxy(false);
        carwithaccessfalse.Start();
    }
}
