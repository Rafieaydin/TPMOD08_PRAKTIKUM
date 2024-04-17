// See https://aka.ms/new-console-template for more information

namespace Program;
using Newtonsoft.Json;
using TPMOD08_130222006.BankTransferConfig;
using TPMOD08_130222006.UIConfig;
class Program
{
    static void Main()
    {
       /* String path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName ;
        String jsonString = File.ReadAllText(path + "//bank_transfer_config.json");
        BankTransferConfig config = JsonConvert.DeserializeObject<BankTransferConfig>(jsonString);
        Console.WriteLine("Language: " + config.lang);

        jsonString = JsonConvert.SerializeObject(config);
        File.WriteAllText(path + "//bank_transfer_config.json", jsonString);*/

        UIConfig uiConfig = new UIConfig();
        uiConfig.addConfig();
    }
}
