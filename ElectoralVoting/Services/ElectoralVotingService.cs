using ElectoralVoting.Objects;
using ElectoralVoting.Validation;
using System.Collections.Generic;
using System.Linq;

namespace ElectoralVoting.Services
{
    class ElectoralVotingService
    {
        public List<CandidateData> CandidateDatas { get; private set; }
        private ElectoralVotingValidation _electoralVotingValidation;
        private string _image;

        public ElectoralVotingService()
        {
            CandidateDatas = new List<CandidateData>();
            _electoralVotingValidation = new ElectoralVotingValidation();
            _image = string.Empty;
        }

        public string AddCandidate(string name, string number)
        {
            string errors = _electoralVotingValidation.RegisterValidation(name, number, CandidateDatas);
            if (string.IsNullOrEmpty(errors))
                CandidateDatas.Add(new CandidateData(name, number, _image));
            else
                return errors;
            return "";
        }

        public void AddImage(string image)
        {
            _image = image;
        }

        public string ValidationRegisterFinish()
        {
            return (CandidateDatas.Count < 2)
                ? "É necessário no mínimo dois canditados para iniciar a votação."
                : "";
        }

        public void ComputeVote(int index)
        {
            CandidateDatas[index].Vote++;
        }

        public void CalculateVotes()
        {
            int totalVotes = CandidateDatas.Sum(x => x.Vote);
            if (totalVotes == 0)
                return;
            for (int i = 0; i < CandidateDatas.Count; i++)
                CandidateDatas[i].PercVote = (double)(CandidateDatas[i].Vote * 100) / totalVotes;
        }

        public int CandidateWithMoreVote()
        {
            return CandidateDatas.FindIndex(x => x.PercVote == CandidateDatas.Max(y => y.PercVote));
        }
    }
}
