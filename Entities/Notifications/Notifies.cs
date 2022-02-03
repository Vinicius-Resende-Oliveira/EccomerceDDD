using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Notifications
{
    public class Notifies
    {
        public Notifies()
        {
            Notitycoes = new List<Notifies>();
        }

        [NotMapped]
        public string NomePropriedade { get; set; }

        [NotMapped]
        public string Message { get; set; }

        [NotMapped]
        public List<Notifies> Notitycoes { get; set; }

        public bool ValidatorPropertyString(string valor, string nomePropriedade)
        {
            if (string.IsNullOrWhiteSpace(valor) || string.IsNullOrWhiteSpace(nomePropriedade)){
                Notitycoes.Add(new Notifies 
                { 
                    Message = "Campo obrigatório",
                    NomePropriedade = nomePropriedade
                });
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ValidatorPropertyInt(int valor, string nomePropriedade)
        {
            if (valor < 1 || string.IsNullOrWhiteSpace(nomePropriedade)){
                Notitycoes.Add(new Notifies
                {
                    Message = "Valor deve ser maior que 0",
                    NomePropriedade = nomePropriedade
                });
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ValidatorPropertyDecimal(decimal valor, string nomePropriedade)
        {
            if (valor < 1 || string.IsNullOrWhiteSpace(nomePropriedade)){
                Notitycoes.Add(new Notifies
                {
                    Message = "Valor deve ser maior que 0",
                    NomePropriedade = nomePropriedade
                });
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
