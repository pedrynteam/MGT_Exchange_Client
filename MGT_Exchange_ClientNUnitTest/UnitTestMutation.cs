using MGT_Exchange_Client.GraphQL.Interface;
using MGT_Exchange_Client.GraphQL.Mutation;
using MGT_Exchange_Client.GraphQL.MVC;
using MGT_Exchange_Client.GraphQL.Query;
using MGT_Exchange_Client.GraphQL.Testing;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTest_Exchange
{
    class UnitExecuteMutationMin
    {
        IMGTClient clientMGT = new MGTClient();
        string url = "http://10.18.24.67:8082/";
        string token = "token";

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task ExecuteMutationCreateCompanyAndXUsersTxn()
        {
            MutationCreateCompanyAndXUsersTxn_Output output =
                await MGTMutationExecute.ExecuteMutationCreateCompanyAndXUsersTxn(clientMGT: clientMGT, _url: url, _token: token);

            Assert.That(output, Is.Not.Null);
            Assert.That(output.ResultConfirmation.resultPassed, Is.True);
            Assert.That(output.company, Is.Not.Null);
            Assert.That(output.company.users.Count, Is.GreaterThan(0));
        }

        [Test]
        public async Task ExecuteMutationCreateChatTxn()
        {
         
            MutationCreateChatTxn_Output output = 
                await MGTMutationExecute.ExecuteMutationCreateChatTxn(clientMGT: clientMGT, _url: url, _token: token);

            Assert.That(output, Is.Not.Null);
            Assert.That(output.ResultConfirmation.resultPassed, Is.True);
            Assert.That(output.chat, Is.Not.Null);
            Assert.That(output.chat.chatId, Is.GreaterThan(0));
        }

        [Test]
        public async Task ExecuteMutationAddCommentToChatTxn()
        {
            MutationAddCommentToChatTxn_Output output =
                await MGTMutationExecute.ExecuteMutationAddCommentToChatTxn(clientMGT: clientMGT, _url: url, _token: token);

            Assert.That(output, Is.Not.Null);
            Assert.That(output.ResultConfirmation.resultPassed, Is.True);
            Assert.That(output.comment, Is.Not.Null);
            Assert.That(output.comment.commentId, Is.GreaterThan(0));
        }

    }
}
