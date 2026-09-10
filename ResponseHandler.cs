namespace CyberSafeAwarenessBot;

public class ResponseHandler
{
    public string GetResponse(string question)
    {
        string input = question.ToLower();

        if (input.Contains("how are you"))
        {
            return "I'm doing well, thank you! I'm ready to help you learn about cybersecurity.";
        }

        if (input.Contains("purpose") || input.Contains("what do you do"))
        {
            return "My purpose is to help you understand basic cybersecurity and stay safer online.";
        }

        if (input.Contains("what can i ask") || input.Contains("what can i learn"))
        {
            return "You can ask me about password safety, phishing, and safe browsing.";
        }

        if (input.Contains("password"))
        {
            return "Use strong, unique passwords for your accounts. Avoid using personal information, and consider using a password manager to help manage your passwords.";
        }

        if (input.Contains("phishing"))
        {
            return "Phishing is when criminals try to trick you into giving away information through fake emails, messages, or websites. Check the sender and links carefully before clicking.";
        }

        if (input.Contains("safe browsing") || input.Contains("browsing"))
        {
            return "For safer browsing, use trusted websites, check that the website address is correct, avoid suspicious links, and keep your browser and security software updated.";
        }

        return "I'm sorry, I don't have an answer for that yet. Try asking me about passwords, phishing, safe browsing, or my purpose.";
    }
}