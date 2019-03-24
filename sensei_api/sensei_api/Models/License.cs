using System;

namespace sensei_api.Models 
{     

    public class License   
    {        
        public int id { get; set; }
        public string description { get; set; }         
        public int user_number { get; set; }
        public int storage_limit { get; set; }
        public DateTime creation_date { get; set; }
    }

}
