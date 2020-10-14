using Xunit;
using Domain;

namespace Tests
{
    public class CandidateTests
    {
        [Fact]
        public void Should_contains_same_parameters_provided()
        {
            var name = "João da Silva";
            var CPF = "895.658.478-89";
            
            var candidate = new Candidate(name, CPF);

            Assert.Equal(name, candidate.Name);
            Assert.Equal(CPF, candidate.CPF);
        }

        [Fact]
        public void Should_contains_votes_equals_zero()
        {
            var name = "João da Silva";
            var CPF = "895.658.478-89";

            var candidate = new Candidate(name, CPF);

            Assert.Equal(0, candidate.Votes);
        }

        [Fact]
        public void Should_contain_votes_equals_2_when_voted_twice()
        {
            var name = "João da Silva";
            var CPF = "895.658.478-89";
            var candidate = new Candidate(name, CPF);

            candidate.Vote();
            candidate.Vote();

            Assert.Equal(2, candidate.Votes);
        }

        [Fact]
        public void Should_not_generate_same_id_for_both_candidates()
        {
            var Jose = new Candidate("José", "895.456.214-78");
            var Ana = new Candidate("Ana", "456.456.214-78");
            
            Assert.NotEqual(Jose.Id, Ana.Id);
        }
        [Fact]
        public void CandidateTest2()
        {
            // Dado / Setup
            var candidate = new Candidate("Noronha", "819.091.880-00");

            // Quando / Ação
            candidate.Vote();
            

            // Deve / Asserções
            Assert.NotNull(candidate);
            Assert.NotNull(candidate.CPF);
            Assert.Equal("Noronha", candidate.Name);
            Assert.Equal("819.091.880-00", candidate.CPF);
            Assert.Equal(1, candidate.Votes);
        }
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("000.000.000-00")]
        [InlineData("000.000.000-01")]
        [InlineData("100.000.000-00")]
        [InlineData("999.999.999-99")]
        [InlineData("000.368.560-00")]
        [InlineData("640.3685606")]
        [InlineData("640.368.560-6")]
        [InlineData("640.368.560-6a")]
        [InlineData("640.368.560-061")]
        public void Should_return_false_when_CPF_is_invalid(string CPF)
        {
            // Dado / Setup
            var Jose = new Candidate("José", CPF);

            // When / Ação
            var isValid = Jose.Validate();
            
            // Deve / Asserções
            Assert.False(isValid);
        }

        [Theory]
        [InlineData("64036856006")]
        [InlineData("640.368.560-06")]
        public void Should_return_true_when_CPF_is_valid(string CPF)
        {
            // Dado / Setup
            var Jose = new Candidate("José", CPF);

            // When / Ação
            var isValid = Jose.Validate();
            
            // Deve / Asserções
            Assert.True(isValid);
        }
        [Theory]
        [InlineData("J0n47h4n")]
        [InlineData("Jo   nathan")]
        [InlineData("Jonathan     ")]
        [InlineData("  Jonathan")]
        [InlineData("J%#!(#*n")]
        [InlineData("!4@!")]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(" h")]
        [InlineData(" G")]
        [InlineData(null)]
        public void should_return_false_when_invalid_name(string name)
        {
            var candidate = new Candidate(name, "814.460.920-46");

            var isValid = candidate.ValidateName();

            Assert.False(isValid);
        }

        [Theory]
        [InlineData("Jonathan")]
        [InlineData("JONATHAN")]
        public void should_return_true_when_valid_name(string name)
        {
            var candidate = new Candidate(name, "814.460.920-46");

            var isValid = candidate.ValidateName();

            Assert.True(isValid);
        }
    }
}