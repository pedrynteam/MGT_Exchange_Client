using MGT_Exchange_Client.GraphQL.Query;
using MGT_Exchange_Client.GraphQL.Testing;
using NUnit.Framework;
using System.Threading.Tasks;

namespace NUnitTest_Exchange
{
    class UnitTestQueryMin
    {
        // https://wrightfully.com/assert-framework-comparison
        
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task TestQueryAllUsersByCompany()
        {
            QueryAllUsersByCompany_Output output = 
                await MGTQueryTest.TestQueryAllUsersByCompany();

            Assert.That(output, Is.Not.Null);
            Assert.That(output.ResultConfirmation.resultPassed, Is.True);
            Assert.That(output.company.users.Count, Is.GreaterThan(0));
        }

        [Test]
        public async Task TestQueryRetrieveRecentChats()
        {
            QueryRetrieveMasterInformationByUser_Output output = 
                await MGTQueryTest.TestQueryRetrieveRecentChats();

            Assert.That(output, Is.Not.Null);
            Assert.That(output.ResultConfirmation.resultPassed, Is.True);
            Assert.That(output.commentsNewest.Count, Is.GreaterThan(0));
        }

        [Test]        
        public async Task TestQueryRetrieveChatComments()
        {
            QueryRetrieveMasterInformationByUser_Output output = 
                await MGTQueryTest.TestQueryRetrieveChatComments();

            Assert.That(output, Is.Not.Null);
            Assert.That(output.ResultConfirmation.resultPassed, Is.True);
            Assert.That(output.commentsNewest.Count, Is.GreaterThan(0));
        }
    }
}
