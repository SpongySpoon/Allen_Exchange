namespace Allen_Exchange
{
    public static class Exchanger
    {
        static double GBP;
        static double CAN;
        static double EUR;
        static double USD;

       public static double USD_GBP(double USD)
        {
            GBP = USD * 0.72523;
            return GBP;
        }


       public static double USD_CAN(double USD)
        {
            CAN = USD * 1.25427;
            return CAN;
        }


       public static double USD_EUR(double USD)
        {
            EUR = USD * 0.83572;
            return EUR;
        }



       public static double GBP_USD(double GBP)
        {
            USD = GBP * 1.37887;
            return USD;
        }


        public static double GBP_CAN(double GBP)
        {
            CAN = GBP * 1.72947;
            return CAN;
        }

       public static double GBP_EUR(double GBP)
        {
            EUR = GBP * 1.15195;
            return EUR;
        }


        public static double CAN_USD(double CAN)
        {
            USD = CAN * 0.79728;
            return USD;
        }


       public static double CAN_GBP(double CAN)
        {
            GBP = CAN * 0.57848;
            return GBP;
        }
        public static double CAN_EUR(double CAN)
        {
            EUR = CAN * 0.66645;
            return EUR;
        }



        public static double EUR_USD(double EUR)
        {
            USD = EUR * 1.19648;
            return USD;
        }


        public static double EUR_GBP(double EUR)
        {
            GBP = EUR * 0.86826;
            return GBP;
        }
       public static double EUR_CAN(double EUR)
        {
            CAN = EUR * 1.50040;
            return CAN;
        }



    }
}




