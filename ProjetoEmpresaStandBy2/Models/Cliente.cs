using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ProjetoEmpresaStandBy2.Models
{
    public class Cliente
    {
        public Cliente()
        {
        }

        [DataMember]
        public int ClienteId { get; protected set; }
        public string razao_social { get; set; }
        [Required(ErrorMessage = "Data de Fundação não pode ser nulo")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Fundação")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime data_fundacao { get; set; }
        [Required(ErrorMessage = "CNPJ é obrigatório")]
        [Display(Name = "CNPJ")]
        public string cnpj { get; set; }
        [Display(Name = "Capital")]
        public decimal capital { get; set; }
        [Display(Name = "Quarentena")]
        public bool quarentena { get; set; }
        [Display(Name = "Status do Cliente")]
        public bool status_cliente { get; set; }
        [Display(Name = "Classificação")]
        [Required(ErrorMessage = "Data Função não pode ser nulo")]
        public string classificacao { get; set; }

        public Cliente(string razao_social, DateTime data_fundacao, string cnpj, decimal capital, bool quarentena, bool status_cliente,
                       string classificacao)
        {
            this.razao_social = razao_social;
            this.data_fundacao = data_fundacao;
            this.cnpj = cnpj;
            this.capital = capital;
            this.quarentena = quarentena;
            this.status_cliente = status_cliente;
            this.classificacao = classificacao;
        }
    }
}
