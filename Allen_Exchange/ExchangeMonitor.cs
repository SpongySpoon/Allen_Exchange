namespace Allen_Exchange
{
    public class ExchangeMonitor
    {
        double totalAmount;
        int Counter = 0;


        public double Monitor(double placeholder, int choice)
        {
            Counter++;    
            
            if (choice == 1 || choice == 8 || choice == 11)
            {
                placeholder = Allen_Exchange.Exchanger.GBP_USD(placeholder);
                totalAmount = totalAmount + placeholder;
            }
            else if (choice == 3 || choice == 6 || choice == 9)
            {
                placeholder = Allen_Exchange.Exchanger.EUR_USD(placeholder);
                totalAmount = totalAmount + placeholder;
            }
            else if (choice == 2 || choice == 5 || choice == 12)
            {
                placeholder = Allen_Exchange.Exchanger.CAN_USD(placeholder);
                totalAmount = totalAmount + placeholder;
            }

            if(choice == 4)
            {
                totalAmount = totalAmount + placeholder;
            }
            else if(choice == 7)
            {
                totalAmount = totalAmount + placeholder;
            }
            else if(choice == 10)
            {
               totalAmount = totalAmount + placeholder;
            }

            totalAmount = placeholder * choice;
               return totalAmount;
        }

        


    }
}
