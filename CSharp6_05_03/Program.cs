namespace CSharp6_05_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IOutput output = new ConsoleOutput();

            output.Show(); 
            output.Show("Custom message"); 
        }
    }
}
public interface IOutput
{
    void Show();
    void Show(string info);
}

public class ConsoleOutput : IOutput
{
    public void Show()
    {
        Console.WriteLine("Default information");
    }

    public void Show(string info)
    {
        Console.WriteLine($"Information: {info}");
    }
}