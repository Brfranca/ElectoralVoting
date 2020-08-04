
namespace ElectoralVoting.Objects
{
    class CandidateData
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public string Image { get; set; }
        public int Vote { get; set; }
        public double PercVote { get; set; }

        public CandidateData()
        {
        }

        public CandidateData(string name, string number, string image)
        {
            Name = name;
            Number = number;
            Image = image;
        }
    }
}
