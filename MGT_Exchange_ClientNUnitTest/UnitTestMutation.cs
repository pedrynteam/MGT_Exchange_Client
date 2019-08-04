using MGT_Exchange_Client.GraphQL.Mutation;
using MGT_Exchange_Client.GraphQL.MVC;
using MGT_Exchange_Client.GraphQLMin.Query;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTest_Exchange
{
    class UnitTestMutationMin
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task TestMutationCreateCompanyAndXUsersTxn()
        {
            MutationCreateCompanyAndXUsersTxn_Input input = new MutationCreateCompanyAndXUsersTxn_Input
            {
                company = new company
                {
                    name = "company8",
                    description= "one",
                    email = "one@one.com",
                    password = "12345"
                },
                userstocreate = 10,
                url = "http://10.18.24.67:8082/",
                token = "token"
            };

            MutationCreateCompanyAndXUsersTxn_Output output = await new MutationCreateCompanyAndXUsersTxn().Execute(input: input);

            Assert.That(output, Is.Not.Null);
            Assert.That(output.ResultConfirmation.resultPassed, Is.True);
            Assert.That(output.company, Is.Not.Null);
            Assert.That(output.company.users.Count, Is.GreaterThan(0));

        }

        [Test]
        public async Task TestMutationCreateChatTxn()
        {

            // Pending, when the user is not from this company return: Ineer Exception 
            List<participant> participants = new List<participant>
            {
                new participant {
                    participantId = 0,
                    chatId = 0,
                    isAdmin = true,
                    userAppId = "10d3ed1e-ae7d-4d0c-80e0-aa360d76025b"
                },
                new participant {
                    participantId = 0,
                    chatId = 0,
                    isAdmin = false,
                    userAppId = "127b0df2-d732-478e-bf84-0b673c48d145"
                }/*,
                new participant {
                    participantId = 0,
                    chatId = 0,
                    isAdmin = false,
                    userAppId = "3982349d-289d-4f3a-ab29-f3f6bb3893f4"
                },*/
            };

            MutationCreateChatTxn_Input input = new MutationCreateChatTxn_Input
            {
                chat = new chat
                {
                    chatId = 0,
                    name = "Chat 1",
                    companyId = "04c6b67c-6f4d-455f-a472-d6206dd769df",
                    participants = participants
                },
                url = "http://10.18.24.67:8082/",
                token = "token"
            };

            MutationCreateChatTxn_Output output = await new MutationCreateChatTxn().Execute(input: input);

            Assert.That(output, Is.Not.Null);
            Assert.That(output.ResultConfirmation.resultPassed, Is.True);
            Assert.That(output.chat, Is.Not.Null);
            Assert.That(output.chat.chatId, Is.GreaterThan(0));

        }

        [Test]
        public async Task TestMutationAddCommentToChatTxn()
        {
            MutationAddCommentToChatTxn_Input input = new MutationAddCommentToChatTxn_Input
            {
                comment = new comment
                {                   
                    chatId= 3,
                    message= "Hello There",        
                    userAppId= "10d3ed1e-ae7d-4d0c-80e0-aa360d76025b"
                },                
                url = "http://10.18.24.67:8082/",
                token = "token"
            };

            MutationAddCommentToChatTxn_Output output = await new MutationAddCommentToChatTxn().Execute(input: input);

            Assert.That(output, Is.Not.Null);
            Assert.That(output.ResultConfirmation.resultPassed, Is.True);
            Assert.That(output.comment, Is.Not.Null);
            Assert.That(output.comment.commentId, Is.GreaterThan(0));

        }

    }
}
