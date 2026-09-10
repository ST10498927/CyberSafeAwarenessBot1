using System.Media;

namespace CyberSafeAwarenessBot;

public class VoiceGreeting
{
    // Plays the voice greeting.
    public void PlayGreeting()
    {
        string audioPath = Path.Combine(AppContext.BaseDirectory, "Audio", "greeting.wav");

        if (File.Exists(audioPath))
        {
            SoundPlayer player = new SoundPlayer(audioPath);
            player.PlaySync();
        }
    }
}