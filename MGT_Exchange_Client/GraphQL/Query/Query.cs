using MGT_Exchange_Client.GraphQL.MVC;
using SAHB.GraphQLClient.FieldBuilder.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MGT_Exchange_Client.GraphQL.Query
{
    
    public class QueryCustomerByIds
    {
        // Take this information from the Schema in the playground
        [GraphQLArguments("customerIds", "[ID!]", "customerIdsVar")]
        //[GraphQLArguments()]
        public List<Customer> customerByIds { get; set; } //  // This is case sensitive (ReturnType) (QueryName) 
    }

    public class QueryChat
    {
        // Take this information from the Schema in the playground
        [GraphQLArguments("id", "IntType!", "idVar")]
        public chat chat { get; set; } //  // This is case sensitive (ReturnType) (QueryName) 
    }

}
