Console.WriteLine("Hello, Asynchronous programming!");

Task t1 = new(WriteMultipleLines); //no paranthesis just the name; adding paranthesis tells it to execute the method

t1.Start();


Console.WriteLine("Done");

t1.Wait();

Console.WriteLine("Finito");

void WriteMultipleLines() {

    Console.WriteLine("Print first line");

    Console.WriteLine("Print second line");

    Console.WriteLine("Print third line");
}