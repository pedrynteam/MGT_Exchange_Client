using MGT_Exchange_Client.GraphQL.Mutation;
using MGT_Exchange_Client.GraphQL.Query;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MGT_Exchange_Client.GraphQL.Interface
{
    public class MGTClient : IMGTClient
    {
        // <Query> 
        public async Task<QueryAllUsersByCompany_Output> QueryAllUsersByCompany(QueryAllUsersByCompany_Input input)
        {
            QueryAllUsersByCompany_Output output = await new QueryAllUsersByCompany().Execute(input: input);
            return output;
        }

        public async Task<QueryRetrieveMasterInformationByUser_Output> QueryRetrieveRecentChatsByComments(QueryRetrieveMasterInformationByUser_Input input)
        {
            QueryRetrieveMasterInformationByUser_Output output = await new QueryRetrieveMasterInformationByUser().Execute(input: input);
            return output;
        }

        public async Task<QueryRetrieveMasterInformationByUser_Output> QueryRetrieveChatComments(QueryRetrieveMasterInformationByUser_Input input)
        {
            QueryRetrieveMasterInformationByUser_Output output = await new QueryRetrieveMasterInformationByUser().Execute(input: input);
            return output;
        }

        public async Task<QueryChatsByUserMain_Output> QueryChatsByUserMain(QueryChatsByUserMain_Input input)
        {            
            QueryChatsByUserMain_Output output = await new QueryChatsByUserMain().Execute(input: input);
            return output;
        }

        // </Query>
        // <Mutation>
        public async Task<MutationCreateCompanyAndXUsersTxn_Output> MutationCreateCompanyAndXUsersTxn(MutationCreateCompanyAndXUsersTxn_Input input)
        {
            MutationCreateCompanyAndXUsersTxn_Output output = await new MutationCreateCompanyAndXUsersTxn().Execute(input: input);
            return output;
        }
        public async Task<MutationCreateChatTxn_Output> MutationCreateChatTxn(MutationCreateChatTxn_Input input)
        {
            MutationCreateChatTxn_Output output = await new MutationCreateChatTxn().Execute(input: input);
            return output;
        }

        public async Task<MutationAddCommentToChatTxn_Output> MutationAddCommentToChatTxn(MutationAddCommentToChatTxn_Input input)
        {
            MutationAddCommentToChatTxn_Output output = await new MutationAddCommentToChatTxn().Execute(input: input);
            return output;
        }

        




        // </Mutation>

    }

}
