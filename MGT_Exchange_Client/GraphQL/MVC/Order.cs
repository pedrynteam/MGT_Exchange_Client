using Newtonsoft.Json;
using SAHB.GraphQLClient.FieldBuilder.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MGT_Exchange_Client.GraphQL.MVC
{
    public class Order
    {
        
        public int OrderId { get; set; }

        public string Name { get; set; }

        // 1 to Many - Steven Sandersons
        public int CustomerId { get; set; }
        [JsonIgnore] // To avoid circular calls. Customer -> Order -> Customer -> Order
        [GraphQLFieldIgnore] // avoid circular calls. Customer -> Order -> Customer -> Order 
        public virtual Customer Customer { get; set; }

    }
}
