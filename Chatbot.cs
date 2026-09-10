namespace CyberSafeAwarenessBot;

public class Chatbot
{
    private readonly UserProfile userProfile;

    public Chatbot()
    {
        userProfile = new UserProfile();
    }

    public void Start()
    {
        Console.WriteLine("CyberSafe Awareness Bot");
        Console.WriteLine("Chatbot started successfully.");
    }
}