namespace CyberSafeAwarenessBot;

public class Chatbot
{
    private readonly UserProfile userProfile;
    private readonly VoiceGreeting voiceGreeting;
    private readonly AsciiArt asciiArt;
    private readonly ResponseHandler responseHandler;

    public Chatbot()
    {
        userProfile = new UserProfile();
        voiceGreeting = new VoiceGreeting();
        asciiArt = new AsciiArt();
        responseHandler = new ResponseHandler();
    }

    public void Start()
    {
        voiceGreeting.PlayGreeting();
        asciiArt.Display();

        DisplayWelcome();
        GetUserName();
        DisplayPersonalisedWelcome();
        StartConversation();
    }

    private void DisplayWelcome()
    {
        Console.WriteLine("========================================");
        Console.WriteLine("       CYBERSAFE AWARENESS BOT");
        Console.WriteLine("========================================");
        Console.WriteLine();
        Console.WriteLine("Welcome! I am your Cybersecurity Awareness Bot.");
        Console.WriteLine();
    }

    private void GetUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine() ?? "";

        while (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Please enter a valid name.");
            Console.Write("Please enter your name: ");
            name = Console.ReadLine() ?? "";
        }

        userProfile.Name = name;
    }

    private void DisplayPersonalisedWelcome()
    {
        Console.WriteLine();
        Console.WriteLine($"Hello, {userProfile.Name}! Welcome to CyberSafe Awareness Bot.");
        Console.WriteLine("I can help you learn about basic cybersecurity topics.");
        Console.WriteLine();
        Console.WriteLine("You can ask me about:");
        Console.WriteLine("- Password safety");
        Console.WriteLine("- Phishing");
        Console.WriteLine("- Safe browsing");
        Console.WriteLine();
    }

    private void StartConversation()
    {
        while (true)
        {
            Console.Write("You: ");
            string question = Console.ReadLine() ?? "";

            if (string.IsNullOrWhiteSpace(question))
            {
                Console.WriteLine("Bot: Please enter a question.");
                Console.WriteLine();
                continue;
            }

            if (question.ToLower() == "exit")
            {
                Console.WriteLine($"Bot: Goodbye, {userProfile.Name}! Stay safe online.");
                break;
            }

            string response = responseHandler.GetResponse(question);

            Console.WriteLine($"Bot: {response}");
            Console.WriteLine();
        }
    }
}