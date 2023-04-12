// See https://aka.ms/new-console-template for more information
using jurnalmod8_1302210063;
using System.Text.Json;

internal class program
{
    private static void Main(string[] args)
    {
        BankTransferConfig config = new BankTransferConfig();
        config = JsonSerializer.Deserialize<BankTransferConfig>(File.ReadAllText("../../bank_transfer_config.json"));
        if (config.lang == "en")
        {
            Console.WriteLine("Please insert the amount of money to transfer : ");
        }
        else
        {
            Console.WriteLine("Masukkan jumlah uang yang akan di-transfer : ");
        }
        var tf = Convert.ToInt64(Console.ReadLine());
        if(tf <= config.transfer.threshold)
        {
            if (config.lang == "en"){
                Console.WriteLine("Transfer fee = " + config.transfer.low_fee);
                Console.WriteLine("Total amount feee = "+(config.transfer.low_fee+tf));
            }
            else
            {
                Console.WriteLine("Biaya transfer = "+ config.transfer.low_fee);
                Console.WriteLine("Total biaya = "+ (config.transfer.low_fee+tf));
            }
        }
        else
        {
            if(config.lang == "en")
            {
                Console.WriteLine("Transfer fee = " + config.transfer.high_fee);
                Console.WriteLine("Total amount feee = " + (config.transfer.high_fee + tf));
            }
            else
            {
                Console.WriteLine("Biaya transfer = " + config.transfer.high_fee);
                Console.WriteLine("Total biaya = " + (config.transfer.high_fee + tf));
            }
        }
        if(config.lang == "en")
        {
            Console.WriteLine("Select transfer method : ");
        }
        else
        {
            Console.WriteLine("Pilih metode transfer : ");
        }
        var i = 1;
        foreach(var item in config.methods)
        {
           Console.WriteLine($"{i++}: {item}");
        }
        var idx = Convert.ToInt16(Console.ReadLine());

    
    }
}

