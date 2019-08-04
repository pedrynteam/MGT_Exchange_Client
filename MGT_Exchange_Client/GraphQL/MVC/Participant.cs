using Newtonsoft.Json;

namespace MGT_Exchange_Client.GraphQL.MVC
{
    public class participant
    {
        //[Key]
        public int participantId { get; set; }
        
        public bool isAdmin { get; set; }
        
        // 1 to Many - Steven Sandersons
        public int chatId { get; set; }
        //[ForeignKey("ChatId")]
        [JsonIgnore] // To avoid circular calls. Customer -> Order -> Customer -> Order
        public virtual chat chat { get; set; }

        // 1 to 1 - Steven Sandersons
        public string userAppId { get; set; }
        //[ForeignKey("UserAppId")]
        //[JsonIgnore] // To avoid circular calls. Customer -> Order -> Customer -> Order
        public virtual userApp user { get; set; }
        
    }
}
