//public class PrinterSpoolerSingleton
//{
//    private static readonly Lazy<PrinterSpoolerSingleton> _instance =
//        new Lazy<PrinterSpoolerSingleton>(() => new PrinterSpoolerSingleton());
//    private static readonly object instanceLock = new object();

//    private PrinterSpoolerSingleton() { }

//    public static PrinterSpoolerSingleton GetInstance()
//    {
//        return _instance.Value;
//    }

//    public void Print(string document)
//    {
//        lock (instanceLock)
//        {
//            for (int i = 1; i <= 3; i++)
//            {
//                Console.WriteLine($"Printing page {i} of {document}");
//                Thread.Sleep(100);
//            }
//        }

//        Console.WriteLine(" ");
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        var spooler = PrinterSpoolerSingleton.GetInstance();

//        Thread thread1 = new Thread(() => spooler.Print("Document 1"));
//        Thread thread2 = new Thread(() => spooler.Print("Document 2"));

//        thread1.Start();
//        thread2.Start();

//        thread1.Join();
//        thread2.Join();
//    }
//}
