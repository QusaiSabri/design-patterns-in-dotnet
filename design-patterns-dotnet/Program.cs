

PrinterSpooler spooler1 = new PrinterSpooler();
PrinterSpooler spooler2 = new PrinterSpooler();

Thread thread1 = new Thread(() => spooler1.Print("Document 1"));
Thread thread2 = new Thread(() => spooler2.Print("Document 2"));
Thread thread3 = new Thread(() => spooler2.Print("Document 3"));
Thread thread4 = new Thread(() => spooler2.Print("Document 4"));
Thread thread5 = new Thread(() => spooler2.Print("Document 5"));


thread1.Start();
thread2.Start();
thread3.Start();
thread4.Start();
thread5.Start();


thread1.Join();
thread2.Join();
thread3.Join();
thread4.Join();
thread5.Join();


public class PrinterSpooler
{
    public void Print(string document)
    {
        Console.WriteLine($"Printing document: {document}");

        if (document == "Document 1")
            Thread.Sleep(100);
        else if (document == "Document 2")
            Thread.Sleep(10);
        else if (document == "Document 3")
            Thread.Sleep(400);
        else if (document == "Document 4")
            Thread.Sleep(200);
        else if (document == "Document 5")
            Thread.Sleep(20);
        else
            Thread.Sleep(100);
    }
}