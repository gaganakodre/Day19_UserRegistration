namespace Day19_UserRegistration
{
    class Program
    {
        public static void Main(string[] args)
        {
            //uc1
            RegexClass regex = new RegexClass();
            regex.ValidateFirstNameRegex("Shreegowri");
            //uc2
            regex.ValidateLastNameRegex("Koder");
            //uc4
            regex.ValidatePhoneNumberRegex("91 8618199771");
            //uc3


            string[] EmailList = { "abc@yohoo.com","abc-100@yohoo.com",
                                    "abc.100@yahoo.com","abc111@abc.com","abc-100@abc.net",
                                     "abc.100@abc.com.au", "abc@1.com","abc","abc@.com.my",
                                    "abc123@gmail.a",
                                     "abc1232.com"
                                     ,".abc@abc.com","abc123.com.my", "abc123@.com.com"};

            regex.ValidateEmailAddressRegex("hdshreegowri");
            foreach (string SampleEmailAddress in EmailList)
            {
                regex.ValidateEmailAddressRegex(SampleEmailAddress);
            }
            
        }
    }
}