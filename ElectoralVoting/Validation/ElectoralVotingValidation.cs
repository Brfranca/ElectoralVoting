using ElectoralVoting.Objects;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElectoralVoting.Validation
{
    class ElectoralVotingValidation
    {
        public string RegisterValidation(string name, string number, List<CandidateData> candidateDatas)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(name))
                errors.AppendLine("Escreva o nome do candidato.");
            else if (name.Any(char.IsNumber))
                errors.AppendLine("Corrija o nome do candidato, é permitido apenas letras.");
            if (candidateDatas.Any(x => x.Name.ToLower() == name.ToLower()))
                errors.AppendLine("Esse nome já foi cadastrado, escolha outro.");
            if (string.IsNullOrWhiteSpace(number))
                errors.AppendLine("Escreva o número do candidato.");
            else if (!number.All(char.IsNumber))
                errors.AppendLine("Corrija o número do candidato, é permitido apenas números.");
            if (candidateDatas.Any(x => x.Number == number))
                errors.AppendLine("Esse número já foi cadastrado, escolha outro.");
            return errors.ToString();
        }
    }
}
