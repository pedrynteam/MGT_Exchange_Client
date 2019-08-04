using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MGT_Exchange_Client.GraphQL.MVC
{
    public class commentInfo
    {
        //[Key]
        public int commentInfoId { get; set; }

        public DateTime createdAt { get; set; }

        public bool delivered { get; set; }

        public DateTime? deliveredAt { get; set; }

        public bool seen { get; set; }

        public DateTime? seenAt { get; set; }

        // 1 to 1 - Steven Sandersons
        public string userAppId { get; set; }
        //[ForeignKey("UserAppId")]
        //[JsonIgnore] // To avoid circular calls. Customer -> Order -> Customer -> Order
        public virtual userApp user { get; set; }

        // 1 to Many - Steven Sandersons
        public int commentId { get; set; }
        //[ForeignKey("CommentId")]
        [JsonIgnore] // To avoid circular calls. Customer -> Order -> Customer -> Order
        public virtual comment comment { get; set; }

    }
}
