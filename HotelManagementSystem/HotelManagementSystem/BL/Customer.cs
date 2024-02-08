using HotelManagementSystem.DL;
namespace HotelManagementSystem.BL
{
    class Customer:Users
    {
        private string serviceRating;
        private string foodRating;
        private string environmentRating;

        public string Service { get { return serviceRating; } set { serviceRating = value; } }
        public string Food { get { return foodRating; } set { foodRating = value; } }
        public string Environment { get { return environmentRating; } set { environmentRating = value; } }


        public Customer(string serviceRating, string foodRating, string environmentRating)
        {
            this.serviceRating = serviceRating;
            this.foodRating = foodRating;
            this.environmentRating = environmentRating;
        }

        public string GetServiceRating()
        {
            return this.serviceRating;
        }

        public string GetFoodRating()
        {
            return this.foodRating;
        }

        public string GetEnvironmentRating()
        {
            return this.environmentRating;
        }

        public static float BillDivider(float totalbill, int peoplecount)
        {
            float divided_bill;
            divided_bill = totalbill / peoplecount;
            return divided_bill;
        }


        public static float TipCalculator( float totalBill, float totalMoney, float percentTip)
        {
            float remaining = totalMoney - totalBill;

            if (remaining >= 0 && percentTip <= 100)
            {
                float remainingAfter = remaining - ((percentTip / 100) * remaining);
                return remaining - remainingAfter;
            }

            return 0;
        }

        public static bool DeleteReview(int number)
        {
            if(number > 0 && number <= CustomerDL.customers.Count)
            {
                CustomerDL.customers.RemoveAt(number - 1);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
