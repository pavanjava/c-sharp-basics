namespace tutorial;

public class CallingWithInstance
{
    static void Main(String[] args)
    {
        CallingWithInstance callingWithInstance = new CallingWithInstance();
        Message message = new Message();
        callingWithInstance.DisplayMessage(message);
        DisplayStaticMessage();
    }

    void DisplayMessage(Message message)
    {
        Console.WriteLine("Calling the display method of Message class");
        message.DisplayMessage("Test message to display");
    }

    static void DisplayStaticMessage()
    {
        Console.WriteLine("This is a static message from static method");
    }
}
