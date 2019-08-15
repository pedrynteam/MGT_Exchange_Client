using MGT_Exchange_Client.GraphQL.Execute;
using MGT_Exchange_Client.GraphQL.Interface;
using MGT_Exchange_Client.GraphQL.Query;
using MGT_Exchange_Client.GraphQL.Testing;
using NUnit.Framework;
using System.Threading.Tasks;

namespace NUnitTest_Exchange
{
    class UnitExecuteQueryMin
    {
        // https://wrightfully.com/assert-framework-comparison

        /* Calling the web service
        IMGTClient clientMGT = new MGTClient();
        string url = "http://10.18.24.67:8082/";
        // string url = "http://10.18.7.169:8082/";
        string token = "token";
        //*/

        // Mock Local
        IMGTClient clientMGT = new MGTClientMock();
        string url = "url";
        string token = "token";
        //*/

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task ExecuteQueryAllUsersByCompany()
        {
            QueryAllUsersByCompany_Output output = 
                await MGTQueryExecute.ExecuteQueryAllUsersByCompany(clientMGT: clientMGT, _url: url, _token: token);

            Assert.That(output, Is.Not.Null);
            Assert.That(output.ResultConfirmation.resultPassed, Is.True);
            Assert.That(output.company.users.Count, Is.GreaterThan(0));
        }

        [Test]
        public async Task ExecuteQueryRetrieveRecentChats()
        {
            QueryRetrieveMasterInformationByUser_Output output = 
                await MGTQueryExecute.ExecuteQueryRetrieveChatComments(clientMGT: clientMGT, _url: url, _token: token);

            Assert.That(output, Is.Not.Null);
            Assert.That(output.ResultConfirmation.resultPassed, Is.True);
            Assert.That(output.commentsNewest.Count, Is.GreaterThan(0));
        }

        [Test]        
        public async Task ExecuteQueryRetrieveChatComments()
        {
            QueryRetrieveMasterInformationByUser_Output output = 
                await MGTQueryExecute.ExecuteQueryRetrieveChatComments(clientMGT: clientMGT, _url: url, _token: token);

            Assert.That(output, Is.Not.Null);
            Assert.That(output.ResultConfirmation.resultPassed, Is.True);
            Assert.That(output.commentsNewest.Count, Is.GreaterThan(0));
        }

        
        [Test]
        public async Task ExecuteQueryChatsByUserMain()
        {
            QueryChatsByUserMain_Output output
                = await MGTQueryExecute.ExecuteQueryChatsByUserMain(clientMGT: clientMGT, _url: url, _token: token);
                ;
                
            Assert.That(output, Is.Not.Null);
            Assert.That(output.ResultConfirmation.resultPassed, Is.True);
            Assert.That(output.Chats.Count, Is.GreaterThan(0));
        }
    }
}
