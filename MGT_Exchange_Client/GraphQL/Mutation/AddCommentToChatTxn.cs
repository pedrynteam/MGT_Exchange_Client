using MGT_Exchange_Client.GraphQL.MVC;
using MGT_Exchange_Client.GraphQL.Resources;
using SAHB.GraphQLClient.FieldBuilder.Attributes;

namespace MGT_Exchange_Client.GraphQL.Mutation
{
    // 1. Create Model: Input type is used for Mutation, it should be included if needed
    public class AddCommentToChatTxn_Input
    {
        public comment comment { get; set; } // This must be lowercase! from client
    }

    // 2. Create Model: Output type is used for Mutation, it should be included if needed
    public class AddCommentToChatTxn_Output
    {
        public resultConfirmation resultConfirmation { get; set; }
        public comment comment { get; set; }
    }

    public class AddCommentToChatTxn
    {
        [GraphQLArguments("input", "AddCommentToChatTxn_Input!", "inputVar")]
        public AddCommentToChatTxn_Output addCommentToChatTxn { get; set; } //  // This is (ReturnType) (QueryName)
    }

}
