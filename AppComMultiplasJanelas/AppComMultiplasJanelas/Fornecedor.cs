using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppComMultiplasJanelas
{
    public class Fornecedor
    {
        [DisplayName("Id")] public int Id { get; set; }
        [DisplayName("CNPJ")] public string CNPJ { get; set; }
        [DisplayName("Nome da empresa")] public string NomeEmpresa { get; set; }
        [DisplayName("Nome do contato")] public string NomeContato { get; set; }
        [DisplayName("Número de telefone")] public string Telefone { get; set; }
        [DisplayName("Endereço de E-mail")] public string Email { get; set; }
        [DisplayName("Endereço Físico")] public string Endereço { get; set; }
    }
}
