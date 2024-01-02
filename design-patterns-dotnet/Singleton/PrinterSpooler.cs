
public class PrinterSpooler
{

    public void Print(string document)
    {
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine($"Printing page {i} of {document}");
            Thread.Sleep(100);
        }
        Console.WriteLine(" ");
    }
}

public class Program
{
    public static void Main()
    {
        var spooler1 = new PrinterSpooler();
        var spooler2 = new PrinterSpooler();


        Thread thread1 = new Thread(() => spooler1.Print("Document 1"));
        Thread thread2 = new Thread(() => spooler2.Print("Document 2"));

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();
    }
}
