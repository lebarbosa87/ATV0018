using System.Runtime.ConstrainedExecution;

namespace Zuplae.Aulas.Atv0012.Models
{
    // classe filha ou derivada - classe Mãe ou base
    public class Endereco : BaseModel // Herança
    {
        #region Propriedades
        public String Logradouro { get; set; }
        public String Numero { get; set; }
        public String Complemento { get; set; }
        public String Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public String Cep { get; set; }
        #endregion
        #region Metodos
            public override string ToString()
            {
                return $"{GetLogradouro()}, {GetNumero()} {GetComplemento()}, {GetBairro()}, {GetCidade()} - {GetEstado()}, CEP: {GetCep()}";
            }
        #endregion
    }
}
