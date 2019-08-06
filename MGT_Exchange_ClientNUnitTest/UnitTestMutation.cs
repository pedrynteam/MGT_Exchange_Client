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
    class UnitTestMutationMin
    {        
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task TestMutationCreateCompanyAndXUsersTxn()
        {
            MutationCreateCompanyAndXUsersTxn_Output output =
                await MGTMutationTest.TestMutationCreateCompanyAndXUsersTxn();

            Assert.That(output, Is.Not.Null);
            Assert.That(output.ResultConfirmation.resultPassed, Is.True);
            Assert.That(output.company, Is.Not.Null);
            Assert.That(output.company.users.Count, Is.GreaterThan(0));
        }

        [Test]
        public async Task TestMutationCreateChatTxn()
        {
         
            MutationCreateChatTxn_Output output = 
                await MGTMutationTest.TestMutationCreateChatTxn();

            Assert.That(output, Is.Not.Null);
            Assert.That(output.ResultConfirmation.resultPassed, Is.True);
            Assert.That(output.chat, Is.Not.Null);
            Assert.That(output.chat.chatId, Is.GreaterThan(0));
        }

        [Test]
        public async Task TestMutationAddCommentToChatTxn()
        {
            MutationAddCommentToChatTxn_Output output =
                await MGTMutationTest.TestMutationAddCommentToChatTxn();

            Assert.That(output, Is.Not.Null);
            Assert.That(output.ResultConfirmation.resultPassed, Is.True);
            Assert.That(output.comment, Is.Not.Null);
            Assert.That(output.comment.commentId, Is.GreaterThan(0));
        }

    }
}
