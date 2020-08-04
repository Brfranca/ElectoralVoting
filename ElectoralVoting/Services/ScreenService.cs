using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ElectoralVoting.Services
{
    class ScreenService
    {
        private List<string> _images;
        private ElectoralVotingService _electoralService;

        public string CandidatePerctVote { get; set; }
        public string CandidateName { get; private set; }
        public string CandidateNumber { get; private set; }
        public string CandidateImage { get; private set; }
        public int CandidateIndex { get; private set; }

        public ScreenService(ElectoralVotingService electoralService)
        {
            _electoralService = electoralService;

            string path = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName;
            _images = new List<string>
            {
                 $@"{path}\Images\Batman.jpeg",
                 $@"{path}\Images\Coringa.jpeg",
                 $@"{path}\Images\Pikachu.png",
                 $@"{path}\Images\Reindeer.jfif",
                 $@"{path}\Images\Sherlock.jpg",
                 $@"{path}\Images\SuperMario1.jpeg",
                 $@"{path}\Images\Vendetta.jfif",
                 $@"{path}\Images\Wolverine.jfif",
                 $@"{path}\Images\Scoob.jpg"
            };
        }

        public string GetRandomImage()
        {
            Random random = new Random();
            int position = random.Next(0, 8);
            return _images[position];
        }

        public List<string> GetCandidatesNamesNumbers()
        {
            return _electoralService.CandidateDatas.Select(x => x.Number + " - " + x.Name).ToList();
        }

        public void SelectCandidate()
        {
            CandidateName = _electoralService.CandidateDatas[CandidateIndex].Name;
            CandidateNumber = _electoralService.CandidateDatas[CandidateIndex].Number;
            CandidateImage = _electoralService.CandidateDatas[CandidateIndex].Image;
            CandidatePerctVote = _electoralService.CandidateDatas[CandidateIndex].PercVote.ToString("F1");
        }

        public void DefineIndex(int index)
        {
            CandidateIndex = index;
            if (CandidateIndex < 0)
                CandidateIndex = 0;
        }

        public void IncreaseIndex()
        {
            CandidateIndex++;
            if (CandidateIndex >= _electoralService.CandidateDatas.Count)
                CandidateIndex = 0;
        }

        public void DecreaseIndex()
        {
            CandidateIndex--;
            if (CandidateIndex < 0)
                CandidateIndex = _electoralService.CandidateDatas.Count - 1;
        }
    }
}
