using System;

namespace Phone
{
    class Phone
    {
        private long phone_number=0;
        private List<string> text_message;

        public Phone(long phonenumber)
        {
            phone_number= phonenumber;
            text_message = new List<string>();

        }

        public void place_call()
        {
            List<string> number_to_call = new List<string>();
            Console.WriteLine($"Dialing... ");
        }
        
        public void place_text()
        {
            Console.WriteLine($"Texting... ");
        }

        public void save_text()
        {
            Console.WriteLine($"");

        }

        public void get_text()
        {

        }

        public void get_number()
        {

        }



    }
}