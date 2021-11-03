using System;
using System.Threading.Tasks;
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;

namespace AzureSpeech
{
    class Program
    {
        static async Task Main()
        {
            //Console.WriteLine("Hello World!");
            await SynthesizeAudioAsync();
        }

        static async Task SynthesizeAudioAsync()
        {
            var config = SpeechConfig.FromSubscription("d26c04ea839940339182a8f7d4a09c54", "eastus");
            //to change language
            //config.SpeechSynthesisLanguage = "en-GB";


            //To save audio into file.
            AudioConfig audioConfig = AudioConfig.FromWavFileOutput("C:/audio.wav");
            using var synthesizer = new SpeechSynthesizer(config, audioConfig);

           // using var synthesizer = new SpeechSynthesizer(config);
            await synthesizer.SpeakTextAsync("Synthesizing directly to speaker output");
        }
    }
}
