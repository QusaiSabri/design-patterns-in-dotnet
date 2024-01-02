//public class PrinterSpoolerSingleton
//{
//    private static PrinterSpoolerSingleton? _instance;
//    private static readonly object instanceLock = new();

//    private PrinterSpoolerSingleton() { }

//    public static PrinterSpoolerSingleton GetInstance()
//    {
//        if (_instance == null)
//        {
//            lock (instanceLock)
//            {
//                if (_instance == null)
//                {
//                    _instance = new PrinterSpoolerSingleton();
//                }
//            }
//        }
//        return _instance;
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
