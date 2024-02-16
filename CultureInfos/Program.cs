using System.Globalization;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace CultureInfos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Builder = new PromptBuilder();
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            string Gapir = Console.ReadLine();


            Builder.StartVoice(new CultureInfo("en-US"));
            Builder.EndVoice();
            Builder.AppendText(Gapir);


            Builder.StartVoice(new CultureInfo("uz-UZ"));
            Builder.EndVoice();
            Builder.AppendText("Uzbekcha Gapiraman");
            synth.Speak(Builder);
            //Console.ReadKey();
        }
    }
}
            //DateTime dateTime = DateTime.Now;
            //CultureInfo culture = CultureInfo.GetCultureInfo("en-US");
            //string Time = dateTime.ToString("dddd,dd MMM yyyy",culture);
            //Console.WriteLine(Time);