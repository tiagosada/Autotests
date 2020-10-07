using System.Collections.Generic;
using Xunit;
using Domain;

namespace Tests
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
            Assert.NotNull(candidate.Cpf);
            Assert.Equal("Noronha", candidate.Name);
            Assert.Equal("000,111,222-33", candidate.Cpf);
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
            Assert.NotNull(candidate.Cpf);
            Assert.Equal("Noronha", candidate.Name);
            Assert.Equal("000,111,222-33", candidate.Cpf);
            Assert.Equal(1, candidate.Votes);
        }

    }
}