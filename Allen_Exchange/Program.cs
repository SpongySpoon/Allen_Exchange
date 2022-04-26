// See https://aka.ms/new-console-template for more information



Console.WriteLine("Enter the amount you want converted\n");

int userInput = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("1 = USDtoGBP\n 2 = USDtoCAN\n 3 = USDtoEUR\n 4 = GBPtoUSD\n 5 = GBPtoCAN\n 6 = GBPtoEUR\n 7 = CANtoUSD\n 8 = CANtoGBP\n 9 = CANtoEUR\n 10 = EURtoUSD\n 11 = EURtoGBP\n 12 = EURtoCAN\n");
int userChoice = Convert.ToInt32(Console.ReadLine());

Allen_Exchange.ExchangeMonitor exchangeMonitor = new Allen_Exchange.ExchangeMonitor();
double placeholder;
if (userChoice == 1)
{

    placeholder = Allen_Exchange.Exchanger.USD_GBP(userInput);
    exchangeMonitor.Monitor(placeholder, userChoice);
    return;

} else if (userChoice == 2)
{
    placeholder = Allen_Exchange.Exchanger.USD_CAN(userInput);
   exchangeMonitor.Monitor(placeholder, userChoice);
    return;
}
else if (userChoice == 3)
{
    placeholder = Allen_Exchange.Exchanger.USD_EUR(userInput);
    exchangeMonitor.Monitor(placeholder, userChoice);
    return;
}
else if (userChoice == 4)
{
    placeholder = Allen_Exchange.Exchanger.GBP_USD(userInput);
   exchangeMonitor.Monitor(placeholder, userChoice);
    return;
}
else if (userChoice == 5)
{
    placeholder = Allen_Exchange.Exchanger.GBP_CAN(userInput);  
    exchangeMonitor.Monitor(placeholder, userChoice);
    return;
}
else if (userChoice == 6)
{
    placeholder = Allen_Exchange.Exchanger.GBP_EUR(userInput);  
    exchangeMonitor.Monitor(placeholder, userChoice);
    return;
}
else if (userChoice == 7)
{
    placeholder = Allen_Exchange.Exchanger.CAN_USD(userInput);
    exchangeMonitor.Monitor(placeholder, userChoice);
    return;
}
else if (userChoice == 8)
{
    placeholder = Allen_Exchange.Exchanger.CAN_GBP(userInput);
    exchangeMonitor.Monitor(placeholder, userChoice);
    return;
}
else if (userChoice == 9)
{
    placeholder = Allen_Exchange.Exchanger.CAN_EUR(userInput);  
    exchangeMonitor.Monitor(placeholder, userChoice);
    return;
}
else if (userChoice == 10)
{
    placeholder = Allen_Exchange.Exchanger.EUR_USD(userInput);
    exchangeMonitor.Monitor(placeholder, userChoice);
    return;
}
else if (userChoice == 11)
{
    placeholder = Allen_Exchange.Exchanger.EUR_GBP(userInput);
    exchangeMonitor.Monitor(placeholder, userChoice);
    return;
}
else if(userChoice == 12)
{
    placeholder = Allen_Exchange.Exchanger.EUR_CAN(userInput);
    exchangeMonitor.Monitor(placeholder, userChoice);
    return;
}







