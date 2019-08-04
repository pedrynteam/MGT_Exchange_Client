using MGT_Exchange_Client.GraphQL.MVC;
using MGT_Exchange_Client.GraphQL.Resources;
using SAHB.GraphQLClient.FieldBuilder.Attributes;
using System;
using System.Threading.Tasks;

namespace MGT_Exchange_Client.GraphQL.Mutation
{

    // 1. Create Model: Input type is used for Mutation, it should be included if needed
    public class CreateCompanyAndXUsersTxn_Input
    {        
        public company company { get; set; }
        public int usersToCreate { get; set; }
    }
    
    // 2. Create Model: Output type is used for Mutation, it should be included if needed
    public class CreateCompanyAndXUsersTxn_Output
    {
        public resultConfirmation resultConfirmation { get; set; }
        public company company { get; set; }
    }

    public class CreateCompanyAndXUsersTxn
    {
        [GraphQLArguments("input", "CreateCompanyAndXUsersTxn_Input!", "inputVar")]
        public CreateCompanyAndXUsersTxn_Output createCompanyAndXUsersTxn { get; set; } //  // This is (ReturnType) (QueryName)
    }
}
