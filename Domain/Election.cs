using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class Election
    {
        public Election()
        {
            candidates = new List<Candidate>();
        }

        // Esta propriedade tem a sua escrita privada, ou seja, ninguém de fora da classe pode alterar seu valor
        // Propriedade privada SEMPRE em camelcase
        private List<Candidate> candidates { get; set; }

        // Propriedade pública SEMPRE em PascalCase
        // Propriedade apenas com GET pode ser usada com arrow
        public IReadOnlyCollection<Candidate> Candidates => candidates;
        
        public bool CreateCandidates(List<Candidate> newCandidates, string password)
        {
            if (newCandidates == null)
            {
                return true;
            }
            if (password == "Pa$$w0rd")
            {
                candidates = newCandidates;

                return true;
            }
            else
            {
                return false;
            }
        }

        // ToDo: Criar método que retorne um Guid que represente o candidato pesquisado por CPF

        // ToDo: Este método deve retornar a lista de candidatos que tem o mesmo nome informado
        public Guid GetCandidateIdByName(string name)
        {
            return candidates.First(x => x.Name == name).Id;
        }

        public void Vote(Guid id)
        {
            var foundCandidate = candidates.Find(candidate => candidate.Id == id);
            foundCandidate.Vote();
        }

        public List<Candidate> GetWinners()
        {
            var winners = new List<Candidate>{candidates[0]};

            for (int i = 1; i < candidates.Count; i++)
            {
                if (candidates[i].Votes > winners[0].Votes)
                {
                    winners.Clear();
                    winners.Add(candidates[i]);
                }
                else if (candidates[i].Votes == winners[0].Votes)
                {
                    winners.Add(candidates[i]);
                }
            }
            return winners;
        }
    }
}