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
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("========================================");
        Console.WriteLine("       CYBERSAFE AWARENESS BOT");
        Console.WriteLine("========================================");
        Console.ResetColor();

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Bot: Welcome! I am your Cybersecurity Awareness Bot.");
        Console.ResetColor();

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

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("              GET STARTED");
        Console.WriteLine("----------------------------------------");
        Console.ResetColor();

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Bot: Hello, {userProfile.Name}! Welcome to CyberSafe Awareness Bot.");
        Console.WriteLine("Bot: I can help you learn about basic cybersecurity topics.");
        Console.ResetColor();

        Console.WriteLine();
        Console.WriteLine("You can ask me about:");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("  • Password safety");
        Console.WriteLine("  • Phishing");
        Console.WriteLine("  • Safe browsing");
        Console.ResetColor();

        Console.WriteLine();
    }

    private void StartConversation()
    {
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("You: ");
            Console.ResetColor();

            string question = Console.ReadLine() ?? "";

            if (string.IsNullOrWhiteSpace(question))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Bot: Please enter a question.");
                Console.ResetColor();
                Console.WriteLine();
                continue;
            }

            if (question.ToLower() == "exit")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Bot: Goodbye, {userProfile.Name}! Stay safe online.");
                Console.ResetColor();
                break;
            }

            string response = responseHandler.GetResponse(question);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Bot: {response}");
            Console.ResetColor();

            Console.WriteLine();
        }
    }
}