using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MGT_Exchange_Client.GraphQL.MVC
{
    public class groupof
    {
        [Key]
        public int groupofId { get; set; }

        [Required]
        public string name { get; set; }

        // 1 to 1 - Steven Sandersons
        public string userAppId { get; set; }
        [ForeignKey("userAppId")]
        [JsonIgnore] // To avoid circular calls. Customer -> Order -> Customer -> Order
        public virtual userApp user { get; set; }

    }
}
