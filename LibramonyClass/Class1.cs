using Newtonsoft.Json;
using System.Net;
namespace LibramonyClass
{
    public class Saver
    {
        public static void Serialize<T>(T wordony)
        {
            string json = JsonConvert.SerializeObject(wordony);
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            File.WriteAllText($"{desktop}\\SerialTest.txt", json);
        }

        public static T Deserialize<T>(string way)
        {
            string json = File.ReadAllText(way);
            T self = JsonConvert.DeserializeObject<T>(json);
            return self;
        }
    }
}
    
