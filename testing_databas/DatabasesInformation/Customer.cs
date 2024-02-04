namespace DatabasesInformation
{
    //this class ==> is a table fór the customer information. 
    public class Customer
    {
        public int customerId {  get; set; } // create an id number for each customer
        public string firstName { get; set; } // the first name for the customer 
        public string lastName { get; set; } // last name for the customer 
        public string email { get; set; } // email 
        public string phone { get; set; } // phone number 
        public string city { get; set; } // the city 
        public string state { get; set; }
        public string zipcode { get; set; }
        public string country { get; set; }

        // all this information is a column in the table 

        // because one customer can have many bills to pay so we need a list for each customer and their bill 
       public List<Topay> Topays { get; set; } = new List<Topay>();
    }
}
