namespace api.Models
{
    public class Driver
    {
        public string Id {get;set;}
        public string name {get; set;}
        public DateTime dateHired {get;set;}
        public string rating {get; set;}
        public Driver(){
            Id = Guid.NewGuid().ToString();
            dateHired = dateTime.Now;
        }

        public override string ToString()
        {
            return ($"Driver name : {name} Id : {Id} DOH : {dateHired} Ratnig : {rating}"); 
            
        }
    }
}