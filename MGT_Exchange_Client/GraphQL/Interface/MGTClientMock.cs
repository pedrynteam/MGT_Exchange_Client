using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MGT_Exchange_Client.GraphQL.Mutation;
using MGT_Exchange_Client.GraphQL.MVC;
using MGT_Exchange_Client.GraphQL.Query;
using MGT_Exchange_Client.GraphQL.Resources;

namespace MGT_Exchange_Client.GraphQL.Interface
{
    public class MGTClientMock : IMGTClient
    {
        List<chat> _chats;
        company _company;
        public MGTClientMock()
        {
            _chats = new List<chat>();

            _company = new company { name = "Company A" };

            int totalChats = 10;
            for (int x = 0; x < totalChats; x++)
            {
                chat chatIn = new chat
                {
                    chatId = x,
                    name = "Chat Name " + Convert.ToString(x),
                    description = "Chat Desc " + Convert.ToString(x),
                    createdAt = DateTime.Now.AddMinutes(20),
                    updatedAt = DateTime.Now,
                    company = _company
                };

                int totalUsers = 5;
                List<participant> participants = new List<participant>();

                for (int y = 0; y < totalUsers; y++)
                {
                    String userApp = "userAppId" + Convert.ToString(y);

                    participants.Add(new participant
                    {
                        chatId = x,
                        isAdmin = false,
                        user = new userApp
                        {
                            userAppId = userApp,
                            id = y,
                            firstName = "First" + Convert.ToString(y),
                            lastName = "Last" + Convert.ToString(y),
                            userName = "username" + Convert.ToString(y),
                            nickname = "Nickname" + Convert.ToString(y),
                            alias = "Alias" + Convert.ToString(y),
                            lastSeen = DateTime.Now.AddMinutes(-10),
                            active = true,
                            department = new department
                            {
                                name = "Department " + Convert.ToString(y)
                            },
                            groups = new List<groupof>
                            {
                                new groupof { name = "Group A"},
                                new groupof { name = "Group B"},
                                new groupof { name = "Group C"}
                            }

                        }
                    }
                    );
                }// for (int y = 0; y < totalUsers; y++)

                chatIn.participants = participants;

                int totalcomments = 5;
                List<comment> comments = new List<comment>();
                for (int z = 0; z < totalcomments; z++)
                {
                    String userApp = "userAppId" + Convert.ToString(z);
                    comments.Add(
                        new comment
                        {
                            commentId = z,
                            seenByAll = false,
                            createdAt = DateTime.Now.AddMinutes(-10),
                            message = "Message " + Convert.ToString(z),
                            chatId = x,
                            userAppId = userApp
                        }
                        );
                }// for (int z = 0; z < totalcomments; z++)

                chatIn.comments = comments;

                _chats.Add(chatIn);

            } // for (int x = 0; x < totalChats; x++)
        }
        // <Query>

        public async Task<QueryAllUsersByCompany_Output> QueryAllUsersByCompany(QueryAllUsersByCompany_Input input)
        {
            await Task.Delay(1);
            _company.users = new List<userApp>();
            foreach (var cha in _chats)
            {                
                foreach (var pa in cha.participants)
                {
                    _company.users.Add(pa.user);
                }
            }

            QueryAllUsersByCompany_Output output = new QueryAllUsersByCompany_Output
            {
                ResultConfirmation = new resultConfirmation { resultPassed = true, resultMessage = "OK" },
                company = _company
            };

            return output;
        }

        public async Task<QueryChatsByUserMain_Output> QueryChatsByUserMain(QueryChatsByUserMain_Input input)
        {
            await Task.Delay(1);

            QueryChatsByUserMain_Output output = new QueryChatsByUserMain_Output
            {
                ResultConfirmation = new resultConfirmation { resultPassed = true, resultMessage = "OK" },
                Chats = _chats
            };            
            return output;            
        }

        public async Task<QueryRetrieveMasterInformationByUser_Output> QueryRetrieveChatComments(QueryRetrieveMasterInformationByUser_Input input)
        {
            await Task.Delay(1);

            List <comment> _commentsSeen = _chats.FirstOrDefault().comments.Skip(0).Take(2).ToList();
            List<comment> _commentsUnseen = _chats.FirstOrDefault().comments.Skip(2).Take(2).ToList();
            List<comment> _commentsNewest = _chats.FirstOrDefault().comments.Skip(4).Take(2).ToList();

            QueryRetrieveMasterInformationByUser_Output output = new QueryRetrieveMasterInformationByUser_Output
            {
                ResultConfirmation = new resultConfirmation { resultPassed = true, resultMessage = "OK" },
                commentsNewest = _commentsNewest,
                commentsSeen = _commentsSeen,
                commentsUnseen = _commentsUnseen
            };

            return output;
        }

        public Task<QueryRetrieveMasterInformationByUser_Output> QueryRetrieveRecentChats(QueryRetrieveMasterInformationByUser_Input input)
        {
            throw new NotImplementedException();
        }

        public Task<QueryRetrieveMasterInformationByUser_Output> QueryRetrieveRecentChatsByComments(QueryRetrieveMasterInformationByUser_Input input)
        {
            throw new NotImplementedException();
        }

        // </Query>
        // <Mutation>
        public Task<MutationAddCommentToChatTxn_Output> MutationAddCommentToChatTxn(MutationAddCommentToChatTxn_Input input)
        {
            throw new NotImplementedException();
        }

        public Task<MutationCreateChatTxn_Output> MutationCreateChatTxn(MutationCreateChatTxn_Input input)
        {
            throw new NotImplementedException();
        }

        public Task<MutationCreateCompanyAndXUsersTxn_Output> MutationCreateCompanyAndXUsersTxn(MutationCreateCompanyAndXUsersTxn_Input input)
        {
            throw new NotImplementedException();
        }
        // </Mutation>
        
    }
}
