using System.Collections.Generic;
using Xunit;

namespace entra21_tests
{
    public class CandidateTests
    {
        [Fact]
        public void CandidateTest()
        {
            // Dado / Setup
            var candidate = new Candidate("Noronha", "000,111,222-33");

            // Quando / Ação
            

            // Deve / Asserções
            Assert.NotNull(candidate);
        }
        [Fact]
        public void CandidateTest2()
        {
            // Dado / Setup
            var candidate = new Candidate("Noronha", "000,111,222-33");

            // Quando / Ação
            candidate.Vote();
            

            // Deve / Asserções
            Assert.NotNull(candidate);
            Assert.Equal(1, candidate.Votes);
        }

    }
}