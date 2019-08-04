using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;
using MGT_Exchange_Client.GraphQL.MVC;
using MGT_Exchange_Client.GraphQL.Resources;
using SAHB.GraphQLClient.FieldBuilder.Attributes;

namespace MGT_Exchange_Client.GraphQL.Mutation
{
    // 1. Create Model: Input type is used for Mutation, it should be included if needed
    public class LoadChatAndUpdateUnseenForUserTxn_Input
    {
        public chat chat { get; set; }
        public userApp user { get; set; }
        public int take { get; set; }
    }

    // 2. Create Model: Output type is used for Mutation, it should be included if needed
    public class LoadChatAndUpdateUnseenForUserTxn_Output
    {
        public resultConfirmation resultConfirmation { get; set; }
        public List<comment> comments { get; set; }
    }

    public class LoadChatAndUpdateUnseenForUserTxn
    {
        [GraphQLArguments("input", "LoadChatAndUpdateUnseenForUserTxn_Input!", "inputVar")]
        public LoadChatAndUpdateUnseenForUserTxn_Output loadChatAndUpdateUnseenForUserTxn { get; set; } //  // This is (ReturnType) (QueryName)
    }
}
