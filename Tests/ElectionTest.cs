using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Domain;

namespace Tests
{
    public class ElectionTest
    {
        [Fact]
        public void should_not_create_candidates_when_password_is_incorrect()
        {
            // Dado / Setup
            var election = new Election();
            var candidates = ListOfCandidates(1);

            // Quando / Ação
            var created = election.CreateCandidates(candidates, "incorrect");

            // Deve / Asserções
            Assert.Empty(election.Candidates);
            Assert.False(created);
        }

        [Fact]
        public void should_create_candidates_when_password_is_correct()
        {
            // Dado / Setup

            // OBJETO election
            var election = new Election();
            var candidates = ListOfCandidates(1);

            // Quando / Ação

            // Estamos acessando o MÉTODO CreateCandidates do OBJETO election
            var created = election.CreateCandidates(candidates, "Pa$$w0rd");

            // Deve / Asserções
            Assert.True(created);

            // Estamos acessando a PROPRIEDADE Candidates, que faz parte do ESTADO do OBJETO election
            Assert.Equal(1, election.Candidates.Count);
            Assert.Equal("Ana", election.Candidates.ElementAt(0).Name);
        }

        [Fact]
        public void should_not_generate_same_id_for_both_candidates()
        {
            // Dado / Setup

            // OBJETO election
            var election = new Election();
            var candidates = ListOfCandidates(2);
            election.CreateCandidates(candidates, "Pa$$w0rd");
            
            // Quando / Ação
            var candidateFernando = election.GetCandidateIdByName("Fernando");
            var candidateAna = election.GetCandidateIdByName("Ana");

            // Deve / Asserções
            Assert.NotEqual(candidateAna, candidateFernando);
        }

        [Fact]
        public void should_vote_twice_in_candidate_Fernando()
        {
            // Dado / Setup
            // OBJETO election
            var election = new Election();
            var candidates = ListOfCandidates(3);
            election.CreateCandidates(candidates, "Pa$$w0rd");
            var fernandoCPF = candidates[1].CPF;
            var anaCPF = candidates[0].CPF;
            // Quando / Ação
            // Estamos acessando o MÉTODO ShowMenu do OBJETO election
            election.Vote(fernandoCPF);
            election.Vote(fernandoCPF);

            // Deve / Asserções
            var candidateFernando = election.Candidates.First(x => x.CPF == fernandoCPF);
            var candidateAna = election.Candidates.First(x => x.CPF == anaCPF);
            Assert.Equal(2, candidateFernando.Votes);
            Assert.Equal(0, candidateAna.Votes);
        }
        [Fact]
        public void should_return_false_and_not_vote_if_cpf_is_invalid()
        {
            // Dado / Setup
            // OBJETO election
            var election = new Election();
            var candidates = ListOfCandidates(1);
            election.CreateCandidates(candidates, "Pa$$w0rd");
            var anaId = election.GetCandidateIdByName("Ana");
            // Quando / Ação
            // Estamos acessando o MÉTODO ShowMenu do OBJETO election
            var voted = election.Vote("525,114,142-85");


            // Deve / Asserções
            var candidateFernando = election.Candidates.First(x => x.Id == anaId);
            Assert.Equal(0, candidateFernando.Votes);
            Assert.False(voted);
        }

        [Fact]
        public void should_return_Ana_as_winner_when_only_Ana_receives_votes()
        {
            // Dado / Setup
            // OBJETO election
            var election = new Election();
            var candidates = ListOfCandidates(4);
            election.CreateCandidates(candidates, "Pa$$w0rd");
            var anaId = election.GetCandidateIdByName("Ana");
            var anaCPF = candidates[0].CPF;
            
            // Quando / Ação
            // Estamos acessando o MÉTODO ShowMenu do OBJETO election
            election.Vote(anaCPF);
            election.Vote(anaCPF);
            var winners = election.GetWinners();

            // Deve / Asserções
            Assert.Equal(1, winners.Count);
            Assert.Equal(anaId, winners[0].Id);
            Assert.Equal(2, winners[0].Votes);
        }

        [Fact]
        public void should_return_both_candidates_when_occurs_draw()
        {
            // Dado / Setup
            // OBJETO election
            var election = new Election();
            var candidates = ListOfCandidates(2);
            election.CreateCandidates(candidates, "Pa$$w0rd");
            var fernandoId = election.GetCandidateIdByName("Fernando");
            var fernandoCPF = candidates[1].CPF;
            var anaId = election.GetCandidateIdByName("Ana");
            var anaCPF = candidates[0].CPF;
            
            // Quando / Ação
            // Estamos acessando o MÉTODO ShowMenu do OBJETO election
            election.Vote(anaCPF);
            election.Vote(fernandoCPF);
            var winners = election.GetWinners();

            // Deve / Asserções
            var candidateFernando = winners.Find(x => x.Id == fernandoId);
            var candidateAna = winners.Find(x => x.Id == anaId);
            Assert.Equal(1, candidateFernando.Votes);
            Assert.Equal(1, candidateAna.Votes);
        }
        private List<Candidate> ListOfCandidates(int amount)
        {
            
            var candidatesList = new List<Candidate>()
            { 
                new Candidate("Ana","182.518.430-57"),
                new Candidate("Fernando", "324.622.360-23"),
                new Candidate("João","754.981.600-03"),
                new Candidate("Maria","801.210.080-02")
            };
            if (amount > candidatesList.Count())
            {
                amount = candidatesList.Count();
            }
            else if (amount < 1)
            {
                amount = 1;
            }
            return candidatesList.Take(amount).ToList();
        }
    }
}