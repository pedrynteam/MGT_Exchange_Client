using SAHB.GraphQLClient.FieldBuilder.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MGT_Exchange_Client.GraphQL.MVC
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string Name { get; set; }

        // 1 to Many - Steven Sandersons
        [GraphQLFieldIgnore] // To avoid bringing the orders when only querying for the customer
        public virtual List<Order> Orders { get; set; }
    }


}
